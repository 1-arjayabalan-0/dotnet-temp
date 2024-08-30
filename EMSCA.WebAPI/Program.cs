using EMSCA.Application;
using EMSCA.Infrastructure;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json.Serialization;
using EMSCA.Infrastructure.Context.DapperContext;
// using EMSCA.WebAPI.Services;
// using EMSService.WebAPI.Vendorservice;
using Microsoft.Extensions.DependencyInjection.Extensions;
// using EMSCA.WebAPI.Services.FileUploadService;
using EMSCA.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore.Diagnostics;
using EMSCA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using EMSCA.Application.Interfaces;
using EMSCA.WebAPI.Extensions;
using EMSCA.Infrastructure.Data;
// using EMSCA.Domain.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EMSConn");
// Register services here
// Ensure all service registrations happen before calling Build()
builder.Services.AddHttpContextAccessor();
// builder.Services.TryAddScoped<FileUploadService>();
builder.Services.AddSingleton<IDbConnectionFactory>(provider =>
    {
        var configuration = provider.GetRequiredService<IConfiguration>();
        var databaseType = configuration.GetValue<string>("DatabaseType");

        return databaseType switch
        {
            "MySql" => new MySqlConnectionFactory(configuration),
            "SqlServer" => new SqlServerConnectionFactory(configuration),
            _ => throw new NotSupportedException("Database type not supported")
        };
    });
builder.Services.TryAddScoped<IDapperContext, DapperContext>();
// builder.Services.TryAddScoped<IUowProvider, UowProvider>();
// builder.Services.TryAddScoped<IVendorService, VendorService>();
// builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.ConfigureApplication();
// builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
// builder.Services.Configure<DbConnectionInfo>(settings => builder.Configuration.GetSection("ConnectionStrings").Bind(settings));
// builder.Services.AddScoped<DbContextHelper>();

// builder.Services.AddDbContext<DbContextHelper>(opt =>
//            {
//                opt.UseSqlServer(connectionString);
//                opt.EnableSensitiveDataLogging();
//                opt.ConfigureWarnings(warnings =>
//                    warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning)
//                    .Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)
//                    );
//            });
// builder.Services.AddDataAccess<DbContextHelper>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EMSCA", Version = "v1" });
});

#region Sql Connection Set Up

builder.Services.Configure<FormOptions>(o =>
{
    o.ValueLengthLimit = int.MaxValue;
    o.MultipartBodyLengthLimit = int.MaxValue;
    o.MemoryBufferThreshold = int.MaxValue;
});

builder.Services.AddControllers()
               .AddNewtonsoftJson(options =>
               {
                   options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
               });

var key = "64A63153-11C1-4919-9133-EFAF99A9B456";
builder.Services
    .AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateLifetime = true,
            RequireExpirationTime = true,
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key))
        };
    });
#endregion



var app = builder.Build();

// Application pipeline configuration
app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
// app.UseErrorHandler();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors();
app.MapControllers();

// Ensure database is created
// using (var serviceScope = app.Services.CreateScope())
// {
//     var dataContext = serviceScope.ServiceProvider.GetService<DbContextHelper>();
//     dataContext?.Database.EnsureCreated();
// }

app.Run();

public class DbConnectionInfo
{
    public string EMSConn { get; set; }
}