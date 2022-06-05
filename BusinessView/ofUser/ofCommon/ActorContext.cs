﻿using BusinessData.ofPresendationLayer.ofDTOServices;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofServices;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using FluentValidation;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using NMemory.Tables;

namespace BusinessView.ofUser.ofCommon
{
    public class ActorOption
    {
        public bool IsUseStorage = false;
    }
    // Get 및 Gets는 관련 데이터까지 로드하는 것을 의미한다.
    public abstract class ActorContext
    {
        protected ServiceBuilder ServiceBuilder = new();
        protected StorageBuilder StorageBuilder = new();
        protected ValidatorBuilder ValidatorBuilder = new();
        public ActorContext()
        {
            OnServiceBuilder(ServiceBuilder);
            OnValidatorBuilder(ValidatorBuilder);
            OnStrorageBuilder(StorageBuilder);
        }
        protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
        protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
        protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }
        public abstract Task<T> PostAsync<T>(T t, MultipartFormDataContent content) where T : EntityDTO, new();
        public abstract Task<T> PostAsync<T>(T t) where T : EntityDTO, new();
        public abstract Task<T> PutAsync<T>(T t) where T : EntityDTO, new();
        public abstract Task<T> GetByIdAsync<T>(string id) where T : EntityDTO, new();
        public abstract Task DeleteByIdAsync<T>(string id) where T : EntityDTO, new();
        public abstract Task<IEnumerable<T>> GetsAsync<T>() where T : EntityDTO, new();
        public abstract Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid) where T : EntityDTO, new();
        public abstract IValidator<T> GetValidator<T>() where T : EntityDTO, new();
        public abstract ITable<T> GetMemoryTable<T>() where T : EntityDTO, new();
        public abstract DTOService GetDTOService<T>() where T : EntityDTO, new();
    }
}
