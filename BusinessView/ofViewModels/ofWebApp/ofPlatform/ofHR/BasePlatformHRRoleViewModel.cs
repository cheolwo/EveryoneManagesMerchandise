using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRRoleViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformHRRole? _PlatformHRRole = new();
        public PlatformHRRole? PlatformHRRole
        {
            get => _PlatformHRRole;
            set
            {
                SetValue(ref _PlatformHRRole, value);
            }
        }
        public BasePlatformHRRoleViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHRRole = await _PlatformActorContext.GetByIdAsync<PlatformHRRole>(id);
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
        public PostPlatformHRRoleViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformHRRole PlatformHRRole)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformHRRole>(PlatformHRRole);
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
        public PutPlatformHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformHRRole PlatformHRRole)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformHRRole>(PlatformHRRole);
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
        public DeletePlatformHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformHRRole>(id);
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
        public GetsPlatformHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHRRole>? dtos = await _PlatformActorContext.GetsAsync<PlatformHRRole>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformHRRole>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformHRRole>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformHRRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHRRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
