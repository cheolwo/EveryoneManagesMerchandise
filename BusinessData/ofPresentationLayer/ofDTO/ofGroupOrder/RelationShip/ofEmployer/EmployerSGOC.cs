using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer
{
    [AutoMap(typeof(SGOC))]
    [HttpDTOService(typeof(EmployerSGOCService))]
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerSGOC : SGOCDTO
    {

    }
}
