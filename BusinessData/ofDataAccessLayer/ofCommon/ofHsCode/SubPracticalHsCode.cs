using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(SubPracticalHsCode), "SubPracticalHsCode")]
    // 소호
    public class SubPracticalHsCode : Entity
    {
        public string UsName { get; set; }
        public PracticalHsCode PracticalHsCode { get; set; }
        public List<DetailPracticalHsCode> DetailPracticalHsCodes {get; set;}
        public void Clear()
        {
            PracticalHsCode.Clear();
            DetailPracticalHsCodes.Clear();
        }
    }
}
