using System.Threading.Tasks;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;

namespace BusinessLogic.ofManager.ofGroupOrder
{
    public interface IGroupOrderCenterManager : ICenterManager<GroupOrderCenter>
    {
        Task<GroupOrderCenter> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> GroupOrderCenterLoginAsync(string LoginId, string Password);
    }
    public class GroupOrderCenterManager : CenterManager<GroupOrderCenter>, IGroupOrderCenterManager
    {
        private readonly IGroupOrderCenterRepository _GroupOrderCenterRepository;
        public GroupOrderCenterManager(IGroupOrderCenterRepository GroupOrderCenterRepository,
                               IGroupOrderCenterIdFactory GroupOrderCenterIdFactory,
                               IGroupOrderCenterFileFactory GroupOrderCenterFileFactory,
                               IGroupOrderCenterBlobStorage blobStorage,
                               CenterPasswordHasher<GroupOrderCenter> centerPasswordHasher,
                            DicConvertFactory<GroupOrderCenter> dicConvertFactory)
            : base(GroupOrderCenterRepository, GroupOrderCenterIdFactory, GroupOrderCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _GroupOrderCenterRepository = GroupOrderCenterRepository;
        }

        public async Task<bool> GroupOrderCenterLoginAsync(string LoginId, string Password)
        {
            GroupOrderCenter GroupOrderCenter = await base.LoginAsync(LoginId, Password);
            if(GroupOrderCenter != null)
            {
                return true;
            }
            else { return false; }
        }

        // Id로 Entity를 Load 하는 단계
        // Entity Password와 입력 Password를 비교하는 단계
        // 일치할 시 Entity를 반환하고 아닌 경우 예외처리하는 단계를 포함하는
        // CenterManager 로그인 메서드를 오버라이딩하여
        // Entity가 반환된 경우 관련 데이터를 같이 로드하는 것을 특징으로 하는 GroupOrderCenterManager 로그인 메서드
        public async Task<GroupOrderCenter> LoginWithDataAsync(string LoginId, string Password)
        {
            GroupOrderCenter GroupOrderCenter = await base.LoginAsync(LoginId, Password);
            GroupOrderCenter = await _GroupOrderCenterRepository.GetRelatedData(GroupOrderCenter); 
            return GroupOrderCenter;
        }
    }
}