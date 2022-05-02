using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BasePlatformHREmployeeViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformHREmployee> _actorViewService;
        protected PlatformHREmployee? _PlatformHREmployee = new();
        public PlatformHREmployee? PlatformHREmployee
        {
            get => _PlatformHREmployee;
            set
            {
                SetValue(ref _PlatformHREmployee, value);
            }
        }
        public BasePlatformHREmployeeViewModel(IActorViewService<PlatformHREmployee> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHREmployee = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformHREmployeeViewModel : BasePlatformHREmployeeViewModel
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
        private PlatformHREmployee? _postPlatformHREmployee = new();
        public PlatformHREmployee? PostPlatformHREmployee
        {
            get => _postPlatformHREmployee;
            set
            {
                SetValue(ref _postPlatformHREmployee, value);
            }
        }
        public PostPlatformHREmployeeViewModel(IActorViewService<PlatformHREmployee> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformHREmployee PlatformHREmployee)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformHREmployee);
            if (PostValue != null)
            {
                PostPlatformHREmployee = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformHREmployee = new();
            _postPlatformHREmployee = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformHREmployeeViewModel : BasePlatformHREmployeeViewModel
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
        private PlatformHREmployee? _putPlatformHREmployee = new();
        public PlatformHREmployee? PutPlatformHREmployee
        {
            get => _putPlatformHREmployee;
            set
            {
                SetValue(ref _putPlatformHREmployee, value);
            }
        }
        public PutPlatformHREmployeeViewModel(IActorViewService<PlatformHREmployee> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformHREmployee PlatformHREmployee)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformHREmployee);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformHREmployee = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformHREmployee = new();
            _putPlatformHREmployee = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformHREmployeeViewModel : BasePlatformHREmployeeViewModel
    {
        public DeletePlatformHREmployeeViewModel(IActorViewService<PlatformHREmployee> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformHREmployee = new();
        }
    }
    public class GetsPlatformHREmployeeViewModel : BasePlatformHREmployeeViewModel
    {
        private List<PlatformHREmployee> _PlatformHREmployees = new();
        public List<PlatformHREmployee> PlatformHREmployees
        {
            get=> _PlatformHREmployees;
            set
            {
                SetValue(ref _PlatformHREmployees, value);   
            }
        }
        public GetsPlatformHREmployeeViewModel(IActorViewService<PlatformHREmployee> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHREmployee>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformHREmployees.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHREmployees.Remove(obj); OnPropertyChanged(); }
        }
    }
}
