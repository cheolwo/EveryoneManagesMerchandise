using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofProduct.ofInterface.ofEmployee;
using BusinessData.ofProduct.ofInterface.ofEmployer;
using BusinessData.ofProduct.ofInterface.ofPlatform;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofProduct.ofRepository
{
    public interface IProductCenterRepository : ICenterDataRepository<ProductCenter>
    {
        Task<List<ProductCenter>> GetToListByCountryCodeWithSPCommodity(string CountryCode);
        Task<List<ProductCenter>> GetToListByCountryCodeWithPCommodity(string CountryCode);
        Task<List<ProductCenter>> GetToListByCountryCodeWithProducter(string CountryCode);
        Task<List<ProductCenter>> GetToListByCountryCodeWithPCommodityWithSPCommodity(string CountryCode);
    }
    public interface IPCommodityRepository : ICommodityDataRepository<PCommodity>
    {
        
    }
    public interface ISPCommodityRepository : IStatusDataRepository<SPCommodity>
    {
        Task<List<SPCommodity>> GetToListByPCommodity(PCommodity pCommodity);
        Task<List<SPCommodity>> GetToListByTradableWithPCommodityAndProducter();
        Task<List<SPCommodity>> GetToListByTradableWithPCommodityAndProducterAndProductCenter();
    }
    public interface IMPCommodityRepository : IStatusDataRepository<MPCommodity>
    {
        
    }
    public interface IEPCommodityRepository : IStatusDataRepository<EPCommodity>
    {
        
    }
    public class ProductCenterRepository : CenterDataRepository<ProductCenter>, IProductCenterRepository, IEmployeeProductCenterRepository, IEmployerProductCenterRepository, IPlatformProductCenterRepository
    {
        public ProductCenterRepository(ProductDbContext ProductDbContext)
                : base(ProductDbContext)
        {

        }

        public async Task<List<ProductCenter>> GetToListByCountryCodeWithPCommodity(string CountryCode)
        {
            return await _DbContext.Set<ProductCenter>().Where(e => e.CountryCode.Equals(CountryCode)).Include(entity => entity.PCommodities).ToListAsync(); 
        }

        public async Task<List<ProductCenter>> GetToListByCountryCodeWithPCommodityWithSPCommodity(string CountryCode)
        {
            return await _DbContext.Set<ProductCenter>().Where(e => e.CountryCode.Equals(CountryCode)).Include(entity => entity.PCommodities).ThenInclude(entity => entity.SPCommodities).ToListAsync();                       
        }

        public async Task<List<ProductCenter>> GetToListByCountryCodeWithProducter(string CountryCode)
        {
            return await _DbContext.Set<ProductCenter>().Where(e => e.CountryCode.Equals(CountryCode)).Include(entity => entity.Producters).ToListAsync();
        }

        public async Task<List<ProductCenter>> GetToListByCountryCodeWithSPCommodity(string CountryCode)
        {
            return await _DbContext.Set<ProductCenter>().Where(e => e.CountryCode.Equals(CountryCode)).Include(entity => entity.SPCommodities).ToListAsync();
        }
    }
    public class PCommodityRepository : CommodityDataRepository<PCommodity>, IPCommodityRepository, IEmployeePCommodityRepository, IEmployerPCommodityRepository, IPlatformPCommodityRepository
    {
        public PCommodityRepository(ProductDbContext ProductDbContext)
                : base(ProductDbContext)
        {

        }
    }
    public class SPCommodityRepository : StatusDataRepository<SPCommodity>, ISPCommodityRepository, IEmployeeSPCommodityRepository, IEmployerSPCommodityRepository, IPlatformSPCommodityRepository
    {
        public SPCommodityRepository(ProductDbContext ProductDbContext)
                : base(ProductDbContext)
        {

        }
        public async Task<List<SPCommodity>> GetToListByPCommodity(PCommodity pCommodity)
        {
            return await _DbContext.Set<SPCommodity>().Where(e => e.PCommodity.Equals(pCommodity)).ToListAsync();
        }

        public async Task<List<SPCommodity>> GetToListByTradableWithPCommodityAndProducter()
        {
            return await _DbContext.Set<SPCommodity>().Where(e=>e.IsTablable.Equals(true)).Include(e => e.PCommodity).Include(e =>  e.Producter).ToListAsync();
        }

        public async Task<List<SPCommodity>> GetToListByTradableWithPCommodityAndProducterAndProductCenter()
        {
            return await _DbContext.Set<SPCommodity>().Where(e=>e.IsTablable.Equals(true)).Include(e => e.PCommodity).Include(e =>  e.Producter).Include(e => e.ProductCenter).ToListAsync();
        }
    }
    public class MPCommodityRepository : StatusDataRepository<MPCommodity>, IMPCommodityRepository, IEmployeeMPCommodityRepository, IEmployerMPCommodityRepository, IPlatformMPCommodityRepository
    {
        public MPCommodityRepository(ProductDbContext ProductDbContext)
                : base( ProductDbContext)
        {

        }
    }
    public class EPCommodityRepository : StatusDataRepository<EPCommodity>, IEPCommodityRepository, IEmployeeEPCommodityRepository, IEmployerEPCommodityRepository, IPlatformEPCommodityRepository
    {
        public EPCommodityRepository(ProductDbContext ProductDbContext)
                : base(ProductDbContext)
        {

        }
    }
}