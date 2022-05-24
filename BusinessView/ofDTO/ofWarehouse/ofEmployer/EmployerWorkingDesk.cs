using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(WorkingDesk))]
    public class EmployerWorkingDesk : EmployerEntity
    {
        public bool IsUsed { get; set; }
        [Detail][One(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
