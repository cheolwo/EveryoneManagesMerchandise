// See https://aka.ms/new-console-template for more information
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Reflection;

EmployerWCommodity employerWCommodity = new();
var props = employerWCommodity.OnlyGetProperties(typeof(EmployerWCommodity));
var StringResult = PropertyClassification.ClassifyStringProperty(props);
var IntResult = PropertyClassification.ClassifyIntProperty(props);
var DateTimeResult = PropertyClassification.ClassifyDateTimeProperty(props);

foreach(var key in StringResult.Keys)
{
    Console.WriteLine("It is StringResult : {0}", key);
}
Console.WriteLine();
foreach (var key in IntResult.Keys)
{
    Console.WriteLine("It is  IntResult : {0}", key);
}
Console.WriteLine();
foreach (var key in DateTimeResult.Keys)
{
    Console.WriteLine("It is DateTimeResult : {0}", key);
}
Console.WriteLine();

public static class PropertyClassification
{
    public static Dictionary<string, PropertyInfo> ClassifyIntProperty(IEnumerable<PropertyInfo> propertyInfos)
    {
        Dictionary<string, PropertyInfo> result = new Dictionary<string, PropertyInfo>();
        if(propertyInfos != null)
        {
            foreach(var prop in propertyInfos)
            {
                if(prop.PropertyType == typeof(int))
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