using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData
{
    public interface IRelationable
    {
        string GetRelationCode();
        Type GetDbContextType();
        string GetDbConnetionString();
        List<PropertyInfo> OnlyGetProperties();
        List<PropertyInfo> OnlyDetailProperties();
        List<PropertyInfo> GetManyProperties();
        List<PropertyInfo> GetOneProperties();
        List<PropertyInfo> DetailOneProperties();
        List<PropertyInfo> DetailManyProperties();
    }
}
