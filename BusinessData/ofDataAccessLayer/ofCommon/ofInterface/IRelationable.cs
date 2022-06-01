using System;

namespace BusinessData
{
    public interface IRelationable
    {
        string GetRelationCode();
        Type GetDbContextType();
        string GetDbConnetionString();     
    }
}
