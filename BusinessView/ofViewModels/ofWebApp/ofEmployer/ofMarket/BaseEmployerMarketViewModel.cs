using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMarketViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMarket? _EmployerMarket = new();
        public EmployerMarket? EmployerMarket
        {
            get => _EmployerMarket;
            set
            {
                SetValue(ref _EmployerMarket, value);
            }
        }
        public BaseEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMarket = await _EmployerActorContext.GetByIdAsync<EmployerMarket>(id);
        }
    }
    public class PostEmployerMarketViewModel : BaseEmployerMarketViewModel
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
        private EmployerMarket? _postEmployerMarket = new();
        public EmployerMarket? PostEmployerMarket
        {
            get => _postEmployerMarket;
            set
            {
                SetValue(ref _postEmployerMarket, value);
            }
        }
        public PostEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMarket EmployerMarket)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMarket>(EmployerMarket);
            if (PostValue != null)
            {
                PostEmployerMarket = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMarket = new();
            _postEmployerMarket = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMarketViewModel : BaseEmployerMarketViewModel
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
        private EmployerMarket? _putEmployerMarket = new();
        public EmployerMarket? PutEmployerMarket
        {
            get => _putEmployerMarket;
            set
            {
                SetValue(ref _putEmployerMarket, value);
            }
        }
        public PutEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMarket EmployerMarket)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMarket>(EmployerMarket);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMarket = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMarket = new();
            _putEmployerMarket = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMarketViewModel : BaseEmployerMarketViewModel
    {
        public DeleteEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMarket>(id);
        }
        public void Reset()
        {
            EmployerMarket = new();
        }
    }
    public class GetsEmployerMarketViewModel : BaseEmployerMarketViewModel
    {
        private List<EmployerMarket> _EmployerMarkets = new();
        public List<EmployerMarket> EmployerMarkets
        {
            get=> _EmployerMarkets;
            set
            {
                SetValue(ref _EmployerMarkets, value);   
            }
        }
        public GetsEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMarket>? dtos = await _EmployerActorContext.GetsAsync<EmployerMarket>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMarket>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMarket>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMarkets.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMarkets.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMarkets.Remove(obj); OnPropertyChanged(); }
        }
    }
}
