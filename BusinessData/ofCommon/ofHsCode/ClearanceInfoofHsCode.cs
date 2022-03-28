﻿using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(ClearanceInfoofHsCode), "ClearanceInfoofHsCode")]
    public class ClearanceInfoofHsCode : Entity
    {
        public string BasicTaxRate { get; set; }
        public List<AgreetMentTaxRate> AgreetMentTaxRates { get; set; }
        [ForeignKey("HsCode")] public DetailPracticalHsCode DetailPracticalHsCode { get; set; }
        //public ClearanceInfoofHsCode()
        //{
        //    AgreetMentTaxRates = new();
        //    DetailPracticalHsCode = new DetailPracticalHsCode();   
        //}
        public void Clear()
        {
            AgreetMentTaxRates.Clear();
            DetailPracticalHsCode.Clear();
        }
    }
}
