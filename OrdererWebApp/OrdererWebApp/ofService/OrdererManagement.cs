using System.Reflection;
using BusinessData.ofCommon.ofViewModel.ofOrderer;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessData.ofTrade.ofRepository;

namespace OrdererWebApp.ofService
{
    public delegate Task<List<ViewofSPCommodity>> CallBackGetToListofViewofSPCommodity(InputViewofSPCommodity inputViewofSPCommodity); 
    public class OrdererServices
    {
        private readonly ProductCenterRepository _productCenterRepository;
        private readonly PCommodityRepository _pCommodityRepository;
        private readonly SPCommodityRepository _sPCommodityRepository;
        private readonly TradeCenterRepository _tradeCenterRepository;
        private readonly TCommodityRepository _tCommodityRepository;
        private readonly STCommodityRepository _sTCommodityRepository;
        private readonly MTCommodityRepository _mTCommodityRepository;
        private readonly ETCommodityRepository _eCommodityRepository;
        private Dictionary<int, CallBackGetToListofViewofSPCommodity> WeightGetToListofViewofSPCommodity = new();
        
        public OrdererServices(ProductCenterRepository productCenterRepository, PCommodityRepository pCommodityRepository,
            SPCommodityRepository sPCommodityRepository, TradeCenterRepository tradeCenterRepository, TCommodityRepository tCommodityRepository,
            STCommodityRepository sTCommodityRepository, MTCommodityRepository mTCommodityRepository, ETCommodityRepository eTCommodityRepository)
        {
            _productCenterRepository = productCenterRepository; 
            _pCommodityRepository = pCommodityRepository;
            _sPCommodityRepository = sPCommodityRepository;
            _tradeCenterRepository = tradeCenterRepository;  
            _tCommodityRepository= tCommodityRepository;
            _sTCommodityRepository = sTCommodityRepository;
            _mTCommodityRepository = mTCommodityRepository;
            _eCommodityRepository = eTCommodityRepository;
            WeightGetToListofViewofSPCommodity.Add(0, GetToListByNotClause);
            WeightGetToListofViewofSPCommodity.Add(1, GetToListByNameofCenter);
            WeightGetToListofViewofSPCommodity.Add(2, GetToListByNameofProducter);
            WeightGetToListofViewofSPCommodity.Add(3, GetToListByNameofPCommodity);
            WeightGetToListofViewofSPCommodity.Add(4, GetToListByHsCode);
            WeightGetToListofViewofSPCommodity.Add(10, GetToListByCountryCode);
            WeightGetToListofViewofSPCommodity.Add(11, GetToListByCountryCodeAndNameofCenter);
            WeightGetToListofViewofSPCommodity.Add(12, GetToListByCountryCodeAndNameofProducter);
            WeightGetToListofViewofSPCommodity.Add(13, GetToListByCountryCodeAndNameofPCommodity);
            WeightGetToListofViewofSPCommodity.Add(14, GetToListByCountryCodeAndHsCode);    
        }
        private List<ViewofSPCommodity> SPCommodityToViewofSPCommodity(List<SPCommodity> sPCommodities)
        {
            List<ViewofSPCommodity> viewofSPCommodities = new();
            var ViewModelPropInfos = typeof(ViewofSPCommodity).GetProperties();
            var ModelPropInfos = typeof(SPCommodity).GetProperties();

            List<PropertyInfo> CoinsignPropInfo = new();

            // ViewModel prop와 일치하는 Model의 prop만 도출.
            foreach(var ViewProp in ViewModelPropInfos)
            {
                foreach(var ModelProp in ModelPropInfos)
                {
                    if(ModelProp.Name.Equals(ViewProp))
                    {
                        CoinsignPropInfo.Add(ModelProp);
                        break;
                    }
                }
            }       
            // SPCommodities 수만큼 반복
            foreach(var sPCommodity in sPCommodities)
            {
                ViewofSPCommodity newViewofSPCommodity = new();
                //ViewModel prop와 일치하는 Model의 prop 를 이용해서 ViewModel에 Model 값을 병기.
                foreach(var prop in CoinsignPropInfo)
                {
                    var propValue = prop.GetValue(sPCommodity);
                    var ViewProps = typeof(ViewofSPCommodity).GetProperties();
                    foreach(var viewprop in ViewProps)
                    {
                        if(viewprop.Name.Equals(prop.Name)) // 같은 propName을 가지는 속성에 값을 입력 Model -> ViewModel
                        {
                            viewprop.SetValue(newViewofSPCommodity, propValue);
                            break;
                        }                      
                    }
                }
                viewofSPCommodities.Add(newViewofSPCommodity);
            }
            return viewofSPCommodities;
        }
        //0
        private async Task<List<ViewofSPCommodity>> GetToListByNotClause(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(sPCommodities);
            return viewofSPCommodities;
        }
        // 1
        private async Task<List<ViewofSPCommodity>> GetToListByNameofCenter(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducterAndProductCenter();
            List<SPCommodity> ClassifiedSPCommodity = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.ProductCenter.Name.Equals(inputViewofSPCommodity.NameofCenter))
                {
                    ClassifiedSPCommodity.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodity);
            return viewofSPCommodities;
        }
        // 2
        private async Task<List<ViewofSPCommodity>> GetToListByNameofProducter(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodity = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.Producter.Name.Equals(inputViewofSPCommodity.NameofProducter))
                {
                    ClassifiedSPCommodity.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodity);
            return viewofSPCommodities;
        }
        // 3
        private async Task<List<ViewofSPCommodity>> GetToListByNameofPCommodity(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodity = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.PCommodity.Name.Equals(inputViewofSPCommodity.NameofPCommodity))
                {
                    ClassifiedSPCommodity.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodity);
            return viewofSPCommodities;
        }
        // 4
        private async Task<List<ViewofSPCommodity>> GetToListByHsCode(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodity = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.PCommodity.HsCode.Equals(inputViewofSPCommodity.HsCode))
                {
                    ClassifiedSPCommodity.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodity);
            return viewofSPCommodities;
        }
        // 10
        private async Task<List<ViewofSPCommodity>> GetToListByCountryCode(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodity = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.Producter.CountryCode.Equals(inputViewofSPCommodity.CoutryCode))
                {
                    ClassifiedSPCommodity.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodity);
            return viewofSPCommodities;
        }
        // 10 + 1
        private async Task<List<ViewofSPCommodity>> GetToListByCountryCodeAndNameofCenter(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducterAndProductCenter();
            List<SPCommodity> ClassifiedSPCommodityByCountryCode = new();
            List<SPCommodity> ClassifiedSPCommodityByNameofProductCenter = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.ProductCenter.CountryCode.Equals(inputViewofSPCommodity.NameofCenter))
                {
                    ClassifiedSPCommodityByCountryCode.Add(sPCommodity);
                }
            }
            foreach(var sPCommodity in ClassifiedSPCommodityByCountryCode)
            {
                if(sPCommodity.ProductCenter.Name.Equals(inputViewofSPCommodity.NameofCenter))
                {
                    ClassifiedSPCommodityByNameofProductCenter.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodityByNameofProductCenter);
            return viewofSPCommodities;
        }
        // 10 + 2
        private async Task<List<ViewofSPCommodity>> GetToListByCountryCodeAndNameofProducter(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodityByCountryCode = new();
            List<SPCommodity> ClassifiedSPCommodityByNameofProducter = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.Producter.Name.Equals(inputViewofSPCommodity.NameofCenter))
                {
                    ClassifiedSPCommodityByCountryCode.Add(sPCommodity);
                }
            }
            foreach(var sPCommodity in ClassifiedSPCommodityByCountryCode)
            {
                if(sPCommodity.Producter.Name.Equals(inputViewofSPCommodity.NameofProducter))
                {
                    ClassifiedSPCommodityByNameofProducter.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodityByNameofProducter);
            return viewofSPCommodities;
        }
        // 10 + 3
        private async Task<List<ViewofSPCommodity>> GetToListByCountryCodeAndNameofPCommodity(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodityByCountryCode = new();
            List<SPCommodity> ClassifiedSPCommodityByNameofPCommodity = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.PCommodity.Name.Equals(inputViewofSPCommodity.NameofPCommodity))
                {
                    ClassifiedSPCommodityByCountryCode.Add(sPCommodity);
                }
            }
            foreach(var sPCommodity in ClassifiedSPCommodityByCountryCode)
            {
                if(sPCommodity.PCommodity.Name.Equals(inputViewofSPCommodity.NameofPCommodity))
                {
                    ClassifiedSPCommodityByNameofPCommodity.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodityByNameofPCommodity);
            return viewofSPCommodities;
        }
        // 10 + 4
        private async Task<List<ViewofSPCommodity>> GetToListByCountryCodeAndHsCode(InputViewofSPCommodity inputViewofSPCommodity)
        {
            List<SPCommodity> sPCommodities = await _sPCommodityRepository.GetToListByTradableWithPCommodityAndProducter();
            List<SPCommodity> ClassifiedSPCommodityByCountryCode = new();
            List<SPCommodity> ClassifiedSPCommodityByHsCode = new();
            foreach(var sPCommodity in sPCommodities)
            {
                if(sPCommodity.PCommodity.HsCode.Equals(inputViewofSPCommodity.HsCode))
                {
                    ClassifiedSPCommodityByCountryCode.Add(sPCommodity);
                }
            }
            foreach(var sPCommodity in ClassifiedSPCommodityByCountryCode)
            {
                if(sPCommodity.PCommodity.HsCode.Equals(inputViewofSPCommodity.HsCode))
                {
                    ClassifiedSPCommodityByHsCode.Add(sPCommodity);
                }
            }
            List<ViewofSPCommodity> viewofSPCommodities = SPCommodityToViewofSPCommodity(ClassifiedSPCommodityByHsCode);
            return viewofSPCommodities;
        }

        public async Task<List<ViewofSPCommodity>> GetToListofViewofSPCommodity(InputViewofSPCommodity inputViewofSPCommodity)
        {
            // 검색 값에 대해 가중치를 부여하는 단계
            int Weight = 0;
            if(inputViewofSPCommodity.CoutryCode != null) {Weight += 10;}
            if(inputViewofSPCommodity.NameofCenter != null) {Weight += 1;}
            if(inputViewofSPCommodity.NameofProducter != null) {Weight += 2;}
            if(inputViewofSPCommodity.NameofPCommodity != null) {Weight += 3;}
            if(inputViewofSPCommodity.HsCode != null) {Weight += 4;}
             // 가중치 값에 따라 검색기능이 수행되며 데이터가 로드되고 ViewModel로 변환된다.
            return await WeightGetToListofViewofSPCommodity[Weight](inputViewofSPCommodity);
        }
    }
}