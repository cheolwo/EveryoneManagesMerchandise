using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofJournal.ofInterface.ofPlatform;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofJournal.ofRepository
{
    public interface IJournalCenterRepository : ICenterDataRepository<JournalCenter>
    {

    }
    public interface IJCommodityRepository : ICommodityDataRepository<JCommodity>
    {

    }
    public interface IJournalRepository : IEntityDataRepository<Journal>
    {

    }
    public interface IUserSettingJournalRepository : IEntityDataRepository<UserSettingJournal>
    {

    }
    public class JournalCenterRepository : CenterDataRepository<JournalCenter>, IJournalCenterRepository, IEmployeeJournalCenterRepository, IEmployerJournalCenterRepository, IPlatformJournalCenterRepository
    {
        public JournalCenterRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
    }
    public class JCommodityRepository : CommodityDataRepository<JCommodity>, IJCommodityRepository, IEmployerJCommodityRepository, IEmployeeJCommodityRepository, IPlatformJCommodityRepository
    {
        public JCommodityRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
    }
    public class UserSettingJournalRepository : EntityDataRepository<UserSettingJournal>
    {
        public UserSettingJournalRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
        public async Task<UserSettingJournal> GetByEntityName(string entityTypeName)
        {
            return await _DbContext.Set<UserSettingJournal>().FirstOrDefaultAsync(e=>e.EntityTypeName.Equals(entityTypeName));
        }
    }
    public class JournalRepository : EntityDataRepository<Journal>, IJournalRepository, IEmployeeJournalRepository, IEmployerJournalRepository, IPlatformJournalRepository
    {
        public JournalRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
    }
}
