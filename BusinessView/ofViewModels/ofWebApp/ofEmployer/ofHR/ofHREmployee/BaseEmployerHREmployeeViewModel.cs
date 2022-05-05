using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHREmployeeViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerHREmployee? _EmployerHREmployee = new();
        public EmployerHREmployee? EmployerHREmployee
        {
            get => _EmployerHREmployee;
            set
            {
                SetValue(ref _EmployerHREmployee, value);
            }
        }
        public BaseEmployerHREmployeeViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHREmployee = await _EmployerActorContext.GetByIdAsync<EmployerHREmployee>(id);
        }
    }
    public class PostEmployerHREmployeeViewModel : BaseEmployerHREmployeeViewModel
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
        private EmployerHREmployee? _postEmployerHREmployee = new();
        public EmployerHREmployee? PostEmployerHREmployee
        {
            get => _postEmployerHREmployee;
            set
            {
                SetValue(ref _postEmployerHREmployee, value);
            }
        }
        public PostEmployerHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerHREmployee EmployerHREmployee)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerHREmployee>(EmployerHREmployee);
            if (PostValue != null)
            {
                PostEmployerHREmployee = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerHREmployee = new();
            _postEmployerHREmployee = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerHREmployeeViewModel : BaseEmployerHREmployeeViewModel
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
        private EmployerHREmployee? _putEmployerHREmployee = new();
        public EmployerHREmployee? PutEmployerHREmployee
        {
            get => _putEmployerHREmployee;
            set
            {
                SetValue(ref _putEmployerHREmployee, value);
            }
        }
        public PutEmployerHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerHREmployee EmployerHREmployee)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerHREmployee>(EmployerHREmployee);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerHREmployee = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerHREmployee = new();
            _putEmployerHREmployee = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerHREmployeeViewModel : BaseEmployerHREmployeeViewModel
    {
        public DeleteEmployerHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerHREmployee>(id);
        }
        public void Reset()
        {
            EmployerHREmployee = new();
        }
    }
    public class GetsEmployerHREmployeeViewModel : BaseEmployerHREmployeeViewModel
    {
        private List<EmployerHREmployee> _EmployerHREmployees = new();
        public List<EmployerHREmployee> EmployerHREmployees
        {
            get=> _EmployerHREmployees;
            set
            {
                SetValue(ref _EmployerHREmployees, value);   
            }
        }
        public GetsEmployerHREmployeeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHREmployee>? dtos = await _EmployerActorContext.GetsAsync<EmployerHREmployee>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerHREmployee>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerHREmployee>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerHREmployees.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHREmployees.Remove(obj); OnPropertyChanged(); }
        }
    }
}
