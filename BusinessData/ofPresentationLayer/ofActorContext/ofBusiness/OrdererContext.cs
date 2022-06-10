using BusinessData.ofPresendationLayer.ofDTOServices;
using BusinessView.ofUser.ofCommon;
using FluentValidation;
using NMemory.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofActorContext.ofBusiness
{
    public class OrdererContext : ActorContext
    {
        public override Task DeleteByIdAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override Task<T> GetByIdAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override DTOService GetDTOService<T>()
        {
            throw new NotImplementedException();
        }

        public override ITable<T> GetMemoryTable<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<T>> GetsAsync<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid)
        {
            throw new NotImplementedException();
        }

        public override IValidator<T> GetValidator<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<T> PostAsync<T>(T t, MultipartFormDataContent content)
        {
            throw new NotImplementedException();
        }

        public override Task<T> PostAsync<T>(T t)
        {
            throw new NotImplementedException();
        }

        public override Task<T> PutAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
