using BusienssData.ofPresentationLayer.ofController.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder
{
    [HttpDTOService(typeof(GOCDTOService))]
    public class GOCDTO : CenterDTO
    {
        [Query(QueryCode.String)]public string? OrderCenters { get; set; }
        [Query(QueryCode.String)]public string? WarehouseId { get; set; }
    }
    [HttpDTOService(typeof(GOCCDTOService))]
    public class GOCCDTO : CommodityDTO
    {

    }
    [HttpDTOService(typeof(SGOCDTOService))]
    public class SGOCDTO : SStatusDTO
    {

    }
    [HttpDTOService(typeof(MGOCDTOService))]
    public class MGOCDTO : MStatusDTO
    {

    }
    [HttpDTOService(typeof(EGOCDTOService))]
    public class EGOCDTO : EStatusDTO
    {

    }
}