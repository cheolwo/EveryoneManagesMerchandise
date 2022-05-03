using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRRoleViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerHRRole? _EmployerHRRole = new();
        public EmployerHRRole? EmployerHRRole
        {
            get => _EmployerHRRole;
            set
            {
                SetValue(ref _EmployerHRRole, value);
            }
        }
        public BaseEmployerHRRoleViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHRRole = await _EmployerActorContext.GetByIdAsync<EmployerHRRole>(id);
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
        public PostEmployerHRRoleViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerHRRole EmployerHRRole)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerHRRole>(EmployerHRRole);
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
        public PutEmployerHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerHRRole EmployerHRRole)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerHRRole>(EmployerHRRole);
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
        public DeleteEmployerHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerHRRole>(id);
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
        public GetsEmployerHRRoleViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHRRole>? dtos = await _EmployerActorContext.GetsAsync<EmployerHRRole>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerHRRole>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerHRRole>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRRoles.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerHRRoles.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHRRoles.Remove(obj); OnPropertyChanged(); }
        }
    }
}
