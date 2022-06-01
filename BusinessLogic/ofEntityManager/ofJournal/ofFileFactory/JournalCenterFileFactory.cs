using BusinessData.ofFinancial.Model;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofWarehouse.ofFileFactory
{
    public interface IJournalCenterFileFactory : ICenterFileFactory<JournalCenter>
    {

    }
    public class JournalCenterFileFactory : CenterFileFactory<JournalCenter>, IJournalCenterFileFactory
    {

    }
    public interface IJCommodityFileFactory : ICommodityFileFactory<JCommodity>
    {

    }
    public class JCommodityFileFactory : CommodityFileFactory<JCommodity>, IJCommodityFileFactory
    {

    }
    public interface IJournalFileFactory : IEntityFileFactory<Journal>
    {

    }
    public class JournalFileFactory : EntityFileFactory<Journal>, IJournalFileFactory
    {

    }
    public interface IUserSettingJournalFileFactory : IEntityFileFactory<UserSettingJournal>
    {

    }
    public class UserSettingJournalFileFactory : EntityFileFactory<UserSettingJournal>, IUserSettingJournalFileFactory
    {

    }
}