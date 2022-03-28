using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    //호
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(PracticalHsCode), "PracticalHsCode")]
    public class PracticalHsCode : Entity
    {
        public string UsName { get; set; }  
        public List<SubPracticalHsCode> SubPracticalHsCodes { get; set; }
        public SubPartofHsCode SubPartofHsCode { get; set; } // 류
        //public PracticalHsCode()
        //{
        //    DetailPracticalHsCodes = new();
        //    SubPartofHsCode = new();
        //}
        public void Clear()
        {
            SubPracticalHsCodes.Clear();
            SubPartofHsCode = null;
        }
    }
}
