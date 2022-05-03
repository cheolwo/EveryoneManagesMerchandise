using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerEmployeeRoleViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerEmployeeRole? _EmployerEmployeeRole = new();
        public EmployerEmployeeRole? EmployerEmployeeRole
        {
            get => _EmployerEmployeeRole;
            set
            {
                SetValue(ref _EmployerEmployeeRole, value);
            }
        }
        public BaseEmployerEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerEmployeeRole = await _EmployerActorContext.GetByIdAsync<EmployerEmployeeRole>(id);
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
        public PostEmployerEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerEmployeeRole EmployerEmployeeRole)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerEmployeeRole>(EmployerEmployeeRole);
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
        public PutEmployerEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerEmployeeRole EmployerEmployeeRole)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerEmployeeRole>(EmployerEmployeeRole);
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
        public DeleteEmployerEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerEmployeeRole>(id);
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
        public GetsEmployerEmployeeRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEmployeeRole>? dtos = await _EmployerActorContext.GetsAsync<EmployerEmployeeRole>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerEmployeeRole>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerEmployeeRole>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEmployeeRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerEmployeeRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEmployeeRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
