using System.Collections.Generic;
using System.Reflection;

namespace PlatformManager.Pages.ofGeneric
{
    // 이것도 Dictionary 형태로 만드는 게 좋아보이기는 해.
    public class TableInfo
    {
        private Dictionary<string, PropertyInfo> NamePropPairs {get; set;}
        private PropertyInfo Origin {get; set;}
        public TableInfo(PropertyInfo origin)
        {
            Origin = origin;
            NamePropPairs = new();
        }    
        public void Add(string name, PropertyInfo prop)
        {
            NamePropPairs.Add(name, prop);
        }
        public IEnumerable<string> GetColumns()
        {
            return NamePropPairs.Keys;
        }
        public List<PropertyInfo> GetValues()
        {
            List<PropertyInfo> props = new();
            foreach(var key in NamePropPairs.Keys)
            {
                props.Add(NamePropPairs[key]);
            }
            return props;
        }
    }
}