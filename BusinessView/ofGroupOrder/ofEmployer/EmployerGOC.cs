using BusinessView.ofCommon.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofGroupOrder.ofEmployer
{
    public class EmployerGOC : EmployerCenter
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
    public class EmployerGOCC : EmployerCommodity
    {

    }
    public class EmployerSGOC : EmployerSStatus
    {

    }
    public class EmployerMGOC : EmployerMStatus
    {

    }
    public class EmployerEGOC : EmployerEStatus
    {

    }
}
