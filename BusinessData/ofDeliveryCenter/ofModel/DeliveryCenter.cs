using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BusinessData.ofDeliveryCenter.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofDeliveryCenter
{
    public static class ViewNameofDeliveryCenter
    {
        public const string DeliveryCenter = "배송센터";
        public const string DCommodity = "배송상품";
        public const string SDCommodity = "입고상품";
        public const string MDCommodity = "적재상품";
        public const string EDCommodity = "출고상품";
        public const string LoadFrame = "적재대";
        public const string IncomingTag = "입고태그";
        public const string DividedTag = "분할태그";
        public const string DotBarcode ="도트태그";
    }
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection)]
    [Authorize(Roles = "Admin_DeliverCenter")]
    [Relation(typeof(DeliveryCenter), "D")]
    public class DeliveryCenter : Center, IRelationable, IRelatedCenter, IRelatedRoles
    {
        [Detail][Many(ViewNameofDeliveryCenter.DCommodity)] public List<DCommodity> DCommodities {get; set;}
        [Detail][Many(ViewNameofDeliveryCenter.EDCommodity)] public List<EDCommodity> EDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.MDCommodity)] public List<MDCommodity> MDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.SDCommodity)] public List<SDCommodity> SDCommodities { get; set; }
        public DeliveryCenter()        
        {
            SetRelation(typeof(DeliveryCenter), "D");
            DCommodities = new();
            EDCommodities = new();
            MDCommodities = new();
            SDCommodities = new();
        }

        public override bool Equals(object obj)
        {
            return obj is DeliveryCenter center &&
                   Id == center.Id &&
                   CreateTime == center.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, center.ImageofInfos) &&
                   Name == center.Name &&
                   UserId == center.UserId &&
                   Address == center.Address &&
                   EqualityComparer<List<DCommodity>>.Default.Equals(DCommodities, center.DCommodities);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string GetRelationCode()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetEntityRelation();
        }
        public override Center GetRelatedCenter()
        {
            return this;
        }

        public override Type GetRelationType()
        {
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetRelationType();
        }

        public IList<string> GetRelatedRoles()
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(AuthorizeAttribute));
            if(AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
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
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection)]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(DCommodity), "DD")]
    public class DCommodity : Commodity, IRelationable, IRelatedCenter, IRelatedRoles
    {
        public string WCommodityId {get; set;}
        public string MCommodityId {get; set;}
        public string DeliveryCenterId {get; set;}
        [Detail][One(ViewNameofDeliveryCenter.DeliveryCenter)]public DeliveryCenter DeliveryCenter {get; set;}
        [Detail][Many(ViewNameofDeliveryCenter.EDCommodity)] public List<EDCommodity> EDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.MDCommodity)] public List<MDCommodity> MDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.SDCommodity)] public List<SDCommodity> SDCommodities { get; set; }
        public DCommodity()
        {
            SetRelation(typeof(DCommodity), "DD");
            DeliveryCenter = new();
        }
        
        public override bool Equals(object obj)
        {
            return obj is DCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   Name == commodity.Name &&
                   EqualityComparer<DeliveryCenter>.Default.Equals(DeliveryCenter, commodity.DeliveryCenter);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string GetRelationCode()
        {
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetEntityRelation();
        }
        public override Center GetRelatedCenter()
        {
            return this.DeliveryCenter;
        }

        public override Type GetRelationType()
        {
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetRelationType();
        }
        public IList<string> GetRelatedRoles()
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(AuthorizeAttribute));
            if(AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
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

    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection)]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(SDCommodity), "DDS")]
    public class SDCommodity : Status, IRelationable, IRelatedCenter, IRelatedRoles
    {
        [Detail]public bool IsRightArrived {get; set;}
        [Detail]public string EWCommodityId {get; set;}
        [Detail][One(ViewNameofDeliveryCenter.DCommodity)]public DCommodity DCommodity {get; set;}
        [Detail][One(ViewNameofDeliveryCenter.DeliveryCenter)]public DeliveryCenter DeliveryCenter { get; set; }
        [Detail][Many]public List<MDCommodity> MDCommodities {get; set;}
        
        public SDCommodity()
        {
            SetRelation(typeof(SDCommodity), "DDS");
            DeliveryCenter = new();
        }

        public override bool Equals(object obj)
        {
            return obj is SDCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   IsRightArrived == commodity.IsRightArrived;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string GetRelationCode()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetEntityRelation();
        }

        public override Type GetRelationType()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetRelationType();
        }

        public override Center GetRelatedCenter()
        {
            return DeliveryCenter;
        }
        public IList<string> GetRelatedRoles()
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(AuthorizeAttribute));
            if(AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
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
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection)]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(MDCommodity), "DDM")] 
    public class MDCommodity : Status, IRelationable, IRelatedRoles
    {
        [One(ViewNameofDeliveryCenter.SDCommodity)]public SDCommodity SDCommodity {get; set;}
        [One(ViewNameofDeliveryCenter.SDCommodity)]public DCommodity DCommodity {get; set;}
        [One(ViewNameofDeliveryCenter.SDCommodity)]public DeliveryCenter DeliveryCenter { get; set; }
        [Many(ViewNameofDeliveryCenter.EDCommodity)]public List<EDCommodity> EDCommodities {get; set;}
        [Detail]public string SDCommodityId {get; set;}
        [Detail]public string DCommodityId {get; set;}
        [Detail]public string DeliveryCenterId {get; set;}
        public MDCommodity()
        {
            SetRelation(typeof(MDCommodity), "DDM");
            DeliveryCenter = new();
        }
        public string GetRelaionCode()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetEntityRelation();
        }

        public override Type GetRelationType()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetRelationType();
        }
        public override Center GetRelatedCenter()
        {
            return DeliveryCenter;
        }
        public IList<string> GetRelatedRoles()
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(AuthorizeAttribute));
            if(AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
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
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection)]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(EDCommodity), "DDE")]
    public class EDCommodity : Status, IRelationable, IRelatedRoles
    {
        [One(ViewNameofDeliveryCenter.DeliveryCenter)]public DeliveryCenter DeliveryCenter { get; set; }
        [One(ViewNameofDeliveryCenter.DCommodity)]public DCommodity DCommodity {get; set;}
        [One(ViewNameofDeliveryCenter.MDCommodity)]public MDCommodity MDCommodity {get; set;}
        [Detail]public string DeliveryCenterId {get; set;}
        [Detail]public string DCommodityId {get; set;}
        [Detail]public string MDCommodidtyId {get; set;}
        public EDCommodity()
        {
            SetRelation(typeof(EDCommodity), "DDE");
            DeliveryCenter = new();
        }

        public string GetRelaionCode()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetEntityRelation();
        }

        public override Type GetRelationType()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(RelationAttribute));

            if (relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetRelationType();
        }
        public override Center GetRelatedCenter()
        {
            return DeliveryCenter;
        }
        public IList<string> GetRelatedRoles()
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(AuthorizeAttribute));
            if(AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
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

    // public class DeliveryInfo
    // {
    //     public string Mark {get; set;} // 새벽, 일반
    //     public string OrdererId {get; set;}
    // }
}