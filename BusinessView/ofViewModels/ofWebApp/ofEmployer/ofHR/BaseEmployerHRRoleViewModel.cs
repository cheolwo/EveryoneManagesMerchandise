using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerHRRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerHRRole> _actorViewService;
        protected EmployerHRRole? _EmployerHRRole = new();
        public EmployerHRRole? EmployerHRRole
        {
            get => _EmployerHRRole;
            set
            {
                SetValue(ref _EmployerHRRole, value);
            }
        }
        public BaseEmployerHRRoleViewModel(IActorViewService<EmployerHRRole> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHRRole = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerHRRoleViewModel : BaseEmployerHRRoleViewModel
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
        private EmployerHRRole? _postEmployerHRRole = new();
        public EmployerHRRole? PostEmployerHRRole
        {
            get => _postEmployerHRRole;
            set
            {
                SetValue(ref _postEmployerHRRole, value);
            }
        }
        public PostEmployerHRRoleViewModel(IActorViewService<EmployerHRRole> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerHRRole EmployerHRRole)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerHRRole);
            if (PostValue != null)
            {
                PostEmployerHRRole = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerHRRole = new();
            _postEmployerHRRole = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerHRRoleViewModel : BaseEmployerHRRoleViewModel
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
        private EmployerHRRole? _putEmployerHRRole = new();
        public EmployerHRRole? PutEmployerHRRole
        {
            get => _putEmployerHRRole;
            set
            {
                SetValue(ref _putEmployerHRRole, value);
            }
        }
        public PutEmployerHRRoleViewModel(IActorViewService<EmployerHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerHRRole EmployerHRRole)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerHRRole);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerHRRole = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerHRRole = new();
            _putEmployerHRRole = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerHRRoleViewModel : BaseEmployerHRRoleViewModel
    {
        public DeleteEmployerHRRoleViewModel(IActorViewService<EmployerHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerHRRole = new();
        }
    }
    public class GetsEmployerHRRoleViewModel : BaseEmployerHRRoleViewModel
    {
        private List<EmployerHRRole> _EmployerHRRoles = new();
        public List<EmployerHRRole> EmployerHRRoles
        {
            get=> _EmployerHRRoles;
            set
            {
                SetValue(ref _EmployerHRRoles, value);   
            }
        }
        public GetsEmployerHRRoleViewModel(IActorViewService<EmployerHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHRRole>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerHRRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHRRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
