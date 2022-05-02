using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformHRCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformHRCenter> _actorViewService;
        protected PlatformHRCenter? _PlatformHRCenter = new();
        public PlatformHRCenter? PlatformHRCenter
        {
            get => _PlatformHRCenter;
            set
            {
                SetValue(ref _PlatformHRCenter, value);
            }
        }
        public BasePlatformHRCenterViewModel(IActorViewService<PlatformHRCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHRCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformHRCenterViewModel : BasePlatformHRCenterViewModel
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
        private PlatformHRCenter? _postPlatformHRCenter = new();
        public PlatformHRCenter? PostPlatformHRCenter
        {
            get => _postPlatformHRCenter;
            set
            {
                SetValue(ref _postPlatformHRCenter, value);
            }
        }
        public PostPlatformHRCenterViewModel(IActorViewService<PlatformHRCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformHRCenter PlatformHRCenter)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformHRCenter);
            if (PostValue != null)
            {
                PostPlatformHRCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformHRCenter = new();
            _postPlatformHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformHRCenterViewModel : BasePlatformHRCenterViewModel
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
        private PlatformHRCenter? _putPlatformHRCenter = new();
        public PlatformHRCenter? PutPlatformHRCenter
        {
            get => _putPlatformHRCenter;
            set
            {
                SetValue(ref _putPlatformHRCenter, value);
            }
        }
        public PutPlatformHRCenterViewModel(IActorViewService<PlatformHRCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformHRCenter PlatformHRCenter)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformHRCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformHRCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformHRCenter = new();
            _putPlatformHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformHRCenterViewModel : BasePlatformHRCenterViewModel
    {
        public DeletePlatformHRCenterViewModel(IActorViewService<PlatformHRCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformHRCenter = new();
        }
    }
    public class GetsPlatformHRCenterViewModel : BasePlatformHRCenterViewModel
    {
        private List<PlatformHRCenter> _PlatformHRCenters = new();
        public List<PlatformHRCenter> PlatformHRCenters
        {
            get=> _PlatformHRCenters;
            set
            {
                SetValue(ref _PlatformHRCenters, value);   
            }
        }
        public GetsPlatformHRCenterViewModel(IActorViewService<PlatformHRCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHRCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformHRCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHRCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
