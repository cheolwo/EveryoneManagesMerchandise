using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformMTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMTCommodity> _actorViewService;
        protected PlatformMTCommodity? _PlatformMTCommodity = new();
        public PlatformMTCommodity? PlatformMTCommodity
        {
            get => _PlatformMTCommodity;
            set
            {
                SetValue(ref _PlatformMTCommodity, value);
            }
        }
        public BasePlatformMTCommodityViewModel(IActorViewService<PlatformMTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
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
        private PlatformMTCommodity? _postPlatformMTCommodity = new();
        public PlatformMTCommodity? PostPlatformMTCommodity
        {
            get => _postPlatformMTCommodity;
            set
            {
                SetValue(ref _postPlatformMTCommodity, value);
            }
        }
        public PostPlatformMTCommodityViewModel(IActorViewService<PlatformMTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMTCommodity PlatformMTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMTCommodity);
            if (PostValue != null)
            {
                PostPlatformMTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMTCommodity = new();
            _postPlatformMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
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
        private PlatformMTCommodity? _putPlatformMTCommodity = new();
        public PlatformMTCommodity? PutPlatformMTCommodity
        {
            get => _putPlatformMTCommodity;
            set
            {
                SetValue(ref _putPlatformMTCommodity, value);
            }
        }
        public PutPlatformMTCommodityViewModel(IActorViewService<PlatformMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMTCommodity PlatformMTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMTCommodity = new();
            _putPlatformMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
    {
        public DeletePlatformMTCommodityViewModel(IActorViewService<PlatformMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMTCommodity = new();
        }
    }
    public class GetsPlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
    {
        private List<PlatformMTCommodity> _PlatformMTCommoditys = new();
        public List<PlatformMTCommodity> PlatformMTCommoditys
        {
            get=> _PlatformMTCommoditys;
            set
            {
                SetValue(ref _PlatformMTCommoditys, value);   
            }
        }
        public GetsPlatformMTCommodityViewModel(IActorViewService<PlatformMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMTCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
