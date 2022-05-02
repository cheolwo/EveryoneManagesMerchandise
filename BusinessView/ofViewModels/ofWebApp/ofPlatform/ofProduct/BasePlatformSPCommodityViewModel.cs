using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformSPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformSPCommodity> _actorViewService;
        protected PlatformSPCommodity? _PlatformSPCommodity = new();
        public PlatformSPCommodity? PlatformSPCommodity
        {
            get => _PlatformSPCommodity;
            set
            {
                SetValue(ref _PlatformSPCommodity, value);
            }
        }
        public BasePlatformSPCommodityViewModel(IActorViewService<PlatformSPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformSPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
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
        private PlatformSPCommodity? _postPlatformSPCommodity = new();
        public PlatformSPCommodity? PostPlatformSPCommodity
        {
            get => _postPlatformSPCommodity;
            set
            {
                SetValue(ref _postPlatformSPCommodity, value);
            }
        }
        public PostPlatformSPCommodityViewModel(IActorViewService<PlatformSPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformSPCommodity PlatformSPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformSPCommodity);
            if (PostValue != null)
            {
                PostPlatformSPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSPCommodity = new();
            _postPlatformSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
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
        private PlatformSPCommodity? _putPlatformSPCommodity = new();
        public PlatformSPCommodity? PutPlatformSPCommodity
        {
            get => _putPlatformSPCommodity;
            set
            {
                SetValue(ref _putPlatformSPCommodity, value);
            }
        }
        public PutPlatformSPCommodityViewModel(IActorViewService<PlatformSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformSPCommodity PlatformSPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformSPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSPCommodity = new();
            _putPlatformSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
    {
        public DeletePlatformSPCommodityViewModel(IActorViewService<PlatformSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformSPCommodity = new();
        }
    }
    public class GetsPlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
    {
        private List<PlatformSPCommodity> _PlatformSPCommoditys = new();
        public List<PlatformSPCommodity> PlatformSPCommoditys
        {
            get=> _PlatformSPCommoditys;
            set
            {
                SetValue(ref _PlatformSPCommoditys, value);   
            }
        }
        public GetsPlatformSPCommodityViewModel(IActorViewService<PlatformSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformSPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
