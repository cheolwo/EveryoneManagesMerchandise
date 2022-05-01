using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployerEmployeeRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerEmployeeRole> _actorViewService;
        protected EmployerEmployeeRole? _EmployerEmployeeRole = new();
        public EmployerEmployeeRole? EmployerEmployeeRole
        {
            get => _EmployerEmployeeRole;
            set
            {
                SetValue(ref _EmployerEmployeeRole, value);
            }
        }
        public BaseEmployerEmployeeRoleViewModel(IActorViewService<EmployerEmployeeRole> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerEmployeeRole = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerEmployeeRoleViewModel : BaseEmployerEmployeeRoleViewModel
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
        private EmployerEmployeeRole? _postEmployerEmployeeRole = new();
        public EmployerEmployeeRole? PostEmployerEmployeeRole
        {
            get => _postEmployerEmployeeRole;
            set
            {
                SetValue(ref _postEmployerEmployeeRole, value);
            }
        }
        public PostEmployerEmployeeRoleViewModel(IActorViewService<EmployerEmployeeRole> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerEmployeeRole EmployerEmployeeRole)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerEmployeeRole);
            if (PostValue != null)
            {
                PostEmployerEmployeeRole = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEmployeeRole = new();
            _postEmployerEmployeeRole = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEmployeeRoleViewModel : BaseEmployerEmployeeRoleViewModel
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
        private EmployerEmployeeRole? _putEmployerEmployeeRole = new();
        public EmployerEmployeeRole? PutEmployerEmployeeRole
        {
            get => _putEmployerEmployeeRole;
            set
            {
                SetValue(ref _putEmployerEmployeeRole, value);
            }
        }
        public PutEmployerEmployeeRoleViewModel(IActorViewService<EmployerEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerEmployeeRole EmployerEmployeeRole)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerEmployeeRole);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEmployeeRole = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEmployeeRole = new();
            _putEmployerEmployeeRole = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEmployeeRoleViewModel : BaseEmployerEmployeeRoleViewModel
    {
        public DeleteEmployerEmployeeRoleViewModel(IActorViewService<EmployerEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerEmployeeRole = new();
        }
    }
    public class GetsEmployerEmployeeRoleViewModel : BaseEmployerEmployeeRoleViewModel
    {
        private List<EmployerEmployeeRole> _EmployerEmployeeRoles = new();
        public List<EmployerEmployeeRole> EmployerEmployeeRoles
        {
            get=> _EmployerEmployeeRoles;
            set
            {
                SetValue(ref _EmployerEmployeeRoles, value);   
            }
        }
        public GetsEmployerEmployeeRoleViewModel(IActorViewService<EmployerEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEmployeeRole>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerEmployeeRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEmployeeRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
