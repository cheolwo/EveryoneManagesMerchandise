using System.Collections.Generic;
using BusinessData.ofWarehouse;
using BusinessData.ofWarehouse.Model;

namespace BusinessLogic.ofStorage
{
    public class WarehouseStorageService
    {
        private readonly Dictionary<string, Warehouse> dictionaryWarehouse = new();
        public Dictionary<string, Warehouse> DictionaryWarehouse
        {
            get => dictionaryWarehouse;
        }
        public WarehouseStorageService()
        {
            
        }
        public void Insert(Warehouse warehouse)
        {
            if(warehouse != null)
            {
                dictionaryWarehouse.Add(warehouse.Id, warehouse);
            }
        }
    }
}