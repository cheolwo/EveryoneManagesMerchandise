using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofPlatMarket
{
    public class BasePlatformPlatMarketViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformPlatMarket? _PlatformPlatMarket = new();
        public PlatformPlatMarket? PlatformPlatMarket
        {
            get => _PlatformPlatMarket;
            set
            {
                SetValue(ref _PlatformPlatMarket, value);
            }
        }
        public BasePlatformPlatMarketViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformPlatMarket = await _PlatformActorContext.GetByIdAsync<PlatformPlatMarket>(id);
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
        public PostPlatformPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformPlatMarket PlatformPlatMarket)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformPlatMarket>(PlatformPlatMarket);
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
        public PutPlatformPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformPlatMarket PlatformPlatMarket)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformPlatMarket>(PlatformPlatMarket);
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
        public DeletePlatformPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformPlatMarket>(id);
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
        public GetsPlatformPlatMarketViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformPlatMarket>? dtos = await _PlatformActorContext.GetsAsync<PlatformPlatMarket>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformPlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformPlatMarket>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformPlatMarket>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformPlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformPlatMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformPlatMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
