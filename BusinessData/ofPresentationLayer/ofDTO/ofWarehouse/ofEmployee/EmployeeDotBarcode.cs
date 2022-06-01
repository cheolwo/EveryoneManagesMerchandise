using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofExternal.ofCommon;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(DotBarcode))]
    public class EmployeeDotBarcode : DotBarcodeDTO
    {

    }
}
