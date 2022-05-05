using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeEmployeeRoleViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeEmployeeRole? _EmployeeEmployeeRole = new();
        public EmployeeEmployeeRole? EmployeeEmployeeRole
        {
            get => _EmployeeEmployeeRole;
            set
            {
                SetValue(ref _EmployeeEmployeeRole, value);
            }
        }
        public BaseEmployeeEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeEmployeeRole = await _EmployeeActorContext.GetByIdAsync<EmployeeEmployeeRole>(id);
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
        public PostEmployeeEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeEmployeeRole EmployeeEmployeeRole)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeEmployeeRole);
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
        public PutEmployeeEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeEmployeeRole EmployeeEmployeeRole)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeEmployeeRole);
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
        public DeleteEmployeeEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeEmployeeRole>(id);
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
        public GetsEmployeeEmployeeRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEmployeeRole>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeEmployeeRole>();
            if(dtos != null)
            {
                if(_EmployeeEmployeeRoles.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeEmployeeRole>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeEmployeeRole>(userid);
            if(dtos != null)
            {
                if(_EmployeeEmployeeRoles.Count > 0) {return;}
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
