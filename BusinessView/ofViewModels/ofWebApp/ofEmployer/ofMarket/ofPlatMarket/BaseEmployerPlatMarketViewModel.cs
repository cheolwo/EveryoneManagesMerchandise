using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerPlatMarketViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerPlatMarket? _EmployerPlatMarket = new();
        public EmployerPlatMarket? EmployerPlatMarket
        {
            get => _EmployerPlatMarket;
            set
            {
                SetValue(ref _EmployerPlatMarket, value);
            }
        }
        public BaseEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerPlatMarket = await _EmployerActorContext.GetByIdAsync<EmployerPlatMarket>(id);
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
        public PostEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerPlatMarket EmployerPlatMarket)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerPlatMarket>(EmployerPlatMarket);
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
        public PutEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerPlatMarket EmployerPlatMarket)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerPlatMarket>(EmployerPlatMarket);
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
        public DeleteEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerPlatMarket>(id);
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
        public GetsEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerPlatMarket>? dtos = await _EmployerActorContext.GetsAsync<EmployerPlatMarket>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerPlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerPlatMarket>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerPlatMarket>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerPlatMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerPlatMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerPlatMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
