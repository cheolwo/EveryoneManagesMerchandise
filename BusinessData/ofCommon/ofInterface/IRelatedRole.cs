using System;
using System.Collections.Generic;

namespace BusinessData
{
    public interface IRelatedRoles
    {
        IList<string> GetRelatedRoles(Type t);
    }
}
