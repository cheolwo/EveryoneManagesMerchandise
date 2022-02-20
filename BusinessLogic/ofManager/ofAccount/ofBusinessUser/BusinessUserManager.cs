using BusinessData.ofAccount.ofModel;
using BusinessData.ofAccount.ofRepository;
using BusinessLogic.ofManager.ofAccount.ofBusinessUser.ofBlobStorage;
using BusinessLogic.ofManager.ofAccount.ofBusinessUser.ofFileFactory;
using BusinessLogic.ofManager.ofAccount.ofBusinessUser.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;
using System.Threading.Tasks;

namespace BusinessData.ofManager
{
    public class BusinessUserManager : EntityManager<BusinessUser>
    {
        private readonly BusinessUserRepository _BusinessUserRepository;
        private readonly BusinessUserIdFactory _BusinessUserIdFactory;
        private readonly BusinessUserBlobStorage _BusinessUserBlobStorage;
        private readonly BusinessUserFileFactory _BusinessUserFileFactory;
        public BusinessUserManager(BusinessUserRepository BusinessUserRepository,
                               BusinessUserIdFactory BusinessUserIdFactory,
                               BusinessUserFileFactory BusinessUserFileFactory,
                               BusinessUserBlobStorage BusinessUserBlobStorage,
                            DicConvertFactory<BusinessUser> dicConvertFactory)
            : base(BusinessUserRepository, BusinessUserIdFactory, BusinessUserFileFactory, BusinessUserBlobStorage, dicConvertFactory)
        {
            _BusinessUserRepository = BusinessUserRepository;
            _BusinessUserIdFactory = BusinessUserIdFactory;
            _BusinessUserBlobStorage = BusinessUserBlobStorage;
            _BusinessUserFileFactory = BusinessUserFileFactory;
        }
        public async Task<BusinessUser> GetByUserIdWithTableSetting(string UserId)
        {
            return await _BusinessUserRepository.GetByUserIdWithTableSetting(UserId);
        }
        public async Task<BusinessUser> CreateByUserIdAsync(string UserId)
        {
            BusinessUser businessUser = new();
            businessUser.UserId = UserId;
            return await base.CreateAsync(businessUser);
        }
    }
}
