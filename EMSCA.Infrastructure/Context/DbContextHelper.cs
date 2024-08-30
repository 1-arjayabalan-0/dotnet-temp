using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EMSCA.Infrastructure.Data;

public partial class DbContextHelper : DbContext
{
    public DbContextHelper()
    {
    }

    public DbContextHelper(DbContextOptions<DbContextHelper> options)
        : base(options)
    {
    }

    public virtual DbSet<Accountdetail> Accountdetails { get; set; }

    public virtual DbSet<Documentdetail> Documentdetails { get; set; }

    public virtual DbSet<Metadata> Metadata { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.210;Database=Event_Management_Dev;User ID=sa;Password=$erver2019;MultipleActiveResultSets=true;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accountdetail>(entity =>
        {
            entity.HasKey(e => e.Accountid);

            entity.ToTable("accountdetails");

            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Accountholdername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accountholdername");
            entity.Property(e => e.Accountnumber).HasColumnName("accountnumber");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankname");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createdon).HasColumnName("createdon");
            entity.Property(e => e.Docname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docname");
            entity.Property(e => e.Docurl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("docurl");
            entity.Property(e => e.Ifsccode).HasColumnName("ifsccode");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Accountdetails)
                .HasForeignKey(d => d.Vendorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_accountdetails_vendorid");
        });

        modelBuilder.Entity<Documentdetail>(entity =>
        {
            entity.HasKey(e => e.Documentid);

            entity.ToTable("documentdetails");

            entity.Property(e => e.Documentid).HasColumnName("documentid");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createdon).HasColumnName("createdon");
            entity.Property(e => e.Documentname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documentname");
            entity.Property(e => e.Documentnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documentnumber");
            entity.Property(e => e.Documenturl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("documenturl");
            entity.Property(e => e.Documentype).HasColumnName("documentype");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Documentdetails)
                .HasForeignKey(d => d.Vendorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_documentdetails_vendorid");
        });

        modelBuilder.Entity<Metadata>(entity =>
        {
            entity.HasKey(e => e.MetaSubId);

            entity.Property(e => e.MetaSubId).HasColumnName("Meta_Sub_Id");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
            entity.Property(e => e.MetaSubCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Meta_Sub_Code");
            entity.Property(e => e.MetaSubDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Meta_Sub_Description");
            entity.Property(e => e.MetaTypeCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Meta_Type_Code");
            entity.Property(e => e.MetaTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Meta_Type_Name");
            entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");
            entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.ToTable("vendor");

            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Companyname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("companyname");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createdon).HasColumnName("createdon");
            entity.Property(e => e.Mailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mailid");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");
            entity.Property(e => e.Primarycontactno).HasColumnName("primarycontactno");
            entity.Property(e => e.Secondarycontactno).HasColumnName("secondarycontactno");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Vendorname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendorname");
            entity.Property(e => e.Vendortypeid).HasColumnName("vendortypeid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
