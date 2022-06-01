using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;
using BusinessData.ofWarehouse.ofDbContext;

namespace BusinessData.ofWarehouse.Model
{
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    public class Pack : Entity
    {
        public string Material { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
    }
}
