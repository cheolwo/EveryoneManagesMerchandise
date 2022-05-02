using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BasePlatformEmployeeRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformEmployeeRole> _actorViewService;
        protected PlatformEmployeeRole? _PlatformEmployeeRole = new();
        public PlatformEmployeeRole? PlatformEmployeeRole
        {
            get => _PlatformEmployeeRole;
            set
            {
                SetValue(ref _PlatformEmployeeRole, value);
            }
        }
        public BasePlatformEmployeeRoleViewModel(IActorViewService<PlatformEmployeeRole> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformEmployeeRole = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformEmployeeRoleViewModel : BasePlatformEmployeeRoleViewModel
    {
        private bool _isPost = false;
        public bool IsPost
        {
            get => _isPost;
            set
            {
                _isPost = value;
                OnPropertyChanged();
            }
        }
        private PlatformEmployeeRole? _postPlatformEmployeeRole = new();
        public PlatformEmployeeRole? PostPlatformEmployeeRole
        {
            get => _postPlatformEmployeeRole;
            set
            {
                SetValue(ref _postPlatformEmployeeRole, value);
            }
        }
        public PostPlatformEmployeeRoleViewModel(IActorViewService<PlatformEmployeeRole> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformEmployeeRole PlatformEmployeeRole)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformEmployeeRole);
            if (PostValue != null)
            {
                PostPlatformEmployeeRole = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEmployeeRole = new();
            _postPlatformEmployeeRole = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEmployeeRoleViewModel : BasePlatformEmployeeRoleViewModel
    {
        private bool _isPut = false;
        public bool IsPut
        {
            get => _isPut;
            set
            {
                _isPut = value;
                OnPropertyChanged();
            }
        }
        private PlatformEmployeeRole? _putPlatformEmployeeRole = new();
        public PlatformEmployeeRole? PutPlatformEmployeeRole
        {
            get => _putPlatformEmployeeRole;
            set
            {
                SetValue(ref _putPlatformEmployeeRole, value);
            }
        }
        public PutPlatformEmployeeRoleViewModel(IActorViewService<PlatformEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformEmployeeRole PlatformEmployeeRole)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformEmployeeRole);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEmployeeRole = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEmployeeRole = new();
            _putPlatformEmployeeRole = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEmployeeRoleViewModel : BasePlatformEmployeeRoleViewModel
    {
        public DeletePlatformEmployeeRoleViewModel(IActorViewService<PlatformEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformEmployeeRole = new();
        }
    }
    public class GetsPlatformEmployeeRoleViewModel : BasePlatformEmployeeRoleViewModel
    {
        private List<PlatformEmployeeRole> _PlatformEmployeeRoles = new();
        public List<PlatformEmployeeRole> PlatformEmployeeRoles
        {
            get=> _PlatformEmployeeRoles;
            set
            {
                SetValue(ref _PlatformEmployeeRoles, value);   
            }
        }
        public GetsPlatformEmployeeRoleViewModel(IActorViewService<PlatformEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEmployeeRole>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformEmployeeRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEmployeeRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
