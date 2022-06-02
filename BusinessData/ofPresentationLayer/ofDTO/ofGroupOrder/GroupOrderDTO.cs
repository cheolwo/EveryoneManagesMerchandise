using BusienssData.ofPresentationLayer.ofController.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder
{
    public class GOCDTO : CenterDTO
    {
        [Query(QueryCode.String)]public string? OrderCenters { get; set; }
        [Query(QueryCode.String)]public string? WarehouseId { get; set; }
    }
    public class GOCCDTO : CommodityDTO
    {

    }
    public class SGOCDTO : SStatusDTO
    {

    }
    public class MGOCDTO : MStatusDTO
    {

    }
    public class EGOCDTO : EStatusDTO
    {

    }
}