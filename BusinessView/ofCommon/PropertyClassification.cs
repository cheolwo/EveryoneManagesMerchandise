using System.Reflection;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
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
        public static Dictionary<string, PropertyInfo> ClassifyDateTimeProperty(ComponentMode mode, Type t)
        {
            if (mode == ComponentMode.Get)
            {
                var propertyInfos = OnlyGetProperties(t);
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
            if (mode == ComponentMode.Detail)
            {
                var propertyInfos = OnlyDetailProperties(t);
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
        public static Dictionary<string, PropertyInfo> ClassifyStringProperty(ComponentMode mode, Type t)
        {
            if (mode == ComponentMode.Get)
            {
                var propertyInfos = OnlyGetProperties(t);
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
            if (mode == ComponentMode.Detail)
            {
                var propertyInfos = OnlyDetailProperties(t);
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
        }
        public static Dictionary<string, PropertyInfo> ClassifyintProperty(ComponentMode mode, Type t)
        {
            if (mode == ComponentMode.Get)
            {
                var propertyInfos = OnlyGetProperties(t);
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
            if (mode == ComponentMode.Detail)
            {
                var propertyInfos = OnlyDetailProperties(t);
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
        }
        public static List<PropertyInfo> OnlyGetProperties(Type t)
        {
            List<PropertyInfo> OnlyGetPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (Many is null && One is null)
                    {
                        OnlyGetPropertyInfos.Add(prop);
                    }
                }
            }
            return OnlyGetPropertyInfos;
        }
        public static List<PropertyInfo> OnlyDetailProperties(Type t)
        {
            List<PropertyInfo> OnlyDetailPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<DetailAttribute>();
                if (Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (Many is null && One is null)
                    {
                        OnlyDetailPropertyInfos.Add(prop);
                    }
                }
            }
            return OnlyDetailPropertyInfos;
        }
        public static List<PropertyInfo> GetPropertiesByComponentMode(ComponentMode componentMode, Type t)
        {
            if(componentMode == ComponentMode.Get)
            {
                return OnlyGetProperties(t);
            }
            if(componentMode ==  ComponentMode.Detail)
            {
                return OnlyDetailProperties(t);
            }
        }
        
        public static List<PropertyInfo> OnlyGetManyProperties(Type t)
        {
            List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if (Many != null)
                    {
                        GetManyPropertyInfos.Add(prop);
                    }
                }
            }
            return GetManyPropertyInfos;
        }

        public static List<PropertyInfo> OnlyGetOneProperties(Type t)
        {
            List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (One != null)
                    {
                        GetOnePropertyInfos.Add(prop);
                    }
                }
            }
            return GetOnePropertyInfos;
        }

        public static List<PropertyInfo> OnlyDetailOneProperties(Type t)
        {
            List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if (Detail != null)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (One != null)
                    {
                        GetOnePropertyInfos.Add(prop);
                    }
                }
            }
            return GetOnePropertyInfos;
        }

        public static List<PropertyInfo> OnlyDetailManyProperties(Type t)
        {
            List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if (Detail != null)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if (Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                    }
                }
            }
            return DetailManyPropertyInfos;
        }
        public static Dictionary<string, List<PropertyInfo>> DictionaryforClassifiedPropertyByAttribute(Type t)
        {
            List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> GetPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> GetOneInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailOneInfos = new List<PropertyInfo>();

            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Many = prop.GetCustomAttribute<ManyAttribute>();
                var Get = prop.GetCustomAttribute<GetAttribute>();
                if (Get != null)
                {
                    if (Many != null)
                    {
                        GetManyPropertyInfos.Add(prop);
                        continue;
                    }
                    GetPropertyInfos.Add(prop);
                }
            }
            foreach (var prop in props)
            {
                var Many = prop.GetCustomAttribute<ManyAttribute>();
                var Detail = prop.GetCustomAttribute<DetailAttribute>();
                if (Detail != null)
                {
                    if (Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                        continue;
                    }
                    DetailPropertyInfos.Add(prop);
                }
            }
            foreach (var prop in props)
            {
                var One = prop.GetCustomAttribute<OneAttribute>();
                var Get = prop.GetCustomAttribute<GetAttribute>();
                var Detail = prop.GetCustomAttribute<DetailAttribute>();

                if (One != null)
                {
                    if (Get != null)
                    {
                        GetOneInfos.Add(prop);
                        continue;
                    }
                    if (Detail != null)
                    {
                        DetailOneInfos.Add(prop);
                        continue;
                    }
                }
            }
            Dictionary<string, List<PropertyInfo>> keyValuePairs = new();
            keyValuePairs.Add(TableMetaInfo.Get, GetPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.GetMany, GetManyPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.Detail, DetailPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.DetailMany, DetailManyPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.GetOne, GetOneInfos);
            keyValuePairs.Add(TableMetaInfo.DetailOne, DetailOneInfos);
            return keyValuePairs;
        }
    
    }
}
