using BusinessData;
using BusinessData.ofCommon;
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
        Task ExcelToDb(string fileConnectionString, Dictionary<Type, Dictionary<PropertyInfo, int>> Target);
    }
    public class FisheriesManagement : IFisheriesManagement
    {
        private readonly IEntityManager<Copartnership> _CopartnershipManager;
        private readonly ICenterManager<Fisheries> _FisheriesManager;
        private readonly ICommodityManager<FishCommodity> _FishCommodityManager;
        private Dictionary<PropertyInfo, int> CopartnershipTarget;
        private Dictionary<PropertyInfo, int> FisheiresTarget;
        private Dictionary<PropertyInfo, int> FishCommodityTarget;

        public FisheriesManagement(FisheriesDbContext DbContext, IEntityManager<Copartnership> copartnershipManager, 
            ICenterManager<Fisheries> fisheriesManager, ICommodityManager<FishCommodity> commodityManager)
        {
            _CopartnershipManager = copartnershipManager;
            _FisheriesManager = fisheriesManager;
            _FishCommodityManager = commodityManager;
            CopartnershipTarget = new Dictionary<PropertyInfo, int>();
            FishCommodityTarget = new Dictionary<PropertyInfo, int>();
            FisheiresTarget = new Dictionary<PropertyInfo, int>();
        }
        
        public async Task ExcelToDb(string fileConnectionString, Dictionary<Type, Dictionary<PropertyInfo, int>> Target)
        {
            var Keys = Target.Keys;
            List<Copartnership> copartnerships = new();
            Dictionary<string, List<Fisheries>> DicFisheries = new();
            Dictionary<string, List<FishCommodity>> DicFishCommodities = new();
            var CodeProp =  typeof(Entity).GetProperties().FirstOrDefault(e => e.Name.Equals("Code"));
            // Parameter Validation Check
            foreach (var key in Keys)
            {
                if(key.Equals(typeof(Copartnership)))
                {
                    CopartnershipTarget = Target[key];
                    continue;
                }
                else if(key.Equals(typeof(Fisheries)))
                {
                    FisheiresTarget = Target[key];
                    continue;
                }
                else if(key.Equals(typeof(FishCommodity)))
                {
                    FishCommodityTarget = Target[key];
                    continue;
                }
                else
                {
                    throw new ArgumentException("Not Entity Included In FisheriesManagement");
                }
            }
            if(CopartnershipTarget.Count > 0) {
               copartnerships = await _CopartnershipManager.ExcelToEntities(fileConnectionString, CopartnershipTarget);
            }
            if(FisheiresTarget.Count > 0 ){
                DicFisheries = await _FisheriesManager.ExcelToCenterEntities(fileConnectionString, FisheiresTarget, 1);
            }
            if(FishCommodityTarget.Count > 0){
                DicFishCommodities = await _FishCommodityManager.ExcelToCommodityEntities(fileConnectionString, FishCommodityTarget, 2);
            }
            if (copartnerships.Count > 0 && DicFisheries.Count > 0 && DicFishCommodities.Count > 0)
            {
                await _CopartnershipManager.EntitiesToDb(copartnerships);
                foreach (var copartnership in copartnerships)
                {
                    Copartnership partner = await _CopartnershipManager.GetByIdAsync(copartnership.Id);
                    if(partner.FisheriesId == null) { partner.FisheriesId = new(); }
                    string Code = partner.Code;
                    var Fisherieses = DicFisheries[Code];
                    foreach (var fisheries in Fisherieses)
                    {
                        partner.FisheriesId.Add(fisheries.Id);
                        fisheries.UserId = partner.Id;
                        await _FisheriesManager.CreateAsync(fisheries);
                    }
                    await _CopartnershipManager.UpdateAsync(partner);
                }              
                var keys = DicFishCommodities.Keys;
                List<Fisheries> BufFisheries = new();
                foreach (var key in keys)
                {
                    Fisheries fisheries = await _FisheriesManager.GetByCodeAsync(key);
                    if (fisheries.FishCommodities == null) { fisheries.FishCommodities = new(); }
                    var Commodities = DicFishCommodities[key];
                    foreach (var fish in Commodities)
                    {
                        fish.CenterId = fisheries.Id;
                        fisheries.FishCommodities.Add(fish);
                    }
                    BufFisheries.Add(fisheries);
                }
                await _FisheriesManager.EntitiesToDbAttach(BufFisheries);
                BufFisheries.Clear();
            }
        }
    }
}
