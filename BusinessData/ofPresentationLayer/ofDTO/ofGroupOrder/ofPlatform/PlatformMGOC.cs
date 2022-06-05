using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform
{
    [AutoMap(typeof(MGOC))]
    [HttpDTOService(typeof(PlatformMGOCService))]
    public class PlatformMGOC : MGOCDTO
    {

    }
}
