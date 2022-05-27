using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofGroupOrder
{
    public class GOCDTO : CenterDTO
    {
        public string? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
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