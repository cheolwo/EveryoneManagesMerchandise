using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using BusinessData.ofCommon.ofInterface;
using System.Reflection;

namespace BusinessData
{
    public static class DbConnectionString
    {
        public const string WarehouseDbConnection = "Server=(localdb)\\mssqllocaldb;Database=WarehouseDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string HRDbConnection = "Server=(localdb)\\mssqllocaldb;Database=HRDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string DeliveryDbConnection = "Server=(localdb)\\mssqllocaldb;Database=DeliveryDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string MarketDbConnection = "Server=(localdb)\\mssqllocaldb;Database=MarketDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string JournalDbConnection = "Server=(localdb)\\mssqllocaldb;Database=JournalDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string OrderDbConnection = "Server=(localdb)\\mssqllocaldb;Database=OrderDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string GroupOrderDbConnection = "Server=(localdb)\\mssqllocaldb;Database=GroupOrderDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string ProductDbConnection = "Server=(localdb)\\mssqllocaldb;Database=ProductDbDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string TradeDbConnection = "Server=(localdb)\\mssqllocaldb;Database=TradeDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string HsDbConnection = "Server=(localdb)\\mssqllocaldb;Database=HsDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string KamisDbConnection = "Server=(localdb)\\mssqllocaldb;Database=KamisDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public const string KAptDbConnection = "Server=(localdb)\\mssqllocaldb;Database=KAptInfoDb;Trusted_Connection=True;MultipleActiveResultSets=true";
    }
    public class OneAttribute : Attribute
    {
        public string Name {get; set;}
        public OneAttribute(string name)
        {
            Name = name;
        }
        public OneAttribute()
        {
            Name = "";
        }
    }
    public class ManyAttribute : Attribute
    {
        public string Name {get; set;}
        public ManyAttribute(string name)
        {
            Name = name;
        }
        public ManyAttribute()
        {
            Name = "";
        }
    }
    
    public class RescopeAttribute : Attribute
    {
        private string EntityCode {get; set;}
        private Type T {get; set;}
        public void SetEntityCode(string Code)
        {
            EntityCode = Code;
        }
        public void SetEntityType(Type t)
        {
            T = t;
        }
        public string GetEntityCode()
        {
            return EntityCode;
        }
        public Type GetEntityType()
        {
            return T;
        }
    }
    public class OrdererView
    {
        public List<string> Views { get; set; }
        public OrdererView(List<string> NameofViews)
        {
            foreach(var item in NameofViews)
            {
                Views.Add(item);    
            }
        }
    }
    [Rescope]
    public abstract class Entity : IComparable<Entity>, IComparable, IEquatable<Entity>, IComparer, ITablable
    {
        [Key] [Get] public string Id { get; set; }
        [Get("OrdererApp = {SPCommodityInOrdererView}")] public string Name { get; set; }
        [Detail]public string Container {get; set;}
        [Detail]public DateTime CreateTime { get; set; }
        [Detail]public string UserId {get; set;}
        [Detail]public List<ChangeUser> ChangedUsers {get; set;}
        [Detail]public List<ImageofInfo> ImageofInfos {get; set;}
        [Detail]public List<Doc> Docs {get; set;}
        public Entity()
        {
            ChangedUsers = new();
            ImageofInfos = new();
            Docs = new();
        }
        public void SetRelation(Type type, string Code)
        {
            RescopeAttribute rescopeAttribute = (RescopeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(Entity));
            if(rescopeAttribute != null)
            {
                rescopeAttribute.SetEntityCode(Code);
                rescopeAttribute.SetEntityType(type);
            }
            throw new ArgumentException("Not Defined Rescope");
        }
        public override bool Equals(object obj)
        {
            return obj is Entity entity &&
                   Id == entity.Id &&
                   CreateTime == entity.CreateTime;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CreateTime, ChangedUsers);
        }
        public virtual int GetHashCodeById()
        {
            return HashCode.Combine(Id);
        }
        public virtual string GetRelationCode()
        {
            RescopeAttribute rescopeAttribute = (RescopeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(Entity));
            if(rescopeAttribute != null)
            {
                rescopeAttribute.GetEntityCode();
            }
            throw new ArgumentException("Not Defined Relation Code");
        }
        public virtual Type GetRelationType()
        {
            RescopeAttribute rescopeAttribute = (RescopeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(Entity));
            if(rescopeAttribute != null)
            {
                rescopeAttribute.GetEntityType();
            }
            throw new ArgumentException("Not Defined Relation Type");
        }

