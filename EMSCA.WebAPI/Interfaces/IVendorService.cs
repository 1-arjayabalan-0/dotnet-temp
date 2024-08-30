using System.Threading.Tasks;
using EMSCA.Application.Repository;
using EMSCA.Domain.CustomEntities;
using Newtonsoft.Json.Linq;

namespace EMSCA.Application.Interfaces
{
    public interface IVendorService: IBaseRepository<CustomResponse>
    {
        // Task<object> SearchInitialize(JObject input);
        // Task<object> CreateInitialize(JObject input);
        Task<CustomResponse> Create(JObject input,IFormFile accountFiles,IFormFile documentFiles);
        // // Task<object> Update(JObject input,IFormFile accountFiles,IFormFile documentFiles);
        // // Task<object> Delete(JObject input);
        
    }

};