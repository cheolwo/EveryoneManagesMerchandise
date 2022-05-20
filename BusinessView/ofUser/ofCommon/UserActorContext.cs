﻿using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using NMemory.Tables;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using BusinessView.ofValidator.ofCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components.Forms;

namespace BusinessView.ofCommon.ofUser
{
    public class UserActorContext : ActorContext
    {
        protected ActorServiceOption _options = new();
        private IdentityUser _identityUser = new();
        public UserActorContext(ActorServiceOption options)
        {
            _options = options;
        }
        public virtual void OnConfigureActor(IdentityUser identityUser)
        {
            _identityUser = identityUser;
        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(IdentityUserDTO), new IdentityUserDTOService(_options.DTOServiceOptions));
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {
        }

        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilder)
        {
        }
        /*
        //  1. Validate 단계  
            (1) 성공시 Service.PostAsync(t) 를 실행
            (2) 실패시 예외처리
        //  2. Service 단계
                Post 할 파일이 있는 경우 MemoryStream 으로 변환하여 Post 하는 단계
        //     (1). 성공 시 Service 값을 스토리지에 저장하는 단계
        //     (2)  실패 시 thorw 하는 단계를 포함하는 PostAsync() 프로세스
        
            3. Storage 단게
                PostValue를 InMemeoryDatabase 에 저장하는 단계
         */
        public override async Task<T> PostAsync<T>(T t)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);
            EntityDTOValidator validator = ValidatorBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException(nameof(DTOService)); }
            if (storage == null) { throw new NullReferenceException(nameof(ITable<T>)); }
            if (validator == null) { throw new NullReferenceException(nameof(EntityDTOValidator)); }


            T? Value = await service.PostAsync<T>(t);
            if (Value != null) { storage.Insert(Value); return Value; }
            else { throw new NullReferenceException("PostService Value Is Null"); }
        }
        public override async Task<T> PostAsync<T>(T t, MultipartFormDataContent content)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);
            EntityDTOValidator validator = ValidatorBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException(nameof(DTOService)); }
            if (storage == null) { throw new NullReferenceException(nameof(ITable<T>)); }
            if (validator == null) { throw new NullReferenceException(nameof(EntityDTOValidator)); }


            T? Value = await service.PostAsync<T>(t, content);
            if (Value != null) { storage.Insert(Value); return Value; }
            else { throw new NullReferenceException("PostService Value Is Null"); }
        }
        /*
            1. Validate 단계
            2. Service 단계
                1, 2 단계의 경우 Post 와 유사 PutAsync() 를 이용한다는 점이 다름.
            3. Storage 단계
                (1) Storage 에 있는 PostValue 를 확인
                (2) 없을 경우 PutValue를 삽입
                (3) 있을 경우 삭제하고 PutValue를 삽입
        */
        public override async Task<T> PutAsync<T>(T t)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);
            EntityDTOValidator validator = ValidatorBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException("Service Is Null So Register Service!"); }
            if (storage == null) { throw new NullReferenceException("Storage Is Null So Register Storage!"); }
            if (validator == null) { throw new NullReferenceException("Validator Is Null So Register Storage!"); }

            var Result = validator.Validate(t);
            if (Result.IsValid)
            {
                var StorageValue = storage.FirstOrDefault(e => e.Equals(t));
                if (StorageValue != null) { storage.Delete(StorageValue); }
                T? Value = await service.PutAsync<T>(t);
                if (Value != null)
                {
                    storage.Insert(Value);
                    return Value;
                }
                else { throw new NullReferenceException("PutService Value Is Null"); }
            }
            else
            {
                throw new ValidationException("It is Not Validate");
            }
        }
        /*
            1. Storage Value 값 조회 단계
                (1) 있을 경우 반환하고 스레드 종료
                (2) 없을 경우 Service 단계 실행
            2. Service GetByIdAsync() 단계
                (1) 있을 경우 값의 User Id와 IdentityUserId가 같은지 확인
                     (1) - 1 같은 경우 Storage에 저장하고 반환
                     (1) - 2 같지 않은 경우 유저 불일치 예외발생
                (2) 없을 경우 예외발생
                UserActorContext.GetByIdAsync<T>(string id) 는 유저와 관련한 객체만읆 Return 하는 것을
                특징으로 한다.
        */
        public override async Task<T> GetByIdAsync<T>(string id)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException("Service Is Null So Register Service!"); }
            if (storage == null) { throw new NullReferenceException("Storage Is Null So Register Storage!"); }

            var StorageValue = storage.FirstOrDefault(e => e.EqualsById(id));
            if (StorageValue != null) { return StorageValue; }
            else
            {
                var ServiceValue = await service.GetByIdAsync<T>(id);
                if (ServiceValue != null) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }
        /*

        */
        public override async Task DeleteByIdAsync<T>(string id)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException("Service Is Null So Register Service!"); }
            if (storage == null) { throw new NullReferenceException("Storage Is Null So Register Storage!"); }

            var StorageValue = storage.FirstOrDefault(e => e.EqualsById(id));
            if (StorageValue != null) { storage.Delete(StorageValue); }

            await service.DeleteAsync<T>(id);
        }

        public override async Task<IEnumerable<T>> GetsAsync<T>()
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException("Service Is Null So Register Service!"); }
            if (storage == null) { throw new NullReferenceException("Storage Is Null So Register Storage!"); }
            if (storage.Count > 0) { return storage.ToList(); }
            else
            {
                var ServiceValue = await service.GetsAsync<T>();
                if (ServiceValue != null) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }

        public override async Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException("Service Is Null So Register Service!"); }
            if (storage == null) { throw new NullReferenceException("Storage Is Null So Register Storage!"); }
            if (storage.Count > 0) { return storage.ToList(); }
            else
            {
                var ServiceValue = await service.GetsAsyncByUserId<T>(userid);
                if (ServiceValue != null) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }
    }
}
