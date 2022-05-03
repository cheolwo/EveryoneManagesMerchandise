using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeePlatMarketViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeePlatMarket> _actorViewService;
        protected EmployeePlatMarket? _EmployeePlatMarket = new();
        public EmployeePlatMarket? EmployeePlatMarket
        {
            get => _EmployeePlatMarket;
            set
            {
                SetValue(ref _EmployeePlatMarket, value);
            }
        }
        public BaseEmployeePlatMarketViewModel(IActorViewService<EmployeePlatMarket> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeePlatMarket = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeePlatMarketViewModel : BaseEmployeePlatMarketViewModel
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
        private EmployeePlatMarket? _postEmployeePlatMarket = new();
        public EmployeePlatMarket? PostEmployeePlatMarket
        {
            get => _postEmployeePlatMarket;
            set
            {
                SetValue(ref _postEmployeePlatMarket, value);
            }
        }
        public PostEmployeePlatMarketViewModel(IActorViewService<EmployeePlatMarket> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeePlatMarket EmployeePlatMarket)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeePlatMarket);
            if (PostValue != null)
            {
                PostEmployeePlatMarket = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeePlatMarket = new();
            _postEmployeePlatMarket = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeePlatMarketViewModel : BaseEmployeePlatMarketViewModel
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
        private EmployeePlatMarket? _putEmployeePlatMarket = new();
        public EmployeePlatMarket? PutEmployeePlatMarket
        {
            get => _putEmployeePlatMarket;
            set
            {
                SetValue(ref _putEmployeePlatMarket, value);
            }
        }
        public PutEmployeePlatMarketViewModel(IActorViewService<EmployeePlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeePlatMarket EmployeePlatMarket)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeePlatMarket);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeePlatMarket = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeePlatMarket = new();
            _putEmployeePlatMarket = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeePlatMarketViewModel : BaseEmployeePlatMarketViewModel
    {
        public DeleteEmployeePlatMarketViewModel(IActorViewService<EmployeePlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeePlatMarket = new();
        }
    }
    public class GetsEmployeePlatMarketViewModel : BaseEmployeePlatMarketViewModel
    {
        private List<EmployeePlatMarket> _EmployeePlatMarkets = new();
        public List<EmployeePlatMarket> EmployeePlatMarkets
        {
            get=> _EmployeePlatMarkets;
            set
            {
                SetValue(ref _EmployeePlatMarkets, value);   
            }
        }
        public GetsEmployeePlatMarketViewModel(IActorViewService<EmployeePlatMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeePlatMarket>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeePlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeePlatMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeePlatMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
