using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace BusinessData.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(ConfirmationByTheCustomsOfficer), "ConfirmationByTheCustomsOfficer")]
    public class ConfirmationByTheCustomsOfficer : Entity
    {
        public string ClassificationofImportAndExport { get; set; }
        public DateTime ApplicationEndDate { get; set; }
        public DateTime ApplicationStartDate { get; set; }
        public string RelatedLaws { get; set; }
        public string RequirementConfirmationDocumentName { get; set; }
        [ForeignKey("HsCode")]  public DetailPracticalHsCode DetailPracticalHsCode { get;set; }
    }
}
