using BusinessData.ofFinancial.Model;
using BusinessData.ofFinancial.ofRepository;
using BusinessData.ofGeneric.ofIdFactory;

namespace BusinessLogic.ofManager.ofJournal.ofIdFactory
{
    public interface IJournalCenterIdFactory : ICenterIdFactory<JournalCenter>
    {
        
    }
   public class JournalCenterIdFactory : CenterIdFactory<JournalCenter>, IJournalCenterIdFactory
    {
        public JournalCenterIdFactory(IJournalCenterRepository JournalCenterRepository)
            : base(JournalCenterRepository)
        {

        }
    }
    public interface IJCommodityIdFactory : ICommodityIdFactory<JCommodity>
    {
        
    }
    public class JCommodityIdFactory : CommodityIdFactory<JCommodity>, IJCommodityIdFactory
    {
        public JCommodityIdFactory(IJCommodityRepository JCommodityRepository)
            : base(JCommodityRepository)
        {

        }
    }
    public interface IJournalIdFactory : IEntityIdFactory<Journal>
    {
        
    }
    public class JournalIdFactory : EntityIdFactory<Journal>, IJournalIdFactory
    {
        public JournalIdFactory(IJournalRepository JournalRepository)
            : base(JournalRepository)
        {

        }
    }
    public interface IUserSettingJournalIdFactory : IEntityIdFactory<UserSettingJournal>
    {
        
    }
}