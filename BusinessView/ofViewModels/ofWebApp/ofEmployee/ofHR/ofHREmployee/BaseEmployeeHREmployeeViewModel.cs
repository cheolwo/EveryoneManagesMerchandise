using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHREmployeeViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeHREmployee? _EmployeeHREmployee = new();
        public EmployeeHREmployee? EmployeeHREmployee
        {
            get => _EmployeeHREmployee;
            set
            {
                SetValue(ref _EmployeeHREmployee, value);
            }
        }
        public BaseEmployeeHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeHREmployee = await _EmployeeActorContext.GetByIdAsync<EmployeeHREmployee>(id);
        }
    }
    public class PostEmployeeHREmployeeViewModel : BaseEmployeeHREmployeeViewModel
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
        private EmployeeHREmployee? _postEmployeeHREmployee = new();
        public EmployeeHREmployee? PostEmployeeHREmployee
        {
            get => _postEmployeeHREmployee;
            set
            {
                SetValue(ref _postEmployeeHREmployee, value);
            }
        }
        public PostEmployeeHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeHREmployee EmployeeHREmployee)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeHREmployee);
            if (PostValue != null)
            {
                PostEmployeeHREmployee = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeHREmployee = new();
            _postEmployeeHREmployee = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeHREmployeeViewModel : BaseEmployeeHREmployeeViewModel
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
        private EmployeeHREmployee? _putEmployeeHREmployee = new();
        public EmployeeHREmployee? PutEmployeeHREmployee
        {
            get => _putEmployeeHREmployee;
            set
            {
                SetValue(ref _putEmployeeHREmployee, value);
            }
        }
        public PutEmployeeHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeHREmployee EmployeeHREmployee)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeHREmployee);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeHREmployee = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeHREmployee = new();
            _putEmployeeHREmployee = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeHREmployeeViewModel : BaseEmployeeHREmployeeViewModel
    {
        public DeleteEmployeeHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeHREmployee>(id);
        }
        public void Reset()
        {
            EmployeeHREmployee = new();
        }
    }
    public class GetsEmployeeHREmployeeViewModel : BaseEmployeeHREmployeeViewModel
    {
        private List<EmployeeHREmployee> _EmployeeHREmployees = new();
        public List<EmployeeHREmployee> EmployeeHREmployees
        {
            get=> _EmployeeHREmployees;
            set
            {
                SetValue(ref _EmployeeHREmployees, value);   
            }
        }
        public GetsEmployeeHREmployeeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHREmployee>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeHREmployee>();
            if(dtos != null)
            {
                if(_EmployeeHREmployees.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeHREmployee>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeHREmployee>(userid);
            if(dtos != null)
            {
                if(_EmployeeHREmployees.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeHREmployees.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeHREmployees.Remove(obj); OnPropertyChanged(); }
        }
    }
}
