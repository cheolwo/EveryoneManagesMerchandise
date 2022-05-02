using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformMPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMPCommodity> _actorViewService;
        protected PlatformMPCommodity? _PlatformMPCommodity = new();
        public PlatformMPCommodity? PlatformMPCommodity
        {
            get => _PlatformMPCommodity;
            set
            {
                SetValue(ref _PlatformMPCommodity, value);
            }
        }
        public BasePlatformMPCommodityViewModel(IActorViewService<PlatformMPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
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
        private PlatformMPCommodity? _postPlatformMPCommodity = new();
        public PlatformMPCommodity? PostPlatformMPCommodity
        {
            get => _postPlatformMPCommodity;
            set
            {
                SetValue(ref _postPlatformMPCommodity, value);
            }
        }
        public PostPlatformMPCommodityViewModel(IActorViewService<PlatformMPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMPCommodity PlatformMPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMPCommodity);
            if (PostValue != null)
            {
                PostPlatformMPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMPCommodity = new();
            _postPlatformMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
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
        private PlatformMPCommodity? _putPlatformMPCommodity = new();
        public PlatformMPCommodity? PutPlatformMPCommodity
        {
            get => _putPlatformMPCommodity;
            set
            {
                SetValue(ref _putPlatformMPCommodity, value);
            }
        }
        public PutPlatformMPCommodityViewModel(IActorViewService<PlatformMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMPCommodity PlatformMPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMPCommodity = new();
            _putPlatformMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
    {
        public DeletePlatformMPCommodityViewModel(IActorViewService<PlatformMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMPCommodity = new();
        }
    }
    public class GetsPlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
    {
        private List<PlatformMPCommodity> _PlatformMPCommoditys = new();
        public List<PlatformMPCommodity> PlatformMPCommoditys
        {
            get=> _PlatformMPCommoditys;
            set
            {
                SetValue(ref _PlatformMPCommoditys, value);   
            }
        }
        public GetsPlatformMPCommodityViewModel(IActorViewService<PlatformMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
