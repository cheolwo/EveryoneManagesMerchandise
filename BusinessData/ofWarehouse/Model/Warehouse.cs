using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;
using BusinessData.ofWarehouse.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofWarehouse.Model
{
    public enum CenterOwnerType {Owner, Lessor}
    public interface IJounral
    {
        string GetJounral(string CenterOwnerType);
    }

    public class JounrnalAttribute : Attribute
    {
        public Type type {get; set;}
        public JounrnalAttribute(Type type)
        {
            this.type = type;
        }
    }

    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Authorize(Roles ="Admin_Warehouse")]
    [Relation(typeof(Warehouse), "W")] 
    public class Warehouse : Center, IRelationable, IRelatedCenter, IRelatedRoles, IBarcodable, ITablable
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity)] public List<WCommodity> WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public List<EWCommodity> EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public List<MWCommodity> MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public List<SWCommodity> SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame)] public List<LoadFrame> LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode)] public List<DotBarcode> DotBarcodes {get; set;}
        [Detail][Many(ViewNameofWarehouse.WorkingDesk)] public List<WorkingDesk> WorkingDesks {get; set;}
        [Detail][Many(ViewNameofWarehouse.DividedTag)] public List<DividedTag> DividedTags {get; set;}
        [Detail][Many(ViewNameofWarehouse.IncomingTag)] public List<IncomingTag> IncomingTags {get; set;}

        public Warehouse()
        {    
            WCommodities = new();
            EWCommodities = new();
            MWCommodities = new();
            SWCommodities = new();
            LoadFrames = new();
            DotBarcodes = new();
            WorkingDesks = new();
            DividedTags = new();
            IncomingTags = new();
        }
        
        public override Center GetRelatedCenter()
        {
            return this;
        }
        public IList<string> GetRelatedRoles()
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(GetType(), typeof(AuthorizeAttribute));
            if(AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
        }

        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
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

    // 버퍼처럼 쓰이는 곳, 승낙되면 삭제됨
    public class WaitAccepting
    {
        [Key] public int Id { get; set; }
        public bool IsAccecpt { get; set; }
        public string Message { get; set; }
        [Required] public string UserId { get; set; }    // 와부 거래입고 Id
        [Required] public WCommodity WCommodity { get; set; } // Json 형태로 저장
        [Required] public Warehouse Warehouse { get; set; }
    }

    // UserInfo 같은 게 있었으면 좋겠네. 거래가 이루어질 때 승낙자가 볼 수 있도록

    public enum Country { Korea = 1, China = 2, Japan = 3, Russia = 4, America = 5 }
}
