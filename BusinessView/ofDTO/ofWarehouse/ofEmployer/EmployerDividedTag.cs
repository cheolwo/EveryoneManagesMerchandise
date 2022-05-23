﻿using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    public class EmployerDividedTag : EmployerEntity
    {
        [Get] public bool Attached { get; set; }
        [Get] public string? IncomingTagId { get; set; }
        [Get] public string? WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag, typeof(IncomingTag))] public string? IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
