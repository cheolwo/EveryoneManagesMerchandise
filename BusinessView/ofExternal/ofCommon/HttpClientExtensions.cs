using System.Reflection;
using System.Text;
using BusinessView.ofDTO.ofCommon;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusienssLogic.ofController.ofCommon;

namespace BusinessView.ofExternal.ofCommon
{
    public interface IHttpRequestParameter
    {
        IEnumerable<PropertyInfo> GetRequiredProps();
    }
    // public static async Task<HttpResponseMessage> GetWithQueryStringAsync(this HttpClient client, string uri,
        //     Dictionary<string, string> queryStringParams)
        // {
        //     var url = GetUriWithQueryString(uri, queryStringParams);

        //     return await client.GetAsync(url);
        // }
    public enum QueryCode {Key, ForeignKey, Time, QueryString, QueryInt}
    public static class EntityDTOExtensions
    {
        // 이런 걸 책임연쇄 패턴이라고 하는 거구나....
        public static List<PropertyInfo> GetByQueryAttribute(this EntityDTO entityDTO)
        {
            var props = typeof(EntityDTO).GetProperties();
            List<PropertyInfo> propIncludedQueryAttribute = new();
            foreach(var prop in props)
            {
                var QueryAttribute = prop.GetCustomAttribute<QueryAttribute>();
                if(QueryAttribute != null && prop.GetValue(entityDTO) != null)
                {
                    propIncludedQueryAttribute.Add(prop);
                }
            }
            return propIncludedQueryAttribute;
        }
        public static List<PropertyInfo> GetByQueryAttribute<DTO>(this EntityQuery<DTO> entityQuery) where DTO : EntityDTO, new()
        {
            var props = typeof(EntityQuery<DTO>).GetProperties();
            List<PropertyInfo> propIncludedQueryAttribute = new();
            foreach (var prop in props)
            {
                if(prop.PropertyType == typeof(EntityDTO))
                {
                    var dto = (DTO?)prop.GetValue(entityQuery);
                    if(dto != null) 
                    {
                        var propertyInfos = dto.GetByQueryAttribute(); 
                        foreach(var dtoprop in propertyInfos)
                        {
                            propIncludedQueryAttribute.Add(dtoprop);
                        }
                    }
                    continue;
                }
                var QueryAttribute = prop.GetCustomAttribute<QueryAttribute>();
                if (QueryAttribute != null && prop.GetValue(entityQuery) != null)
                {
                    propIncludedQueryAttribute.Add(prop);
                }
            }
            return propIncludedQueryAttribute;
        }
        public static Dictionary<QueryCode, List<PropertyInfo>> DistributedByQueryCode(this List<PropertyInfo> props)
        {
            Dictionary<QueryCode, List<PropertyInfo>> dictionary = new();
            List<PropertyInfo> KeyProps = new();
            List<PropertyInfo> ForeignProps = new();
            List<PropertyInfo> StringProps = new();
            List<PropertyInfo> IntProps = new();
            List<PropertyInfo> TimeProps = new();
            
            dictionary.Add(QueryCode.Key, KeyProps);
            dictionary.Add(QueryCode.ForeignKey, ForeignProps);
            dictionary.Add(QueryCode.QueryString, StringProps);
            dictionary.Add(QueryCode.QueryInt, IntProps);

            foreach(var prop in props)
            {
                var key = prop.GetCustomAttribute<KeyAttribute>();
                if(key != null) 
                {
                    KeyProps = dictionary[QueryCode.Key];
                    KeyProps.Add(prop);
                    continue;
                }
                var foreignKey = prop.GetCustomAttribute<ForeignKeyAttribute>();
                
                if(foreignKey != null) 
                {
                    ForeignProps = dictionary[QueryCode.ForeignKey];
                    KeyProps.Add(prop);
                    continue;
                }
                if(prop.PropertyType == typeof(DateTime))
                {
                    TimeProps = dictionary[QueryCode.Time];
                    TimeProps.Add(prop);
                }
                if(prop.PropertyType == typeof(string))
                {
                    StringProps = dictionary[QueryCode.QueryString];
                    StringProps.Add(prop);
                    continue;
                }
                if(prop.PropertyType == typeof(int))
                {
                    IntProps = dictionary[QueryCode.QueryInt];
                    IntProps.Add(prop);
                    continue;
                }
            }
            return dictionary;
        }
    }
    public static class HttpClientExtensions
    {
        public static string GetUri<T>(string requestUri, T t) where T : class
        {
            var QueryStringParams = GetQueryStringParams<T>(t);
            return GetUriWithQueryString(requestUri, QueryStringParams);
        }
        public static string GetUriByRequired<T>(string requestUri, T t) where T : IHttpRequestParameter
        {
            var QueryStringParams = GetQueryStringParamsByRequired<T>(t);
            return GetUriWithQueryString(requestUri, QueryStringParams);
        }
        private static string GetUriWithQueryString(string requestUri,
                Dictionary<string, string> queryStringParams)
        {
            bool startingQuestionMarkAdded = false;
            var sb = new StringBuilder();
            sb.Append(requestUri);
            foreach (var parameter in queryStringParams)
            {
                if (parameter.Value == null)
                {
                    continue;
                }

                sb.Append(startingQuestionMarkAdded ? '&' : '?');
                sb.Append(parameter.Key);
                sb.Append('=');
                sb.Append(parameter.Value);
                startingQuestionMarkAdded = true;
            }
            return sb.ToString();
        }
        private static Dictionary<string, string> GetQueryStringParamsByRequired<T>(T t) where T : IHttpRequestParameter
        {
            var props = t.GetRequiredProps();
            Dictionary<string, string> QueryStringParams = new();
            foreach(var prop in props)
            {
                if(prop.PropertyType == typeof(int))
                {
                    string value = prop.GetValue(t).ToString();
                    QueryStringParams.Add(prop.Name, value);
                }
                if(prop.PropertyType == typeof(string))
                {
                    string value = (string)prop.GetValue(t);
                    QueryStringParams.Add(prop.Name, value);
                }
                continue;
            }
            return QueryStringParams;
        }
        private static Dictionary<string, string> GetQueryStringParams<T>(T t) where T : class
        {
            var props = typeof(T).GetProperties();
            Dictionary<string, string> QueryStringParams = new();
            foreach(var prop in props)
            {
                if(prop.PropertyType == typeof(int))
                {
                    string value = prop.GetValue(t).ToString();
                    QueryStringParams.Add(prop.Name, value);
                }
                if(prop.PropertyType == typeof(string))
                {
                    string value = (string)prop.GetValue(t);
                    QueryStringParams.Add(prop.Name, value);
                }
                continue;
            }
            return QueryStringParams;
        }
    }
}