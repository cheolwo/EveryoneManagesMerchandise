using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeePlatMarketViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeePlatMarket? _EmployeePlatMarket = new();
        public EmployeePlatMarket? EmployeePlatMarket
        {
            get => _EmployeePlatMarket;
            set
            {
                SetValue(ref _EmployeePlatMarket, value);
            }
        }
        public BaseEmployeePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeePlatMarket = await _EmployeeActorContext.GetByIdAsync<EmployeePlatMarket>(id);
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
        public PostEmployeePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeePlatMarket EmployeePlatMarket)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeePlatMarket>(EmployeePlatMarket);
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
        public PutEmployeePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeePlatMarket EmployeePlatMarket)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeePlatMarket>(EmployeePlatMarket);
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
        public DeleteEmployeePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeePlatMarket>(id);
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
        public GetsEmployeePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeePlatMarket>? dtos = await _EmployeeActorContext.GetsAsync<EmployeePlatMarket>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeePlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeePlatMarket>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeePlatMarket>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeePlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeePlatMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeePlatMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
