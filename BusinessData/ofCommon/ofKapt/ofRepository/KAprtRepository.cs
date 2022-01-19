using BusinessData.ofCommon.ofKapt;
using BusinessData.ofCommon.ofKApt.ofDbContext;

namespace BusinessData.ofCommon.ofKAprt.ofRepository
{
    public class KAptBasicInfoRepository : EntityDataRepository<KAptBasicInfo>
    {
        public KAptBasicInfoRepository(KAptDbContext KAprtDbContext)
            : base(KAprtDbContext) { }
    }
}