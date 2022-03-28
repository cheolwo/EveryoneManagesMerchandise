using BusinessView.ofCommon.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofGroupOrder.ofEmployee
{
    public class EmployeeGOC : EmployeeCenter
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
    public class EmployeeGOCC : EmployeeCommodity
    {

    }
    public class EmployeeSGOC : EmployeeSStatus
    {

    }
    public class EmployeeMGOC : EmployeeMStatus
    {

    }
    public class EmployeeEGOC : EmployeeEStatus
    {

    }
}
