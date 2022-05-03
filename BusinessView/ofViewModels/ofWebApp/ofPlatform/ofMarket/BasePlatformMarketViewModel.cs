using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformMarketViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMarket> _actorViewService;
        protected PlatformMarket? _PlatformMarket = new();
        public PlatformMarket? PlatformMarket
        {
            get => _PlatformMarket;
            set
            {
                SetValue(ref _PlatformMarket, value);
            }
        }
        public BasePlatformMarketViewModel(IActorViewService<PlatformMarket> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMarket = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMarketViewModel : BasePlatformMarketViewModel
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
        private PlatformMarket? _postPlatformMarket = new();
        public PlatformMarket? PostPlatformMarket
        {
            get => _postPlatformMarket;
            set
            {
                SetValue(ref _postPlatformMarket, value);
            }
        }
        public PostPlatformMarketViewModel(IActorViewService<PlatformMarket> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMarket PlatformMarket)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMarket);
            if (PostValue != null)
            {
                PostPlatformMarket = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMarket = new();
            _postPlatformMarket = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMarketViewModel : BasePlatformMarketViewModel
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
        private PlatformMarket? _putPlatformMarket = new();
        public PlatformMarket? PutPlatformMarket
        {
            get => _putPlatformMarket;
            set
            {
                SetValue(ref _putPlatformMarket, value);
            }
        }
        public PutPlatformMarketViewModel(IActorViewService<PlatformMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMarket PlatformMarket)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMarket);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMarket = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMarket = new();
            _putPlatformMarket = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMarketViewModel : BasePlatformMarketViewModel
    {
        public DeletePlatformMarketViewModel(IActorViewService<PlatformMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMarket = new();
        }
    }
    public class GetsPlatformMarketViewModel : BasePlatformMarketViewModel
    {
        private List<PlatformMarket> _PlatformMarkets = new();
        public List<PlatformMarket> PlatformMarkets
        {
            get=> _PlatformMarkets;
            set
            {
                SetValue(ref _PlatformMarkets, value);   
            }
        }
        public GetsPlatformMarketViewModel(IActorViewService<PlatformMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMarket>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
