using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformPlatMarketViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformPlatMarket> _actorViewService;
        protected PlatformPlatMarket? _PlatformPlatMarket = new();
        public PlatformPlatMarket? PlatformPlatMarket
        {
            get => _PlatformPlatMarket;
            set
            {
                SetValue(ref _PlatformPlatMarket, value);
            }
        }
        public BasePlatformPlatMarketViewModel(IActorViewService<PlatformPlatMarket> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformPlatMarket = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformPlatMarketViewModel : BasePlatformPlatMarketViewModel
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
        private PlatformPlatMarket? _postPlatformPlatMarket = new();
        public PlatformPlatMarket? PostPlatformPlatMarket
        {
            get => _postPlatformPlatMarket;
            set
            {
                SetValue(ref _postPlatformPlatMarket, value);
            }
        }
        public PostPlatformPlatMarketViewModel(IActorViewService<PlatformPlatMarket> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformPlatMarket PlatformPlatMarket)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformPlatMarket);
            if (PostValue != null)
            {
                PostPlatformPlatMarket = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformPlatMarket = new();
            _postPlatformPlatMarket = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformPlatMarketViewModel : BasePlatformPlatMarketViewModel
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
        private PlatformPlatMarket? _putPlatformPlatMarket = new();
        public PlatformPlatMarket? PutPlatformPlatMarket
        {
            get => _putPlatformPlatMarket;
            set
            {
                SetValue(ref _putPlatformPlatMarket, value);
            }
        }
        public PutPlatformPlatMarketViewModel(IActorViewService<PlatformPlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformPlatMarket PlatformPlatMarket)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformPlatMarket);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformPlatMarket = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformPlatMarket = new();
            _putPlatformPlatMarket = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformPlatMarketViewModel : BasePlatformPlatMarketViewModel
    {
        public DeletePlatformPlatMarketViewModel(IActorViewService<PlatformPlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformPlatMarket = new();
        }
    }
    public class GetsPlatformPlatMarketViewModel : BasePlatformPlatMarketViewModel
    {
        private List<PlatformPlatMarket> _PlatformPlatMarkets = new();
        public List<PlatformPlatMarket> PlatformPlatMarkets
        {
            get=> _PlatformPlatMarkets;
            set
            {
                SetValue(ref _PlatformPlatMarkets, value);   
            }
        }
        public GetsPlatformPlatMarketViewModel(IActorViewService<PlatformPlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformPlatMarket>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformPlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformPlatMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformPlatMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
