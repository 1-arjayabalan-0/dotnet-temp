using EMSCA.Domain.CustomEntities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSCA.Application.Repository
{
    public interface IBaseRepository<T> where T : CustomResponse
    {
        public Task<T> SearchInitialize(JObject obj);
        public Task<T> CreateInitialize(JObject obj);
        public Task<T> Cancel(JObject obj);
        public Task<T> ChangeStatus(JObject obj);
        public Task<T> Create(JObject obj);
        public Task<T> Update(JObject obj);
    }
}
