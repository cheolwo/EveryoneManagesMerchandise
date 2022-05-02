using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerTradeCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerTradeCenter> _actorViewService;
        protected EmployerTradeCenter? _EmployerTradeCenter = new();
        public EmployerTradeCenter? EmployerTradeCenter
        {
            get => _EmployerTradeCenter;
            set
            {
                SetValue(ref _EmployerTradeCenter, value);
            }
        }
        public BaseEmployerTradeCenterViewModel(IActorViewService<EmployerTradeCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerTradeCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
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
        private EmployerTradeCenter? _postEmployerTradeCenter = new();
        public EmployerTradeCenter? PostEmployerTradeCenter
        {
            get => _postEmployerTradeCenter;
            set
            {
                SetValue(ref _postEmployerTradeCenter, value);
            }
        }
        public PostEmployerTradeCenterViewModel(IActorViewService<EmployerTradeCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerTradeCenter EmployerTradeCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerTradeCenter);
            if (PostValue != null)
            {
                PostEmployerTradeCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerTradeCenter = new();
            _postEmployerTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
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
        private EmployerTradeCenter? _putEmployerTradeCenter = new();
        public EmployerTradeCenter? PutEmployerTradeCenter
        {
            get => _putEmployerTradeCenter;
            set
            {
                SetValue(ref _putEmployerTradeCenter, value);
            }
        }
        public PutEmployerTradeCenterViewModel(IActorViewService<EmployerTradeCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerTradeCenter EmployerTradeCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerTradeCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerTradeCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerTradeCenter = new();
            _putEmployerTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
    {
        public DeleteEmployerTradeCenterViewModel(IActorViewService<EmployerTradeCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerTradeCenter = new();
        }
    }
    public class GetsEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
    {
        private List<EmployerTradeCenter> _EmployerTradeCenters = new();
        public List<EmployerTradeCenter> EmployerTradeCenters
        {
            get=> _EmployerTradeCenters;
            set
            {
                SetValue(ref _EmployerTradeCenters, value);   
            }
        }
        public GetsEmployerTradeCenterViewModel(IActorViewService<EmployerTradeCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerTradeCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerTradeCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerTradeCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
