using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformSTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformSTCommodity> _actorViewService;
        protected PlatformSTCommodity? _PlatformSTCommodity = new();
        public PlatformSTCommodity? PlatformSTCommodity
        {
            get => _PlatformSTCommodity;
            set
            {
                SetValue(ref _PlatformSTCommodity, value);
            }
        }
        public BasePlatformSTCommodityViewModel(IActorViewService<PlatformSTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformSTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
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
        private PlatformSTCommodity? _postPlatformSTCommodity = new();
        public PlatformSTCommodity? PostPlatformSTCommodity
        {
            get => _postPlatformSTCommodity;
            set
            {
                SetValue(ref _postPlatformSTCommodity, value);
            }
        }
        public PostPlatformSTCommodityViewModel(IActorViewService<PlatformSTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformSTCommodity PlatformSTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformSTCommodity);
            if (PostValue != null)
            {
                PostPlatformSTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSTCommodity = new();
            _postPlatformSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
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
        private PlatformSTCommodity? _putPlatformSTCommodity = new();
        public PlatformSTCommodity? PutPlatformSTCommodity
        {
            get => _putPlatformSTCommodity;
            set
            {
                SetValue(ref _putPlatformSTCommodity, value);
            }
        }
        public PutPlatformSTCommodityViewModel(IActorViewService<PlatformSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformSTCommodity PlatformSTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformSTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSTCommodity = new();
            _putPlatformSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
    {
        public DeletePlatformSTCommodityViewModel(IActorViewService<PlatformSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformSTCommodity = new();
        }
    }
    public class GetsPlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
    {
        private List<PlatformSTCommodity> _PlatformSTCommoditys = new();
        public List<PlatformSTCommodity> PlatformSTCommoditys
        {
            get=> _PlatformSTCommoditys;
            set
            {
                SetValue(ref _PlatformSTCommoditys, value);   
            }
        }
        public GetsPlatformSTCommodityViewModel(IActorViewService<PlatformSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSTCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformSTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
