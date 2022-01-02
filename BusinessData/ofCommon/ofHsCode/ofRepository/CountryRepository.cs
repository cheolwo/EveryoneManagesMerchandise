using BusinessData.ofCommon.ofHsCode.ofDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofCommon.ofHsCode.ofRepository
{
    public  class CountryRepository : EntityDataRepository<Country>
    {
        public CountryRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class AgreetMentRepository : EntityDataRepository<AgreetMent>
    {
        public AgreetMentRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class HsCodePartRepository : EntityDataRepository<HsCodePart> 
    {
        public HsCodePartRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class SubPartofHsCodeRepository : EntityDataRepository<SubPartofHsCode> 
    {
        public SubPartofHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    } 
    public class PracticalHsCodeRepository : EntityDataRepository<PracticalHsCode> 
    {
        public PracticalHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class DetailPracticalHsCodeRepository : EntityDataRepository<DetailPracticalHsCode> 
    {
        public DetailPracticalHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class ClaranceInfoofHsCodeRepostiroy : EntityDataRepository<ClearanceInfoofHsCode> 
    {
        public ClaranceInfoofHsCodeRepostiroy(HsDbContext hsDbContext)
           : base(hsDbContext) { }
     }
    public class ConfirmationByTheCutomerOfficierRepostiory : EntityDataRepository<ConfirmationByTheCustomsOfficer> 
    {
        public ConfirmationByTheCutomerOfficierRepostiory(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
}
