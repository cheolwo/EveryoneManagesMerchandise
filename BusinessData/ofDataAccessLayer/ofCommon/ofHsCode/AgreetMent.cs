using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(AgreetMentTaxRate), "AgreetMent")]
    public class AgreetMent : Entity
    {
        // Name is KindsofAgreetMent
        public DateTime StartTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<string> CoutryName { get; set; }
    }
}
