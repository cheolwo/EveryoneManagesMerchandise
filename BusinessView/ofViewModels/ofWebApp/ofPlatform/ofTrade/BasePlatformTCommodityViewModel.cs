using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformTCommodity> _actorViewService;
        protected PlatformTCommodity? _PlatformTCommodity = new();
        public PlatformTCommodity? PlatformTCommodity
        {
            get => _PlatformTCommodity;
            set
            {
                SetValue(ref _PlatformTCommodity, value);
            }
        }
        public BasePlatformTCommodityViewModel(IActorViewService<PlatformTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformTCommodityViewModel : BasePlatformTCommodityViewModel
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
        private PlatformTCommodity? _postPlatformTCommodity = new();
        public PlatformTCommodity? PostPlatformTCommodity
        {
            get => _postPlatformTCommodity;
            set
            {
                SetValue(ref _postPlatformTCommodity, value);
            }
        }
        public PostPlatformTCommodityViewModel(IActorViewService<PlatformTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformTCommodity PlatformTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformTCommodity);
            if (PostValue != null)
            {
                PostPlatformTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformTCommodity = new();
            _postPlatformTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformTCommodityViewModel : BasePlatformTCommodityViewModel
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
        private PlatformTCommodity? _putPlatformTCommodity = new();
        public PlatformTCommodity? PutPlatformTCommodity
        {
            get => _putPlatformTCommodity;
            set
            {
                SetValue(ref _putPlatformTCommodity, value);
            }
        }
        public PutPlatformTCommodityViewModel(IActorViewService<PlatformTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformTCommodity PlatformTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformTCommodity = new();
            _putPlatformTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformTCommodityViewModel : BasePlatformTCommodityViewModel
    {
        public DeletePlatformTCommodityViewModel(IActorViewService<PlatformTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformTCommodity = new();
        }
    }
    public class GetsPlatformTCommodityViewModel : BasePlatformTCommodityViewModel
    {
        private List<PlatformTCommodity> _PlatformTCommoditys = new();
        public List<PlatformTCommodity> PlatformTCommoditys
        {
            get=> _PlatformTCommoditys;
            set
            {
                SetValue(ref _PlatformTCommoditys, value);   
            }
        }
        public GetsPlatformTCommodityViewModel(IActorViewService<PlatformTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformTCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
