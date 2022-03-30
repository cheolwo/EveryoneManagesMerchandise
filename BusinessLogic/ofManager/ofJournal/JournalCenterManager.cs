using BusinessData;
using BusinessData.ofFinancial.Model;
using BusinessData.ofFinancial.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofJournal.ofIdFactory;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using System;

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
    public class JournalCenterManager : CenterManager<JournalCenter>, IEmployerJournalCenterManager, IEmployeeJournalCenterManager, IPlatformJournalCenterManager, IJournalCenterManager
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
    public class JCommodityManager : CommodityManager<JCommodity>, IEmployerJCommodityManager, IEmployeeJCommodityManager, IPlatformJCommodityManager, IJCommodityManager
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
    public class JournalManager : EntityManager<Journal>, IEmployerJournalManager, IEmployeeJournalManager, IPlatformJournalManager, IJournalManager
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
    //public class StatsJournalManager<TEntity> : JournalManager, IObserver<TEntity> where TEntity : Status, IRelationable, new()
    //{
    //    public void OnCompleted()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void OnError(Exception error)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void OnNext(TEntity value)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
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