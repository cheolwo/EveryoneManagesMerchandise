﻿using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(DividedTag), "DT")]
    public class DividedTag : Entity
    {
        public bool Attached { get; set; }
        public string IncomingTagId {get; set;}
        public string WarehouseId {get; set;}
        public IncomingTag IncomingTag { get; set; }
        public Warehouse Warehouse { get; set; }
        public DividedTag()
        {
            Warehouse = new();
            IncomingTag = new();
        }
        public string GetBarcodeInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}