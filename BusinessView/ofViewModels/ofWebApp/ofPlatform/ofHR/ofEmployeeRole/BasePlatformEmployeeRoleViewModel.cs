using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformEmployeeRoleViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformEmployeeRole? _PlatformEmployeeRole = new();
        public PlatformEmployeeRole? PlatformEmployeeRole
        {
            get => _PlatformEmployeeRole;
            set
            {
                SetValue(ref _PlatformEmployeeRole, value);
            }
        }
        public BasePlatformEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformEmployeeRole = await _PlatformActorContext.GetByIdAsync<PlatformEmployeeRole>(id);
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
        public PostPlatformEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformEmployeeRole PlatformEmployeeRole)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformEmployeeRole>(PlatformEmployeeRole);
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
        public PutPlatformEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformEmployeeRole PlatformEmployeeRole)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformEmployeeRole>(PlatformEmployeeRole);
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
        public DeletePlatformEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformEmployeeRole>(id);
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
        public GetsPlatformEmployeeRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEmployeeRole>? dtos = await _PlatformActorContext.GetsAsync<PlatformEmployeeRole>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformEmployeeRole>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformEmployeeRole>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformEmployeeRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEmployeeRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
