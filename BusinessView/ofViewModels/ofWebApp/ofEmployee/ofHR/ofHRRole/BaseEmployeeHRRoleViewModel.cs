using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployeeHRRoleViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeHRRole? _EmployeeHRRole = new();
        public EmployeeHRRole? EmployeeHRRole
        {
            get => _EmployeeHRRole;
            set
            {
                SetValue(ref _EmployeeHRRole, value);
            }
        }
        public BaseEmployeeHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeHRRole = await _EmployeeActorContext.GetByIdAsync<EmployeeHRRole>(id);
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
        public PostEmployeeHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeHRRole EmployeeHRRole)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeHRRole>(EmployeeHRRole);
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
        public PutEmployeeHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeHRRole EmployeeHRRole)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeHRRole>(EmployeeHRRole);
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
        public DeleteEmployeeHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeHRRole>(id);
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
        public GetsEmployeeHRRoleViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHRRole>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeHRRole>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeHRRole>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeHRRole>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeHRRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeHRRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
