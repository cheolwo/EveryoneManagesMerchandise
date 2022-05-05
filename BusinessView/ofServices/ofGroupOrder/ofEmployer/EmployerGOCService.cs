﻿using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer
{
    public class EmployerGOCService : GroupOrderService
    {
        public EmployerGOCService(GroupOrderServiceOptions options)
            : base(options)
        {

        }
    }
}
