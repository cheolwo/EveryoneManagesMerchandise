using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployeeHREmployeeViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeHREmployee> _actorViewService;
        protected EmployeeHREmployee? _EmployeeHREmployee = new();
        public EmployeeHREmployee? EmployeeHREmployee
        {
            get => _EmployeeHREmployee;
            set
            {
                SetValue(ref _EmployeeHREmployee, value);
            }
        }
        public BaseEmployeeHREmployeeViewModel(IActorViewService<EmployeeHREmployee> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeHREmployee = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployeeHREmployeeViewModel(IActorViewService<EmployeeHREmployee> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeHREmployee EmployeeHREmployee)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeHREmployee);
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
        public PutEmployeeHREmployeeViewModel(IActorViewService<EmployeeHREmployee> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeHREmployee EmployeeHREmployee)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeHREmployee);
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
        public DeleteEmployeeHREmployeeViewModel(IActorViewService<EmployeeHREmployee> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployeeHREmployeeViewModel(IActorViewService<EmployeeHREmployee> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHREmployee>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
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
