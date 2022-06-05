using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(MMCommodity))]
    [HttpDTOService(typeof(EmployerMMCommodityService))]
    public class EmployerMMCommodity : MMCommodityDTO
    {
       
    }
}
