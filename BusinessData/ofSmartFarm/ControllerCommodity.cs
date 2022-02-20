using System;
using System.Collections.Generic;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(ControllerCommodity), nameof(ControllerCommodity))]
    public class ControllerCommodity : Entity, IRelationable
    {
        public string FarmCommodtiyId {get; set;}
        public string ControllerCommodityId {get; set;}
        public FarmCommodtiy FarmCommodtiy {get; set;}
        public FarmController FarmController {get; set;}
        public List<SControllerValue> SControllerValues {get; set;}
        public List<MControllerValue> MControllerValues {get; set;}
        public List<EControllerValue> EControllerValues {get; set;}
        public override string GetRelationCode()
        {
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(GetType(), typeof(RelationAttribute));
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
    }
}