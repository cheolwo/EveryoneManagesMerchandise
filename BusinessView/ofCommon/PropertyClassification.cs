using System.Reflection;

namespace BusinessView.ofCommon
{
    public static class PropertyClassification
    {
        public static Dictionary<string, PropertyInfo> ClassifyIntProperty(IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, PropertyInfo> result = new Dictionary<string, PropertyInfo>();
            if (propertyInfos != null)
            {
                foreach (var prop in propertyInfos)
                {
                    if (prop.PropertyType == typeof(int))
                    {
                        result.Add(prop.Name, prop);
                    }
                }
            }
            return result;
        }
        public static Dictionary<string, PropertyInfo> ClassifyStringProperty(IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, PropertyInfo> result = new Dictionary<string, PropertyInfo>();
            if (propertyInfos != null)
            {
                foreach (var prop in propertyInfos)
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        result.Add(prop.Name, prop);
                    }
                }
            }
            return result;
        }
        public static Dictionary<string, PropertyInfo> ClassifyDateTimeProperty(IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, PropertyInfo> result = new Dictionary<string, PropertyInfo>();
            if (propertyInfos != null)
            {
                foreach (var prop in propertyInfos)
                {
                    if (prop.PropertyType == typeof(DateTime))
                    {
                        result.Add(prop.Name, prop);
                    }
                }
            }
            return result;
        }
    }
}
