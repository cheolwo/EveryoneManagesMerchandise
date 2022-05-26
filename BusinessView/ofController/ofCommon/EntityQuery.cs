//using BusinessView.ofExternal.ofCommon;
//using System.Reflection;
//using BusinessView.ofDTO.ofCommon;

//namespace BusienssLogic.ofController.ofCommon
//{
//    // 그냥 매핑하는 게 더 좋아보이기는 한다.
//    public class EntityQuery
//    {
//        public string Id {get; set;}
//        public string Code {get; set;}
//        public string Name {get; set;}
//        public string Container {get; set;}
//        public DateTime CreateTime {get; set;}
//        public string UserId {get; set;}
//        public EntityQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary, EntityDTO entityDTO)
//        {
//            var keyProps = dictionary[QueryCode.Key];
//            var StringProps = dictionary[QueryCode.QueryString];
//            var IntProps = dictionary[QueryCode.QueryInt];
//            // [Query]의 의미는 Model을 더이상 안 만들겠다는 거나 다름 없어서
//            // Query를 만들 게 되면 특성을 붙이는 의미가 없어.
//        }
        
//    }
//    public class CenterQuery : EntityQuery
//    {
//        public string LoginId { get; set; }
//        public string Password { get; set; }
//        public int FailLogin { get; set; }
//        public string Address { get; set; }
//        public string CountryCode { get; set; }
//        public string PhoneNumber { get; set; }
//        public string FaxNumber { get; set; }
//        public CenterQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary)
//                        :base(dictionary)
//        {

//        }
//    }
//    public class CommodityQuery : EntityQuery
//    {
//        public string? HsCode {get; set;}
//        public string? OpponentBusinessUserId { get; set; }
//        public string? Barcode {get; set;}
//        public string? CenterId {get; set;}
//        public CommodityQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary)
//            :base(dictionary)
//        {

//        }
//    }
//    public class StatusQuery : EntityQuery
//    {
//        public string CommodityId { get; set; }
//        public string CenterId { get; set; }
//        public string Quantity { get; set; }
//        public StatusQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary)
//            :base(dictionary)
//        {

//        }
//    }
//}