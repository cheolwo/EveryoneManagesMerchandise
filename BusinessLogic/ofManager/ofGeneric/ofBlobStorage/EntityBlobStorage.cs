// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using BusinessData;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;

namespace BusinessLogic.ofManager.ofGeneric.ofBlobStorage
{
    public class BlobOption
    {
        private string ConnectionString { get; set; }
        public BlobOption(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
    }
    public class BlobStorage
    {
        private BlobOption Option { get; set; }
        public BlobStorage(BlobOption option)
        {
            Option = option;
        }
    }
    public interface IEntityBlobStorage<TEntity> where TEntity : Entity, IRelationable
    {
        Task<TEntity> UploadAsync(TEntity entity, List<IBrowserFile> files, string connectionString);
        Task DownLoadAsync(TEntity entity, string downloadPath);
        Task<List<BlobItem>> GetToListByContainerName(string containerName);
    }
    public class EntityBlobStorage<TEntity> : IEntityBlobStorage<TEntity> where TEntity : Entity, IRelationable
    {
        private readonly IEntityContainerFactory<TEntity> _entityBlobContainerFactory;
        public EntityBlobStorage(IEntityContainerFactory<TEntity> entityBlobContainerFactory)
        {
            _entityBlobContainerFactory = entityBlobContainerFactory;
        }
        public async Task<TEntity> UploadAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            if (entity.Container == null)
            {
                entity.Container = await _entityBlobContainerFactory.CreateNameofContainer(entity);
                blobServiceClient.CreateBlobContainer(entity.Container);
            }
            if(files.Count == 0) {return entity;}
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
            foreach (var file in files)
            {
                var Result = await blobContainerClient.UploadBlobAsync(file.Name, file.OpenReadStream());
                ImageofInfo imageofInfo = new();
                imageofInfo.fileName = file.Name;
                imageofInfo.Id = (int)Result.Value.BlobSequenceNumber;
                imageofInfo.Info = file.Size.ToString();
                imageofInfo.Purpose = "Image";
                entity.ImageofInfos.Add(imageofInfo);
            }
            return entity;
        }
        public Task DownLoadAsync(TEntity entity, string downloadPath)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<BlobItem>> GetToListByContainerName(string containerName)
        {
            throw new System.NotImplementedException();
        }
    }

}
