using System;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(FarmController), nameof(FarmController))]
    public class FarmController : Entity, IRelationable
    {
        public string ControllerCommodtiyId {get; set;}
        public string SmartFarmId {get; set;}
        public ControllerCommodity ControllerCommodity {get; set;}
        public SmartFarm SmartFarm {get; set;}
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