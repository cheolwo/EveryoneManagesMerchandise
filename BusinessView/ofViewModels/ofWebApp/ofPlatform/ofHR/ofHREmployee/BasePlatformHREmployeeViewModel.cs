using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHREmployeeViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformHREmployee? _PlatformHREmployee = new();
        public PlatformHREmployee? PlatformHREmployee
        {
            get => _PlatformHREmployee;
            set
            {
                SetValue(ref _PlatformHREmployee, value);
            }
        }
        public BasePlatformHREmployeeViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHREmployee = await _PlatformActorContext.GetByIdAsync<PlatformHREmployee>(id);
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
        public PostPlatformHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformHREmployee PlatformHREmployee)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformHREmployee>(PlatformHREmployee);
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
        public PutPlatformHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformHREmployee PlatformHREmployee)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformHREmployee>(PlatformHREmployee);
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
        public DeletePlatformHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformHREmployee>(id);
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
        public GetsPlatformHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHREmployee>? dtos = await _PlatformActorContext.GetsAsync<PlatformHREmployee>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformHREmployee>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformHREmployee>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHREmployees.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformHREmployees.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHREmployees.Remove(obj); OnPropertyChanged(); }
        }
    }
}
