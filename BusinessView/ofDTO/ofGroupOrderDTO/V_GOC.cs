using BusinessView.ofCommon;

namespace BusinessView.ofGroupOrder
{
    public class V_GOC : V_Center
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
    public class V_GOCC : V_Commodity
    {

    }
    public class V_SGOC : V_SStatus
    {

    }
    public class V_MGOC : V_MStatus
    {

    }
    public class V_EGOC : V_EStatus
    {

    }
}
