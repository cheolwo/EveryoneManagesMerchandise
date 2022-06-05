using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer
{
    [AutoMap(typeof(GOCC))]
    [HttpDTOService(typeof(EmployerGOCCService))]
    public class EmployerGOCC : GOCCDTO
    {

    }
}
