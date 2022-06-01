using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    // Generic 의 경우 DTO 에서 Json String
    /*
    Serializing to a UTF-8 byte array is about 5-10% faster than using the string-based methods. 
    The difference is because the bytes (as UTF-8) don't need to be converted to strings (UTF-16).
    To serialize to a UTF-8 byte array, call the JsonSerializer.SerializeToUtf8Bytes method:

    C#
    byte[] jsonUtf8Bytes =JsonSerializer.SerializeToUtf8Bytes(weatherForecast);
     */
    [AutoMap(typeof(Warehouse))]
    public class PlatformWarehouse : WarehouseDTO
    {
        
    }
}
