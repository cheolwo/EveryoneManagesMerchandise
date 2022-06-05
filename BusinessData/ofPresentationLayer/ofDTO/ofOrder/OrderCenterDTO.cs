using BusienssData.ofPresentationLayer.ofController.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System.Collections.Generic;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder
{
    [HttpDTOService(typeof(EOCommodityDTOService))]
    public class EOCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.Int)][View(ViewMode.Get)]public string? Price { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? QualityTerms { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? Incorterms { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
    }
    [HttpDTOService(typeof(MOCommodityDTOService))]
    public class MOCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))] public string? OrderCenter { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(SOCommodity))] public string? SOCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EOCommodity>))]public string? EOCommodities { get; set; }
    }
    [HttpDTOService(typeof(SOCommodityDTOService))]
    public class SOCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? Price { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? QualityTerms { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? Incorterms { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
    }
    [HttpDTOService(typeof(OCommodityDTOService))]
    public class OCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? OrderType { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string? SOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string? EOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))] public string OrderCenter { get; set; }
    }
    [HttpDTOService(typeof(OrderCenterDTOService))]
    public class OrderCenterDTO : CenterDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.OCommodity, typeof(List<OCommodity>))] public string? OCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string? SOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string? EOCommodities { get; set; }
    }
}