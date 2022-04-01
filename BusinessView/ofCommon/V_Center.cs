﻿using BusinessData;
using BusinessData.ofCommon.ofInterface;
using System.Reflection;
using System;

namespace BusinessView.ofCommon
{
    public class DTOEntity
    {

    }
    public interface IDTO
    {

    }
    public class V_Entity
    {
        [Get] public string Id { get; set; }
        [Get] public string Code { get; set; }
        [Get] public string Name { get; set; }
        [Detail]public string Container {get; set;}
        [Detail]public DateTime CreateTime { get; set; }
        [Detail]public string UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [Detail]public List<ChangeUser> ChangedUsers {get; set;}
        [Detail]public List<ImageofInfo> ImageofInfos {get; set;}
        [Detail]public List<Doc> Docs {get; set;}
        public List<PropertyInfo> OnlyGetProperties(Type t)
        {
            List<PropertyInfo> OnlyGetPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach(var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if(Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if(Many is null && One is null)
                    {
                        OnlyGetPropertyInfos.Add(prop);
                    }
                }
            }
            return OnlyGetPropertyInfos;
        }
        public List<PropertyInfo> OnlyDetailProperties(Type t)
        {
            List<PropertyInfo> OnlyDetailPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach(var prop in props)
            {
                var Get = prop.GetCustomAttribute<DetailAttribute>();
                if(Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if(Many is null && One is null)
                    {
                        OnlyDetailPropertyInfos.Add(prop);
                    }
                }
            }
            return OnlyDetailPropertyInfos;
        }
        public List<PropertyInfo> GetManyProperties(Type t)
        {
            List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach(var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if(Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if(Many != null)
                    {
                        GetManyPropertyInfos.Add(prop);
                    }
                }
            }
            return GetManyPropertyInfos;
        }

        public List<PropertyInfo> GetOneProperties(Type t)
        {
            List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach(var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if(Get != null)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if(One != null)
                    {
                        GetOnePropertyInfos.Add(prop);
                    }
                }
            }
            return GetOnePropertyInfos;
        }

        public List<PropertyInfo> DetailOneProperties(Type t)
        {
            List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach(var prop in props)
            {
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if(Detail != null)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if(One != null)
                    {
                        GetOnePropertyInfos.Add(prop);
                    }
                }
            }
            return GetOnePropertyInfos;
        }

        public List<PropertyInfo> DetailManyProperties(Type t)
        {
            List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach(var prop in props)
            {
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if(Detail != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if(Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                    }
                }
            }
            return DetailManyPropertyInfos;
        }
        public Dictionary<string, List<PropertyInfo>> GetToDictionaryforClassifiedPropertyByAttribute(Type t)
        {
            List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> GetPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> GetOneInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailOneInfos = new List<PropertyInfo>();

            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Many = prop.GetCustomAttribute<ManyAttribute>();
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    if (Many != null)
                    {
                        GetManyPropertyInfos.Add(prop);
                        continue;
                    }
                    GetPropertyInfos.Add(prop);
                }
            }
            foreach (var prop in props)
            {
                var Many = prop.GetCustomAttribute<ManyAttribute>();
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if (Detail != null)
                {
                    if (Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                        continue;
                    }
                    DetailPropertyInfos.Add(prop);
                }
            }
            foreach (var prop in props)
            {
                var One = prop.GetCustomAttribute<OneAttribute>();
                var Get = prop.GetCustomAttribute<GetAttribute>();
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                
                if (One != null)
                {
                    if(Get != null)
                    {
                        GetOneInfos.Add(prop);
                        continue;
                    }
                    if(Detail != null)
                    {
                        DetailOneInfos.Add(prop);
                        continue;
                    }
                }
            }
            Dictionary<string, List<PropertyInfo>> keyValuePairs = new();
            keyValuePairs.Add(TableMetaInfo.Get, GetPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.GetMany, GetManyPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.Detail, DetailPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.DetailMany, DetailManyPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.GetOne, GetOneInfos);
            keyValuePairs.Add(TableMetaInfo.DetailOne, DetailOneInfos);
            return keyValuePairs;
        }
    }
    public class V_Center : V_Entity
    {
        [Get] public string LoginId { get; set; }
        [Get] public string Password { get; set; }
        [Get] public int FailLogin {get; set;}
        [Get] public string Address {get; set;}
        [Get] public string CountryCode {get; set;}
        [Detail] public string CardNumber {get; set;}
        [Get] public string Cvv {get; set;}
        [Get] public string CardPassword {get; set;}
        [Get] public string PhoneNumber {get; set;}
        [Get] public string FaxNumber {get; set;}
        [Get][Many] public List<Commodity> Commodities { get; set; }
        [Get][Many] public List<EStatus> EStatuses { get; set; }
        [Get][Many] public List<MStatus> MStatuses { get; set; }
        [Get][Many] public List<SStatus> SStatuses { get; set; }
        [Detail] public List<CenterMacAddress> CenterMacAddresses { get; set; }
        [Detail] public List<CenterIPAddress> CenterIPAddresses { get; set; }
        [Detail] public List<CenterRole> CenterRoles {get; set;}
    }
    public class V_Commodity : V_Entity
    {
        public string HsCode {get; set;}
        public string OpponentBusinessUserId { get; set; }
        [Detail]public string Barcode {get; set;}
        public string CenterId {get; set;}
        [One][Get]public Center Center { get; set; }
        [Many][Get]public List<EStatus> EStatuses { get; set; }
        [Many][Get]public List<MStatus> MStatuses { get; set; }
        [Many][Get]public List<SStatus> SStatuses { get; set; }
    }
    public class V_Status : V_Entity
    {
        public string CommodityId {get; set;}
        public string CenterId {get; set;}
        public string Quantity { get; set; }
        [Get][One] public Commodity Commodity { get; set; }
        [Get][One] public Center Center {get; set;}
    }
    public class V_SStatus : V_Status
    {
        [Get][Many]public List<MStatus> MStatuses { get; set; }
    }
    public class V_MStatus : V_Status
    {
        [Get][One] public SStatus SStatus { get; set; }
        [Get][Many] public List<EStatus> EStatuses { get; set; }
    }
    public class V_EStatus : V_Status
    {
        public string MStatusId {get; set;}
        [Get][One] public MStatus MStatus { get; set; }
    }
}