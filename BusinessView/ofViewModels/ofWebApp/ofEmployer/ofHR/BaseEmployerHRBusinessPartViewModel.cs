using BusinessView.ofDTO.ofHRDTO.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerHRBusinessPartViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerHRBusinessPart> _actorViewService;
        protected EmployerHRBusinessPart? _EmployerHRBusinessPart = new();
        public EmployerHRBusinessPart? EmployerHRBusinessPart
        {
            get => _EmployerHRBusinessPart;
            set
            {
                SetValue(ref _EmployerHRBusinessPart, value);
            }
        }
        public BaseEmployerHRBusinessPartViewModel(IActorViewService<EmployerHRBusinessPart> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHRBusinessPart = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
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
        private EmployerHRBusinessPart? _postEmployerHRBusinessPart = new();
        public EmployerHRBusinessPart? PostEmployerHRBusinessPart
        {
            get => _postEmployerHRBusinessPart;
            set
            {
                SetValue(ref _postEmployerHRBusinessPart, value);
            }
        }
        public PostEmployerHRBusinessPartViewModel(IActorViewService<EmployerHRBusinessPart> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerHRBusinessPart EmployerHRBusinessPart)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerHRBusinessPart);
            if (PostValue != null)
            {
                PostEmployerHRBusinessPart = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerHRBusinessPart = new();
            _postEmployerHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
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
        private EmployerHRBusinessPart? _putEmployerHRBusinessPart = new();
        public EmployerHRBusinessPart? PutEmployerHRBusinessPart
        {
            get => _putEmployerHRBusinessPart;
            set
            {
                SetValue(ref _putEmployerHRBusinessPart, value);
            }
        }
        public PutEmployerHRBusinessPartViewModel(IActorViewService<EmployerHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerHRBusinessPart EmployerHRBusinessPart)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerHRBusinessPart);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerHRBusinessPart = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerHRBusinessPart = new();
            _putEmployerHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
    {
        public DeleteEmployerHRBusinessPartViewModel(IActorViewService<EmployerHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerHRBusinessPart = new();
        }
    }
    public class GetsEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
    {
        private List<EmployerHRBusinessPart> _EmployerHRBusinessParts = new();
        public List<EmployerHRBusinessPart> EmployerHRBusinessParts
        {
            get=> _EmployerHRBusinessParts;
            set
            {
                SetValue(ref _EmployerHRBusinessParts, value);   
            }
        }
        public GetsEmployerHRBusinessPartViewModel(IActorViewService<EmployerHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHRBusinessPart>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerHRBusinessParts.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHRBusinessParts.Remove(obj); OnPropertyChanged(); }
        }
    }
}
