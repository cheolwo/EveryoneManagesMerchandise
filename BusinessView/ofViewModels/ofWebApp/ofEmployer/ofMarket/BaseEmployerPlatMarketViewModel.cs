using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerPlatMarketViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerPlatMarket> _actorViewService;
        protected EmployerPlatMarket? _EmployerPlatMarket = new();
        public EmployerPlatMarket? EmployerPlatMarket
        {
            get => _EmployerPlatMarket;
            set
            {
                SetValue(ref _EmployerPlatMarket, value);
            }
        }
        public BaseEmployerPlatMarketViewModel(IActorViewService<EmployerPlatMarket> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerPlatMarket = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerPlatMarketViewModel : BaseEmployerPlatMarketViewModel
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
        private EmployerPlatMarket? _postEmployerPlatMarket = new();
        public EmployerPlatMarket? PostEmployerPlatMarket
        {
            get => _postEmployerPlatMarket;
            set
            {
                SetValue(ref _postEmployerPlatMarket, value);
            }
        }
        public PostEmployerPlatMarketViewModel(IActorViewService<EmployerPlatMarket> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerPlatMarket EmployerPlatMarket)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerPlatMarket);
            if (PostValue != null)
            {
                PostEmployerPlatMarket = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerPlatMarket = new();
            _postEmployerPlatMarket = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerPlatMarketViewModel : BaseEmployerPlatMarketViewModel
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
        private EmployerPlatMarket? _putEmployerPlatMarket = new();
        public EmployerPlatMarket? PutEmployerPlatMarket
        {
            get => _putEmployerPlatMarket;
            set
            {
                SetValue(ref _putEmployerPlatMarket, value);
            }
        }
        public PutEmployerPlatMarketViewModel(IActorViewService<EmployerPlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerPlatMarket EmployerPlatMarket)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerPlatMarket);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerPlatMarket = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerPlatMarket = new();
            _putEmployerPlatMarket = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerPlatMarketViewModel : BaseEmployerPlatMarketViewModel
    {
        public DeleteEmployerPlatMarketViewModel(IActorViewService<EmployerPlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerPlatMarket = new();
        }
    }
    public class GetsEmployerPlatMarketViewModel : BaseEmployerPlatMarketViewModel
    {
        private List<EmployerPlatMarket> _EmployerPlatMarkets = new();
        public List<EmployerPlatMarket> EmployerPlatMarkets
        {
            get=> _EmployerPlatMarkets;
            set
            {
                SetValue(ref _EmployerPlatMarkets, value);   
            }
        }
        public GetsEmployerPlatMarketViewModel(IActorViewService<EmployerPlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerPlatMarket>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerPlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerPlatMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerPlatMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
