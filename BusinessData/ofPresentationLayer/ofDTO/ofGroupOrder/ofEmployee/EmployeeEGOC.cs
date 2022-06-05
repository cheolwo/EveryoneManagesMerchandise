using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee
{
    [AutoMap(typeof(EGOC))]
    [HttpDTOService(typeof(EmployeeEGOCService))]
    public class EmployeeEGOC : EGOCDTO
    {
    }
}
