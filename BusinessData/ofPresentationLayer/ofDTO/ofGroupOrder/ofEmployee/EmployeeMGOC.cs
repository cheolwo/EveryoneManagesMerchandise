using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee
{
    [AutoMap(typeof(MGOC))]
    [HttpDTOService(typeof(EmployeeMGOCService))]
    public class EmployeeMGOC : MGOCDTO
    {

    }
}
