using BusinessData.ofFinancial.Model;
using BusinessData.ofGeneric.ofIdFactory;

namespace BusinessLogic.ofManager.ofJournal.ofIdFactory
{
    public interface IJournalCenterIdFactory : ICenterIdFactory<JournalCenter>
    {
        
    }
    public interface IJCommodityIdFactory : ICommodityIdFactory<JCommodity>
    {
        
    }
    public interface IJournalIdFactory : IEntityIdFactory<Journal>
    {
        
    }
    public interface IUserSettingJournalIdFactory : IEntityIdFactory<UserSettingJournal>
    {
        
    }
}