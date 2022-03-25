using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    //류
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(SubPartofHsCode), "SubPartofHsCode")]
    public class SubPartofHsCode : Entity
    {
        public HsCodePart HsCodePart { get; set; }
        public List<PracticalHsCode> PracticalHsCodes { get; set; }
    }
}
