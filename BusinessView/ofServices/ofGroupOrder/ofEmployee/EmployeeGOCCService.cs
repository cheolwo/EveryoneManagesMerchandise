﻿using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee
{
    public class EmployeeGOCCService : GroupOrderService
    {
        public EmployeeGOCCService(GroupOrderServiceOptions options)
            : base(options)
        {

        }
    }
}
