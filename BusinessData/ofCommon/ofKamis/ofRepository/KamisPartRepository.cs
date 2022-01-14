using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofKamis.ofModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofCommon.ofKamis.ofRepository
{
    public class KamisGradeRepository : EntityDataRepository<KamisGrade>
    {
        public KamisGradeRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class KamisPartRepository : EntityDataRepository<KamisPart>
    {
        public KamisPartRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class KamisCommodityRepository : EntityDataRepository<KamisCommodity>
    {
        public KamisCommodityRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class KamisKindofCommodityRepository : EntityDataRepository<KamisKindofCommodity>
    {
        public KamisKindofCommodityRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class KamisCountryAdministrationPartRepository : EntityDataRepository<KamisCountryAdministrationPart>
    {
        public KamisCountryAdministrationPartRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class KamisMarketRepository : EntityDataRepository<KamisMarket>
    {
        public KamisMarketRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class KamisDayPriceRepository : EntityDataRepository<KamisDayPrice>
    {
        public KamisDayPriceRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
}
