using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer
{
    [AutoMap(typeof(SGOC))]
    [HttpDTOService(typeof(EmployerSGOCService))]
    public class EmployerSGOC : SGOCDTO
    {

    }
}
