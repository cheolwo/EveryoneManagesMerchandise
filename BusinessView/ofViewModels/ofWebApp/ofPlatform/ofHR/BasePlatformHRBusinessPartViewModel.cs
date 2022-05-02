using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRBusinessPartViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformHRBusinessPart> _actorViewService;
        protected PlatformHRBusinessPart? _PlatformHRBusinessPart = new();
        public PlatformHRBusinessPart? PlatformHRBusinessPart
        {
            get => _PlatformHRBusinessPart;
            set
            {
                SetValue(ref _PlatformHRBusinessPart, value);
            }
        }
        public BasePlatformHRBusinessPartViewModel(IActorViewService<PlatformHRBusinessPart> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHRBusinessPart = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
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
        private PlatformHRBusinessPart? _postPlatformHRBusinessPart = new();
        public PlatformHRBusinessPart? PostPlatformHRBusinessPart
        {
            get => _postPlatformHRBusinessPart;
            set
            {
                SetValue(ref _postPlatformHRBusinessPart, value);
            }
        }
        public PostPlatformHRBusinessPartViewModel(IActorViewService<PlatformHRBusinessPart> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformHRBusinessPart PlatformHRBusinessPart)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformHRBusinessPart);
            if (PostValue != null)
            {
                PostPlatformHRBusinessPart = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformHRBusinessPart = new();
            _postPlatformHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
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
        private PlatformHRBusinessPart? _putPlatformHRBusinessPart = new();
        public PlatformHRBusinessPart? PutPlatformHRBusinessPart
        {
            get => _putPlatformHRBusinessPart;
            set
            {
                SetValue(ref _putPlatformHRBusinessPart, value);
            }
        }
        public PutPlatformHRBusinessPartViewModel(IActorViewService<PlatformHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformHRBusinessPart PlatformHRBusinessPart)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformHRBusinessPart);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformHRBusinessPart = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformHRBusinessPart = new();
            _putPlatformHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
    {
        public DeletePlatformHRBusinessPartViewModel(IActorViewService<PlatformHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformHRBusinessPart = new();
        }
    }
    public class GetsPlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
    {
        private List<PlatformHRBusinessPart> _PlatformHRBusinessParts = new();
        public List<PlatformHRBusinessPart> PlatformHRBusinessParts
        {
            get=> _PlatformHRBusinessParts;
            set
            {
                SetValue(ref _PlatformHRBusinessParts, value);   
            }
        }
        public GetsPlatformHRBusinessPartViewModel(IActorViewService<PlatformHRBusinessPart> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHRBusinessPart>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformHRBusinessParts.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHRBusinessParts.Remove(obj); OnPropertyChanged(); }
        }
    }
}
