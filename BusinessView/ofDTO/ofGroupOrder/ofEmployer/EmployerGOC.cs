﻿using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofGroupOrder.ofEmployer
{
    public class EmployerGOC : EmployerCenter
    {
        public List<string>? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
    }
}
