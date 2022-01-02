using System.Threading.Tasks;
using BusinessData.ofFinancial.Model;
using BusinessData.ofGenericRepository;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofFinancial.ofRepository
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
    public class JournalCenterRepository : CenterDataRepository<JournalCenter>
    {
        public JournalCenterRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
    }
    public class JCommodityRepository : CommodityDataRepository<JCommodity>
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
    public class JournalRepository : EntityDataRepository<Journal>
    {
        public JournalRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
    }
}
