using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofWarehouse.ofDbContext
{
    public class WHumanResourceDbContext : IdentityDbContext
    {
        public WHumanResourceDbContext(DbContextOptions<WHumanResourceDbContext> option)
                : base(option)
        {

        }
    }
}
