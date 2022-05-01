using BusinessView.ofGeneric;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformOrderCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformOrderCenter> _actorViewService;
        protected PlatformOrderCenter? _PlatformOrderCenter = new();
        public PlatformOrderCenter? PlatformOrderCenter
        {
            get => _PlatformOrderCenter;
            set
            {
                SetValue(ref _PlatformOrderCenter, value);
            }
        }
        public BasePlatformOrderCenterViewModel(IActorViewService<PlatformOrderCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformOrderCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
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
        private PlatformOrderCenter? _postPlatformOrderCenter = new();
        public PlatformOrderCenter? PostPlatformOrderCenter
        {
            get => _postPlatformOrderCenter;
            set
            {
                SetValue(ref _postPlatformOrderCenter, value);
            }
        }
        public PostPlatformOrderCenterViewModel(IActorViewService<PlatformOrderCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformOrderCenter PlatformOrderCenter)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformOrderCenter);
            if (PostValue != null)
            {
                PostPlatformOrderCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformOrderCenter = new();
            _postPlatformOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
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
        private PlatformOrderCenter? _putPlatformOrderCenter = new();
        public PlatformOrderCenter? PutPlatformOrderCenter
        {
            get => _putPlatformOrderCenter;
            set
            {
                SetValue(ref _putPlatformOrderCenter, value);
            }
        }
        public PutPlatformOrderCenterViewModel(IActorViewService<PlatformOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformOrderCenter PlatformOrderCenter)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformOrderCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformOrderCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformOrderCenter = new();
            _putPlatformOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
    {
        public DeletePlatformOrderCenterViewModel(IActorViewService<PlatformOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformOrderCenter = new();
        }
    }
    public class GetsPlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
    {
        private List<PlatformOrderCenter> _PlatformOrderCenters = new();
        public List<PlatformOrderCenter> PlatformOrderCenters
        {
            get=> _PlatformOrderCenters;
            set
            {
                SetValue(ref _PlatformOrderCenters, value);   
            }
        }
        public GetsPlatformOrderCenterViewModel(IActorViewService<PlatformOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformOrderCenter>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformOrderCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformOrderCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
