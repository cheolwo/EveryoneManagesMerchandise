using System;
using System.Collections.Generic;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(FarmCommodtiy), nameof(FarmCommodtiy))]
    public class FarmCommodtiy : Commodity, IRelationable
    {
        public string PCommodityId {get; set;}
        public SmartFarm SmartFarm {get; set;}
        public ControllerCommodity ControllerCommodity {get; set;}
        public List<SFarmCommodity> SFarmCommodityes {get; set;}
        public List<MFarmCommodity> MFarmCommodityes {get; set;}
        public List<EFarmCommodity> EFarmCommodityes {get; set;}
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