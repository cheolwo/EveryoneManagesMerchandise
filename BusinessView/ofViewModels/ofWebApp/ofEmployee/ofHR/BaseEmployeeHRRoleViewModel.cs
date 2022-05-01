using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployeeHRRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeHRRole> _actorViewService;
        protected EmployeeHRRole? _EmployeeHRRole = new();
        public EmployeeHRRole? EmployeeHRRole
        {
            get => _EmployeeHRRole;
            set
            {
                SetValue(ref _EmployeeHRRole, value);
            }
        }
        public BaseEmployeeHRRoleViewModel(IActorViewService<EmployeeHRRole> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeHRRole = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeHRRoleViewModel : BaseEmployeeHRRoleViewModel
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
        private EmployeeHRRole? _postEmployeeHRRole = new();
        public EmployeeHRRole? PostEmployeeHRRole
        {
            get => _postEmployeeHRRole;
            set
            {
                SetValue(ref _postEmployeeHRRole, value);
            }
        }
        public PostEmployeeHRRoleViewModel(IActorViewService<EmployeeHRRole> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeHRRole EmployeeHRRole)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeHRRole);
            if (PostValue != null)
            {
                PostEmployeeHRRole = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeHRRole = new();
            _postEmployeeHRRole = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeHRRoleViewModel : BaseEmployeeHRRoleViewModel
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
        private EmployeeHRRole? _putEmployeeHRRole = new();
        public EmployeeHRRole? PutEmployeeHRRole
        {
            get => _putEmployeeHRRole;
            set
            {
                SetValue(ref _putEmployeeHRRole, value);
            }
        }
        public PutEmployeeHRRoleViewModel(IActorViewService<EmployeeHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeHRRole EmployeeHRRole)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeHRRole);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeHRRole = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeHRRole = new();
            _putEmployeeHRRole = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeHRRoleViewModel : BaseEmployeeHRRoleViewModel
    {
        public DeleteEmployeeHRRoleViewModel(IActorViewService<EmployeeHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeHRRole = new();
        }
    }
    public class GetsEmployeeHRRoleViewModel : BaseEmployeeHRRoleViewModel
    {
        private List<EmployeeHRRole> _EmployeeHRRoles = new();
        public List<EmployeeHRRole> EmployeeHRRoles
        {
            get=> _EmployeeHRRoles;
            set
            {
                SetValue(ref _EmployeeHRRoles, value);   
            }
        }
        public GetsEmployeeHRRoleViewModel(IActorViewService<EmployeeHRRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHRRole>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeHRRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeHRRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
