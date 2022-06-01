using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    public enum KindsofAgreetMent { FTA, CustomsUnion, CommonMarket, EconomicUnion, CompleteEconomicUnion}
    //부
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(HsCodePart), "HsCodePart")]
    public class HsCodePart : Entity
    {
        public List<SubPartofHsCode> SubPartofHsCodes { get; set; }
    }
    public class AgreetMentTaxRate
    {
        public AgreetMentTaxRate(string TaxRate, string Name)
        {
            this.TaxRate = TaxRate;
            this.Name = Name;   
        }
        public string TaxRate { get; set; }
        public string Name { get; set; }
    }
}
