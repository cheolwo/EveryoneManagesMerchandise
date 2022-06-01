using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofExternal.ofCommon;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(DotBarcode))]
    public class EmployerDotBarcode : DotBarcodeDTO
    {

    }
}
