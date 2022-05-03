using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployeeMarketViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMarket? _EmployeeMarket = new();
        public EmployeeMarket? EmployeeMarket
        {
            get => _EmployeeMarket;
            set
            {
                SetValue(ref _EmployeeMarket, value);
            }
        }
        public BaseEmployeeMarketViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMarket = await _EmployeeActorContext.GetByIdAsync<EmployeeMarket>(id);
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
        public PostEmployeeMarketViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMarket EmployeeMarket)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeMarket>(EmployeeMarket);
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
        public PutEmployeeMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMarket EmployeeMarket)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeMarket>(EmployeeMarket);
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
        public DeleteEmployeeMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMarket>(id);
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
        public GetsEmployeeMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMarket>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMarket>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMarket>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMarket>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
