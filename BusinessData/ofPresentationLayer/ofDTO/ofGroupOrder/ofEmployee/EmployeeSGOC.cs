using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee
{
    [AutoMap(typeof(SGOC))]
    [HttpDTOService(typeof(EmployeeSGOCService))]
    public class EmployeeSGOC : SGOCDTO
    {

    }
}
