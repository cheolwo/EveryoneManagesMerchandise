using BusinessView.ofExternal.ofCommon;
using System.Reflection;
using System;
using System.Collections.Generic;
using BusinessView.ofDTO.ofCommon;

namespace BusienssLogic.ofController.ofCommon
{
   // 그냥 매핑하는 게 더 좋아보이기는 한다.
    public class EntityQuery<DTO> where DTO : EntityDTO
    {
        public DTO Dto {get; set;}
        [Query]public DateTime StartDate {get; set;}
        [Query]public DateTime EndDate {get; set;}
        public Dictionary<QueryCode, List<PropertyInfo>> GetQueryDictionary(EntityQuery<DTO> query)
        {
            return this.GetByQueryAttirute().DistributedByQueryCode();
        }
    }
    public class CenterQuery<DTO> : EntityQuery<DTO> where DTO : CenterDTO
    {
    }
    public class CommodityQuery<DTO> : EntityQuery<DTO> where DTO : CommodiyDTO
    {
    }
    public class StatusQuery<DTO> : EntityQuery<DTO>  where DTO : StatusDTO
    {
    }
   public class CenterQuery : EntityQuery
   {
       public string LoginId { get; set; }
       public string Password { get; set; }
       public int FailLogin { get; set; }
       public string Address { get; set; }
       public string CountryCode { get; set; }
       public string PhoneNumber { get; set; }
       public string FaxNumber { get; set; }
       public CenterQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary)
                       :base(dictionary)
       {

       }
   }
   public class CommodityQuery : EntityQuery
   {
       public string? HsCode {get; set;}
       public string? OpponentBusinessUserId { get; set; }
       public string? Barcode {get; set;}
       public string? CenterId {get; set;}
       public CommodityQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary)
           :base(dictionary)
       {

       }
   }
   public class StatusQuery : EntityQuery
   {
       public string CommodityId { get; set; }
       public string CenterId { get; set; }
       public string Quantity { get; set; }
       public StatusQuery(Dictionary<QueryCode, List<PropertyInfo>> dictionary)
           :base(dictionary)
       {

       }
   }
}