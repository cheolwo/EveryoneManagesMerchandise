using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee
{
    [AutoMap(typeof(GOCC))]
    [HttpDTOService(typeof(EmployeeGOCCService))]
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeGOCC : GOCCDTO
    {

    }
}
