using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform
{
    [AutoMap(typeof(EGOC))]
    [HttpDTOService(typeof(PlatformEGOCService))]
    public class PlatformEGOC : EGOCDTO
    {

    }
}
