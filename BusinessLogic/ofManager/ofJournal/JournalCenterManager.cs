using BusinessData.ofFinancial.Model;
using BusinessData.ofFinancial.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofJournal.ofIdFactory;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager
{
    public interface IJournalCenterManager : ICenterManager<JournalCenter>
    {

    }
    public interface IJournalManager : IEntityManager<Journal>
    {
       
    }
    public interface IJCommodityManager : ICommodityManager<JCommodity>
    {
       
    }
    public interface IUserSettingJournalManager : IEntityManager<UserSettingJournal>
    {
       
    }
    public class JournalCenterManager : CenterManager<JournalCenter>, IJournalCenterManager
    {
       public JournalCenterManager(IJournalCenterRepository centerDataRepository,
                               IJournalCenterIdFactory journalCenterIdFactory,
                               IJournalCenterFileFactory journalCenterFactory,
                               IEntityBlobStorage<JournalCenter> blobStorage,
                               DicConvertFactory<JournalCenter> dicConvertFactory,
                               CenterPasswordHasher<JournalCenter> centerPasswordHasher)
           : base(centerDataRepository, journalCenterIdFactory, journalCenterFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
       {

       }
    }
    public class JCommodityManager : CommodityManager<JCommodity>, IJCommodityManager
    {
       public JCommodityManager(IJCommodityRepository CommodityDataRepository,
           IJCommodityIdFactory jCommodityIdFactory,
                               IJCommodityFileFactory commodityFileFactory,
                               IEntityBlobStorage<JCommodity> blobStorage,
                               DicConvertFactory<JCommodity> dicConvertFactory)
           : base(CommodityDataRepository, jCommodityIdFactory, commodityFileFactory, blobStorage, dicConvertFactory)
       {

       }
    }
    public class JournalManager : EntityManager<Journal>, IJournalManager
    {
       public JournalManager(IJournalRepository CommodityDataRepository,
                               IJournalIdFactory journalIdFactory,
                               IJournalFileFactory commodityFileFactory,
                               IEntityBlobStorage<Journal> blobStorage,
                               DicConvertFactory<Journal> dicConvertFactory)
           : base(CommodityDataRepository, journalIdFactory, commodityFileFactory, blobStorage, dicConvertFactory)
       {

       }
    }
    public class UserSettingJournalManager : EntityManager<UserSettingJournal>, IUserSettingJournalManager
    {
       public UserSettingJournalManager(IUserSettingJournalRepository CommodityDataRepository,
                               IUserSettingJournalIdFactory userSettingJournalIdFactory,
                               IUserSettingJournalFileFactory commodityFileFactory,
                               IEntityBlobStorage<UserSettingJournal> blobStorage,
                               DicConvertFactory<UserSettingJournal> dicConvertFactory)
           : base(CommodityDataRepository, userSettingJournalIdFactory, commodityFileFactory, blobStorage, dicConvertFactory)
       {

       }
    }
}