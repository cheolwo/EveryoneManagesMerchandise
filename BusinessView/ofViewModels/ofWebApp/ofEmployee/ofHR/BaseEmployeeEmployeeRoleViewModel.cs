using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeEmployeeRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeEmployeeRole> _actorViewService;
        protected EmployeeEmployeeRole? _EmployeeEmployeeRole = new();
        public EmployeeEmployeeRole? EmployeeEmployeeRole
        {
            get => _EmployeeEmployeeRole;
            set
            {
                SetValue(ref _EmployeeEmployeeRole, value);
            }
        }
        public BaseEmployeeEmployeeRoleViewModel(IActorViewService<EmployeeEmployeeRole> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeEmployeeRole = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeEmployeeRoleViewModel : BaseEmployeeEmployeeRoleViewModel
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
        private EmployeeEmployeeRole? _postEmployeeEmployeeRole = new();
        public EmployeeEmployeeRole? PostEmployeeEmployeeRole
        {
            get => _postEmployeeEmployeeRole;
            set
            {
                SetValue(ref _postEmployeeEmployeeRole, value);
            }
        }
        public PostEmployeeEmployeeRoleViewModel(IActorViewService<EmployeeEmployeeRole> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeEmployeeRole EmployeeEmployeeRole)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeEmployeeRole);
            if (PostValue != null)
            {
                PostEmployeeEmployeeRole = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEmployeeRole = new();
            _postEmployeeEmployeeRole = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEmployeeRoleViewModel : BaseEmployeeEmployeeRoleViewModel
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
        private EmployeeEmployeeRole? _putEmployeeEmployeeRole = new();
        public EmployeeEmployeeRole? PutEmployeeEmployeeRole
        {
            get => _putEmployeeEmployeeRole;
            set
            {
                SetValue(ref _putEmployeeEmployeeRole, value);
            }
        }
        public PutEmployeeEmployeeRoleViewModel(IActorViewService<EmployeeEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeEmployeeRole EmployeeEmployeeRole)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeEmployeeRole);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEmployeeRole = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEmployeeRole = new();
            _putEmployeeEmployeeRole = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEmployeeRoleViewModel : BaseEmployeeEmployeeRoleViewModel
    {
        public DeleteEmployeeEmployeeRoleViewModel(IActorViewService<EmployeeEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeEmployeeRole = new();
        }
    }
    public class GetsEmployeeEmployeeRoleViewModel : BaseEmployeeEmployeeRoleViewModel
    {
        private List<EmployeeEmployeeRole> _EmployeeEmployeeRoles = new();
        public List<EmployeeEmployeeRole> EmployeeEmployeeRoles
        {
            get=> _EmployeeEmployeeRoles;
            set
            {
                SetValue(ref _EmployeeEmployeeRoles, value);   
            }
        }
        public GetsEmployeeEmployeeRoleViewModel(IActorViewService<EmployeeEmployeeRole> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEmployeeRole>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeEmployeeRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEmployeeRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
