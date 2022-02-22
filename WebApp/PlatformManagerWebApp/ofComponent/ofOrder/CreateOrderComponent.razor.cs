//using BusinessLogic.ofManager.ofGeneric;
//using Microsoft.AspNetCore.Components;

//namespace PlatformManager.ofComponent.ofOrder
//{
//    public partial class CreateOrderComponent : ComponentBase
//    {
//        [Inject] public BusinessUserManager BusinessUserManager {get; set;}
//        [Inject] public CenterManager<OrderCenter> OrderCenterManager {get; set;}
//        [Inject] public CommodityManager<OCommodity> OCommodityManager {get; set;}
//        [Inject] public CenterManager<Warehouse> CenterMangaer {get; set;}
//        [Inject] public NavigationMangaer NavigationMangaer {get; set;}
//        public List<OCommodity> OCommodities {get; set;}
//        public string BusinessUserName {get; set;}
//        public bool IsSelectedCommodity {get; set;}
//        public decimal Quantity {get; set;}
//        public decimal Price {get; set;}
//        public string WarehouseName {get; set;}
//        public OCommodity OCommodity {get; set;}
//        protected override async Task OnInitializedAsync()
//        {
//            OCommodities = new();
//        }
//        public async Task SearchBusinessUser(string BusinessNumber)
//        {
//            if(BusinessNumber != null)
//            {
//                var BusinessUser = await BusinessUserManager.GetByBusinessNumberAsync(BusinessNumber);
//                if(BusinessUser != null)
//                {
//                    OCommodities = await OCommodityManager.GetToListByBusinessUserIdAsync(BusinessUser.Id);
//                } 
//            }
//        }
//        public void SelectOCommodity(string OCommodityId)
//        {
//            OCommodity = new();
//            OCommodity = OCommodities.Find(e=>e.Equals(OCommodityId));
//            IsSelectedCommodity = true;
//        }
//        public void Cancel()
//        {

//        }
        
//    }
//}