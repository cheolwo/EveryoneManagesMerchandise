using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BasePlatformHRRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformHRRole> _actorViewService;
        protected PlatformHRRole? _PlatformHRRole = new();
        public PlatformHRRole? PlatformHRRole
        {
            get => _PlatformHRRole;
            set
            {
                SetValue(ref _PlatformHRRole, value);
            }
        }
        public BasePlatformHRRoleViewModel(IActorViewService<PlatformHRRole> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHRRole = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformHRRoleViewModel : BasePlatformHRRoleViewModel
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
        private PlatformHRRole? _postPlatformHRRole = new();
        public PlatformHRRole? PostPlatformHRRole
        {
            get => _postPlatformHRRole;
            set
            {
                SetValue(ref _postPlatformHRRole, value);
            }
        }
        public PostPlatformHRRoleViewModel(IActorViewService<PlatformHRRole> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformHRRole PlatformHRRole)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformHRRole);
            if (PostValue != null)
            {
                PostPlatformHRRole = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformHRRole = new();
            _postPlatformHRRole = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformHRRoleViewModel : BasePlatformHRRoleViewModel
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
        private PlatformHRRole? _putPlatformHRRole = new();
        public PlatformHRRole? PutPlatformHRRole
        {
            get => _putPlatformHRRole;
            set
            {
                SetValue(ref _putPlatformHRRole, value);
            }
        }
        public PutPlatformHRRoleViewModel(IActorViewService<PlatformHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformHRRole PlatformHRRole)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformHRRole);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformHRRole = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformHRRole = new();
            _putPlatformHRRole = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformHRRoleViewModel : BasePlatformHRRoleViewModel
    {
        public DeletePlatformHRRoleViewModel(IActorViewService<PlatformHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformHRRole = new();
        }
    }
    public class GetsPlatformHRRoleViewModel : BasePlatformHRRoleViewModel
    {
        private List<PlatformHRRole> _PlatformHRRoles = new();
        public List<PlatformHRRole> PlatformHRRoles
        {
            get=> _PlatformHRRoles;
            set
            {
                SetValue(ref _PlatformHRRoles, value);   
            }
        }
        public GetsPlatformHRRoleViewModel(IActorViewService<PlatformHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHRRole>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformHRRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHRRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
