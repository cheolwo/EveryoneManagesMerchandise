using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMarketViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMarket> _actorViewService;
        protected EmployeeMarket? _EmployeeMarket = new();
        public EmployeeMarket? EmployeeMarket
        {
            get => _EmployeeMarket;
            set
            {
                SetValue(ref _EmployeeMarket, value);
            }
        }
        public BaseEmployeeMarketViewModel(IActorViewService<EmployeeMarket> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeMarket = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMarketViewModel : BaseEmployeeMarketViewModel
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
        private EmployeeMarket? _postEmployeeMarket = new();
        public EmployeeMarket? PostEmployeeMarket
        {
            get => _postEmployeeMarket;
            set
            {
                SetValue(ref _postEmployeeMarket, value);
            }
        }
        public PostEmployeeMarketViewModel(IActorViewService<EmployeeMarket> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMarket EmployeeMarket)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeMarket);
            if (PostValue != null)
            {
                PostEmployeeMarket = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMarket = new();
            _postEmployeeMarket = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMarketViewModel : BaseEmployeeMarketViewModel
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
        private EmployeeMarket? _putEmployeeMarket = new();
        public EmployeeMarket? PutEmployeeMarket
        {
            get => _putEmployeeMarket;
            set
            {
                SetValue(ref _putEmployeeMarket, value);
            }
        }
        public PutEmployeeMarketViewModel(IActorViewService<EmployeeMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMarket EmployeeMarket)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeMarket);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMarket = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMarket = new();
            _putEmployeeMarket = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMarketViewModel : BaseEmployeeMarketViewModel
    {
        public DeleteEmployeeMarketViewModel(IActorViewService<EmployeeMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMarket = new();
        }
    }
    public class GetsEmployeeMarketViewModel : BaseEmployeeMarketViewModel
    {
        private List<EmployeeMarket> _EmployeeMarkets = new();
        public List<EmployeeMarket> EmployeeMarkets
        {
            get=> _EmployeeMarkets;
            set
            {
                SetValue(ref _EmployeeMarkets, value);   
            }
        }
        public GetsEmployeeMarketViewModel(IActorViewService<EmployeeMarket> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMarket>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
