using BusinessData;
using BusinessData.ofCommon.ofFisheries.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManagement
{
    public interface IFisheriesManagement
    {
        Task ExcelToDb(string fileConnectionString, Dictionary<Entity, Dictionary<PropertyInfo, int>> Target);
    }
    public class FisheriesManagement : IFisheriesManagement
    {
        private readonly IEntityManager<Copartnership> _CopartnershipManager;
        private readonly ICenterManager<Fisheries> _FisheriesManager;
        private readonly ICommodityManager<FishCommodity> _FishCommodityManager;
        private Dictionary<PropertyInfo, int> CopartnershipTarget;
        private Dictionary<PropertyInfo, int> FisheiresTarget;
        private Dictionary<PropertyInfo, int> FishCommodityTarget;

        public FisheriesManagement(IEntityManager<Copartnership> copartnershipManager, ICenterManager<Fisheries> fisheriesManager, ICommodityManager<FishCommodity> commodityManager)
        {
            _CopartnershipManager = copartnershipManager;
            _FisheriesManager = fisheriesManager;
            _FishCommodityManager = commodityManager;
            CopartnershipTarget = new Dictionary<PropertyInfo, int>();
            FishCommodityTarget = new Dictionary<PropertyInfo, int>();
            FisheiresTarget = new Dictionary<PropertyInfo, int>();
        }
        
        public async Task ExcelToDb(string fileConnectionString, Dictionary<Entity, Dictionary<PropertyInfo, int>> Target)
        {
            var Keys = Target.Keys;
            List<Copartnership> copartnerships = new();
            Dictionary<string, List<Fisheries>> DicFisheries = new();
            Dictionary<string, List<FishCommodity>> FishCommodities = new();
            var CodeProp =  typeof(Entity).GetProperties().FirstOrDefault(e => e.Name.Equals("Code"));
            // Parameter Validation Check
            foreach (var key in Keys)
            {
                if(key.GetRelationCode() == nameof(Copartnership))
                {
                    CopartnershipTarget = Target[key];
                    continue;
                }
                else if(key.GetRelationCode()== nameof(Fisheries))
                {
                    FisheiresTarget = Target[key];
                    continue;
                }
                else if(key.GetRelationCode()== nameof(FishCommodity))
                {
                    FishCommodityTarget = Target[key];
                    continue;
                }
                else
                {
                    throw new ArgumentException("Not Entity Included In FisheriesManagement");
                }
            }
            if(CopartnershipTarget.Count > 0)
            {
                copartnerships = await _CopartnershipManager.ExcelToEntities(fileConnectionString, CopartnershipTarget);
            }
            if(FisheiresTarget.Count > 0)
            {
                DicFisheries = await _FisheriesManager.ExcelToCenterEntities(fileConnectionString, FisheiresTarget, CopartnershipTarget[CodeProp]);
            }
            //if (FishCommodityTarget.Count > 0)
            //{
            //    fishCommodities = await _FishCommodityManager.ExcelToEntities(fileConnectionString, FishCommodityTarget);
            //}
            if (copartnerships.Count > 0 && DicFisheries.Count > 0)
            {
                // 관계성을 맺어주도록 한다.
                foreach(var copartnership in copartnerships)
                {
                    string Code = copartnership.Code;
                    var Fisherieses = DicFisheries[Code];
                    foreach(var fisheries in Fisherieses)
                    {
                        copartnership.Fisheries.Add(fisheries);
                    }
                }
                await _CopartnershipManager.EntitiesToDb(copartnerships);
            }
        }
    }
}
