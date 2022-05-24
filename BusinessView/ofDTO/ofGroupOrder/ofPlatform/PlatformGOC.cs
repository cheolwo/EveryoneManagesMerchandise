using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessData.ofGroupOrder;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData;

namespace BusinessView.ofDTO.ofGroupOrder.ofPlatform
{
    [AutoMap(typeof(GOC))]
    public class PlatformGOC : PlatformCenter
    {
        public string? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
    }
}
