using System.Reflection;
namespace BusinessView.ofCommon.ofInterface
{
    public interface IEntityDTO
    {
        List<PropertyInfo> OnlyGetProperties(Type t);
        List<PropertyInfo> OnlyDetailProperties(Type t);
        List<PropertyInfo> OnlyGetOneProperties(Type t);
        List<PropertyInfo> OnlyGetManyProperties(Type t);
        List<PropertyInfo> OnlyDetailOneProperties(Type t);
        List<PropertyInfo> OnlyDetailManyProperties(Type t);
        Dictionary<string, List<PropertyInfo>> DictionaryforClassifiedPropertyByAttribute(Type t);
        bool EqualsById(object obj);
    }
}