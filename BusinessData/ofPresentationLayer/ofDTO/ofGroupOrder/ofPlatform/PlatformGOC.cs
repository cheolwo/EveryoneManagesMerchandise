using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform
{
    [AutoMap(typeof(GOC))]
    [HttpDTOService(typeof(PlatformGOCService))]
    public class PlatformGOC : GOCDTO
    {
    }
}
