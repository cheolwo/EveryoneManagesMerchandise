using BusinessView.ofDTO.ofCommon.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofDTO.ofGroupOrder.ofPlatform
{
    public class PlatformGOC : PlatformCenter
    {
        public List<string>? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
    }
}
