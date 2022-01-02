using System;

namespace BusinessData
{
    public interface IRelationEntity
    {
        string GetRelationCode();
        Type GetRelationType();
    }
}
