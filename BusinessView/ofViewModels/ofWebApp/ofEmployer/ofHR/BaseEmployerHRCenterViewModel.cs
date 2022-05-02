using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerHRCenter> _actorViewService;
        protected EmployerHRCenter? _EmployerHRCenter = new();
        public EmployerHRCenter? EmployerHRCenter
        {
            get => _EmployerHRCenter;
            set
            {
                SetValue(ref _EmployerHRCenter, value);
            }
        }
        public BaseEmployerHRCenterViewModel(IActorViewService<EmployerHRCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHRCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
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
        private EmployerHRCenter? _postEmployerHRCenter = new();
        public EmployerHRCenter? PostEmployerHRCenter
        {
            get => _postEmployerHRCenter;
            set
            {
                SetValue(ref _postEmployerHRCenter, value);
            }
        }
        public PostEmployerHRCenterViewModel(IActorViewService<EmployerHRCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerHRCenter EmployerHRCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerHRCenter);
            if (PostValue != null)
            {
                PostEmployerHRCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerHRCenter = new();
            _postEmployerHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
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
        private EmployerHRCenter? _putEmployerHRCenter = new();
        public EmployerHRCenter? PutEmployerHRCenter
        {
            get => _putEmployerHRCenter;
            set
            {
                SetValue(ref _putEmployerHRCenter, value);
            }
        }
        public PutEmployerHRCenterViewModel(IActorViewService<EmployerHRCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerHRCenter EmployerHRCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerHRCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerHRCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerHRCenter = new();
            _putEmployerHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
    {
        public DeleteEmployerHRCenterViewModel(IActorViewService<EmployerHRCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerHRCenter = new();
        }
    }
    public class GetsEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
    {
        private List<EmployerHRCenter> _EmployerHRCenters = new();
        public List<EmployerHRCenter> EmployerHRCenters
        {
            get=> _EmployerHRCenters;
            set
            {
                SetValue(ref _EmployerHRCenters, value);   
            }
        }
        public GetsEmployerHRCenterViewModel(IActorViewService<EmployerHRCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHRCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerHRCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHRCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
