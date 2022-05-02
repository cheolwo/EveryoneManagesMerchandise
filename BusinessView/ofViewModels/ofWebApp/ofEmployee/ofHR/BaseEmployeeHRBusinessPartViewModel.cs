using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHRBusinessPartViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeHRBusinessPart> _actorViewService;
        protected EmployeeHRBusinessPart? _EmployeeHRBusinessPart = new();
        public EmployeeHRBusinessPart? EmployeeHRBusinessPart
        {
            get => _EmployeeHRBusinessPart;
            set
            {
                SetValue(ref _EmployeeHRBusinessPart, value);
            }
        }
        public BaseEmployeeHRBusinessPartViewModel(IActorViewService<EmployeeHRBusinessPart> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeHRBusinessPart = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
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
        private EmployeeHRBusinessPart? _postEmployeeHRBusinessPart = new();
        public EmployeeHRBusinessPart? PostEmployeeHRBusinessPart
        {
            get => _postEmployeeHRBusinessPart;
            set
            {
                SetValue(ref _postEmployeeHRBusinessPart, value);
            }
        }
        public PostEmployeeHRBusinessPartViewModel(IActorViewService<EmployeeHRBusinessPart> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeHRBusinessPart EmployeeHRBusinessPart)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeHRBusinessPart);
            if (PostValue != null)
            {
                PostEmployeeHRBusinessPart = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeHRBusinessPart = new();
            _postEmployeeHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
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
        private EmployeeHRBusinessPart? _putEmployeeHRBusinessPart = new();
        public EmployeeHRBusinessPart? PutEmployeeHRBusinessPart
        {
            get => _putEmployeeHRBusinessPart;
            set
            {
                SetValue(ref _putEmployeeHRBusinessPart, value);
            }
        }
        public PutEmployeeHRBusinessPartViewModel(IActorViewService<EmployeeHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeHRBusinessPart EmployeeHRBusinessPart)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeHRBusinessPart);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeHRBusinessPart = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeHRBusinessPart = new();
            _putEmployeeHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
    {
        public DeleteEmployeeHRBusinessPartViewModel(IActorViewService<EmployeeHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeHRBusinessPart = new();
        }
    }
    public class GetsEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
    {
        private List<EmployeeHRBusinessPart> _EmployeeHRBusinessParts = new();
        public List<EmployeeHRBusinessPart> EmployeeHRBusinessParts
        {
            get=> _EmployeeHRBusinessParts;
            set
            {
                SetValue(ref _EmployeeHRBusinessParts, value);   
            }
        }
        public GetsEmployeeHRBusinessPartViewModel(IActorViewService<EmployeeHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHRBusinessPart>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeHRBusinessParts.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeHRBusinessParts.Remove(obj); OnPropertyChanged(); }
        }
    }
}
