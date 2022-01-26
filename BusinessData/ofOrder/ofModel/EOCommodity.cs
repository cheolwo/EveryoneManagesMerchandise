using System;
using System.Collections.Generic;
using System.Reflection;
using BusinessData.ofOrder.ofDbContext;

namespace BusinessData.ofOrder.ofModel
{
	[Relation(typeof(EOCommodity), nameof(EOCommodity))]
    [DataContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    public class EOCommodity : EStatus, IRelationable
    {
        [Get]public int OutgoingQuantity {get; set; } // 출고수량
        public MOCommodity MOCommodity { get; set; }
        public OCommodity OCommodity {get; set;}
        public OrderCenter OrderCenter {get; set;}
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
}