        public int CompareTo(Entity other)
        {
            if (other == null) return 1;
            else
            {
                return CreateTime.CompareTo(other.CreateTime);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            else
            {
                Entity entity = obj as Entity;
                if(obj != null)
                {
                    return entity.CompareTo(entity);
                }
                else
                {
                    throw new ArgumentNullException("Obj Is Not Entity, Plase Input Entity");
                }
            }
        }

        public bool Equals(Entity other)
        {
            if(other == null) { throw new ArgumentNullException("Other Is Null"); }
            else
            {
                return this.Id.Equals(other.Id);
            }
        }

        public int Compare(object x, object y)
        {
            if (x == null || y == null) { throw new ArgumentNullException("Object Is Null"); }
            else
            {
                if (x is Entity Entityx)
                {
                    if (y is Entity Entityy)
                    {
                        if (Entityx.CreateTime.Ticks == Entityy.CreateTime.Ticks) { return 0; }
                        else if (Entityx.CreateTime.Ticks > Entityy.CreateTime.Ticks)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else { throw new ArgumentException("y is not Entity"); }
                }
                else { throw new ArgumentException("x is not Entity"); }
            }
        }

        public virtual Dictionary<string, List<PropertyInfo>> GetToDictionaryforClassifiedPropertyByAttribute()
        {
            throw new NotImplementedException();
        }
    }
    
    [NotMapped]
    public class CenterRole : Entity, IEqualityComparer<CenterRole>
    {
        public string Role {get; set;}
        public string Content {get; set;}

        public bool Equals(CenterRole x, CenterRole y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Role == y.Role && x.Content == y.Content)
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] CenterRole obj)
        {
            return HashCode.Combine(obj.Role, obj.Content);
        }
    }
    public static class NameofStatus
    {
        public const string SW = "SW";
        public const string MW = "MW";    
        public const string EW = "EW";
        public const string SP = "SP";
        public const string MP = "MP";
        public const string EP = "EP";
        public const string SD = "SD";
        public const string MD = "MD";
        public const string ED = "ED";
    }
    public class Status : Entity, IRelatedCenter
    {
        public string CommodityId {get; set;}
        public string CenterId {get; set;}
        [Get][One] public Commodity Commodity { get; set; }
        [Get][One] public Center Center {get; set;}

        public virtual Center GetRelatedCenter()
        {
            return Center;
        }
    }
    public class SStatus : Status
    {
        [Get][Many]public List<MStatus> MStatuses { get; set; }
    }
    public class MStatus : Status
    {
        public Commodity Commodity {get;set;}
        [Get][One] public SStatus SStatus { get; set; }
        [Get][Many] public List<EStatus> EStatuses { get; set; }
    }
    public class EStatus : Status
    {
        public string MStatusId {get; set;}
        [Get][One] public MStatus MStatus { get; set; }
    }
    public class RelationAttribute : Attribute
    {
        private string EntityRelation { get; set; }
        private Type t {get; set;}
        
        public RelationAttribute(Type RelationType, string entityRelation)
        {
           EntityRelation = entityRelation;
        }
        public RelationAttribute()
        {
            EntityRelation = "Not Defined";
        }
        public void SetRelation(Type type, string entityRelation)
        {
            t = type;
            EntityRelation = entityRelation;
        }
        public Type GetRelationType()
        {
            return t;
        }
        public string GetEntityRelation()
        {
            return EntityRelation;
        }
    }
    public class Origin : Attribute
    {
        private Type T {get; set;}
        public Origin(Type t)
        {
            this.T = t;
        }
        private Type GetOrigin()
        {
            return T;
        }
    }

    // public class Journal : Attribute
    // {
    //     private string Debit {get; set;}
    //     private string Credit {get; set;}

    //     public Journal(string Debit, string Credit)
    //     {
    //         this.Debit = Debit;
    //         this.Credit = Credit;
    //     }
    //     public Journal()
    //     {
            
    //     }
    //     public string GetDebit()
    //     {
    //         return this.Debit;
    //     }
    //     public string GetCredit()
    //     {
    //         return this.Credit;
    //     }
    //     public void SetDebit(string Debit)
    //     {
    //         this.Debit = Debit;
    //     }
    //     public void SetCredit(string Credit)
    //     {
    //         this.Credit = Credit;
    //     }
    // }
}
