﻿using BusinessView.ofCommon.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofGroupOrder.ofPlatform
{
    public class PlatformGOC : PlatformCenter
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
    public class PlatformGOCC : PlatformCommodity
    {

    }
    public class PlatformSGOC : PlatformSStatus
    {

    }
    public class PlatformMGOC : PlatformMStatus
    {

    }
    public class PlatformEGOC : PlatformEStatus
    {

    }
}