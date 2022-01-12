using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofInterface
{
    public static class TableMetaInfo
    {                                         
        public const string Get = "Get";
        public const string GetOne = "GetOne";
        public const string DetailOne = "DetailOne";
        public const string Detail = "Detail";
        public const string GetMany = "GetMany";
        public const string DetailMany = "DetailMany";
    }
    public interface ITablable
    {
        Dictionary<string, List<PropertyInfo>> GetToDictionaryforClassifiedPropertyByAttribute();
    }
}
