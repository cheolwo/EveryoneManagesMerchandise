﻿using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeEOCommodityService : OrderService
    {
        public EmployeeEOCommodityService(OrderServiceOptions options)
            : base(options)
        {

        }

    }
}
