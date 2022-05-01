using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformTradeCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformTradeCenter> _actorViewService;
        protected PlatformTradeCenter? _PlatformTradeCenter = new();
        public PlatformTradeCenter? PlatformTradeCenter
        {
            get => _PlatformTradeCenter;
            set
            {
                SetValue(ref _PlatformTradeCenter, value);
            }
        }
        public BasePlatformTradeCenterViewModel(IActorViewService<PlatformTradeCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformTradeCenter = await _actorViewService.GetByIdAsync(id);
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
            get => _postPlatformTradeCenter;
            set
            {
                SetValue(ref _postPlatformTradeCenter, value);
            }
        }
        public PostPlatformTradeCenterViewModel(IActorViewService<PlatformTradeCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformTradeCenter PlatformTradeCenter)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformTradeCenter);
            if (PostValue != null)
            {
                PostPlatformTradeCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformTradeCenter = new();
            _postPlatformTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
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
        private PlatformTradeCenter? _putPlatformTradeCenter = new();
        public PlatformTradeCenter? PutPlatformTradeCenter
        {
            get => _putPlatformTradeCenter;
            set
            {
                SetValue(ref _putPlatformTradeCenter, value);
            }
        }
        public PutPlatformTradeCenterViewModel(IActorViewService<PlatformTradeCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformTradeCenter PlatformTradeCenter)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformTradeCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformTradeCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformTradeCenter = new();
            _putPlatformTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
    {
        public DeletePlatformTradeCenterViewModel(IActorViewService<PlatformTradeCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformTradeCenter = new();
        }
    }
    public class GetsPlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
    {
        private List<PlatformTradeCenter> _PlatformTradeCenters = new();
        public List<PlatformTradeCenter> PlatformTradeCenters
        {
            get=> _PlatformTradeCenters;
            set
            {
                SetValue(ref _PlatformTradeCenters, value);   
            }
        }
        public GetsPlatformTradeCenterViewModel(IActorViewService<PlatformTradeCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformTradeCenter>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformTradeCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformTradeCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
