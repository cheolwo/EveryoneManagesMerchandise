using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform
{
    [AutoMap(typeof(SGOC))]
    [HttpDTOService(typeof(PlatformSGOCService))]
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformSGOC : SGOCDTO
    {

    }
}
