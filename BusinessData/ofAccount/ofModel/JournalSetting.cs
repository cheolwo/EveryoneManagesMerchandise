using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

// 사용자 등록을 하면
// Seed가 주입되도록 해서 기능을 이용할 수 있도록 만들자.
// 역할에 등록이 될 때마다 사용자 등록이 가능해지도록 만드는 게 바람직하겠다.

namespace BusinessData.ofAccount.ofModel
{
    [DataContext(typeof(BusinessUserDbContext), DbConnectionString.BusinessUserDbConnection)]
    [Relation(typeof(JournalSetting), nameof(JournalSetting))]
    public class JournalSetting : Entity, IRelationable
    {
        public string Purpose {get; set;}
        public string RelationCode {get; set;}
        public List<string> Debits { get; set; }
        public List<string> Credits { get; set; }
        public BusinessUser BusinessUser { get; set; }
        public override string GetRelationCode()
        {
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            if (relationAttribute != null)
            {
                return relationAttribute.GetEntityRelation();
            }
            throw new ArgumentException("Not Defined Relation");
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

        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
        }
        public List<PropertyInfo> OnlyGetProperties()
        {
            Type t = this.GetType();
            List<PropertyInfo> OnlyGetPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (Many is null && One is null)
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
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<DetailAttribute>();
                if (Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (Many is null && One is null)
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
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if (Many != null)
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
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (One != null)
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
            foreach (var prop in props)
            {
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if (Detail != null)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (One != null)
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
            foreach (var prop in props)
            {
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if (Detail != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if (Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                    }
                }
            }
            return DetailManyPropertyInfos;
        }

        public override Dictionary<string, List<PropertyInfo>> GetToDictionaryforClassifiedPropertyByAttribute()
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
                    if (Get != null)
                    {
                        GetOneInfos.Add(prop);
                        continue;
                    }
                    if (Detail != null)
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
    // public class PopBillInfo
    // {
    //     public string PopBillId { get; set; }
    //     public string Password { get; set; }
    //     public string LinkId { get; set; }
    //     public string SecreatKey { get; set; }
    // }
}
