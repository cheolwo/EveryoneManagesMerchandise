﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;

namespace BusinessData.ofHRMarket.ofModel
{
    [Relation(typeof(HRMarket), "HRMarket")] 
    public class HRMarket : Center, IRelationable, ITablable
    {
        public List<EmployeeMessage> EmployeeMessage { get; set; }
        public List<JobOffer> JobOffers { get; set; }
        public HRMarket()
        {
            EmployeeMessage = new();
            JobOffers = new();
        }
        public Type GetDbContextType()
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbContextType();
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public string GetDbConnetionString()
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbConnectionString();
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public List<PropertyInfo> OnlyGetProperties()
        {
            Type t = this.GetType();
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
        public List<PropertyInfo> OnlyDetailProperties()
        {
            Type t = this.GetType();
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
        public List<PropertyInfo> GetManyProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> GetOneProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> DetailOneProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> DetailManyProperties()
        {
            Type t = this.GetType();
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

        public override Dictionary<string, List<PropertyInfo>> GetToDictionaryfoClassifiedPropertyByAttribute()
        {
            Type t = GetType();
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

    [Relation(typeof(EmployeeMessage), "EmployeeMessage")] 
    public class EmployeeMessage : Entity, IRelationable, ITablable
    {
        public string EmployeeId { get; set; }
        public string Message { get; set; }
        public HRMarket HRMarket { get; set; }
        public EmployeeMessage()
        {
            HRMarket = new();
        }
        public Type GetDbContextType()
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbContextType();
            }
            throw new ArgumentException("Not Defined Relation");
        }

        public string GetDbConnetionString()
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbConnectionString();
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public List<PropertyInfo> OnlyGetProperties()
        {
            Type t = this.GetType();
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
        public List<PropertyInfo> OnlyDetailProperties()
        {
            Type t = this.GetType();
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
        public List<PropertyInfo> GetManyProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> GetOneProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> DetailOneProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> DetailManyProperties()
        {
            Type t = this.GetType();
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

        public override Dictionary<string, List<PropertyInfo>> GetToDictionaryfoClassifiedPropertyByAttribute()
        {
            Type t = GetType();
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

    public class JobOffer : Entity, IRelationable
    {
        public string JobType { get; set; }
        public string IncomeType { get; set; }
        public string Money { get; set; }
        public HRMarket HRMarket { get; set; }
        public JobOffer()
        {
            HRMarket = new();
        }
        public Type GetDbContextType()
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbContextType();
            }
            throw new ArgumentException("Not Defined Relation");
        }

        public string GetDbConnetionString()
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbConnectionString();
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public override string GetRelationCode()
        {
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(GetType(), typeof(RelationAttribute));
            if(relationAttribute != null)
            {
                return relationAttribute.GetEntityRelation();
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public List<PropertyInfo> OnlyGetProperties()
        {
            Type t = this.GetType();
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
        public List<PropertyInfo> OnlyDetailProperties()
        {
            Type t = this.GetType();
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
        public List<PropertyInfo> GetManyProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> GetOneProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> DetailOneProperties()
        {
            Type t = this.GetType();
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

        public List<PropertyInfo> DetailManyProperties()
        {
            Type t = this.GetType();
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
    }
    public class IncomeType
    {
        public const int Hour = 10;
        public const int Month = 11;
        public const int Year = 12;
    }
    public static class JobType
    {
        public const int Regular = 10;
        public const int NotRegular = 11;
    }
}
