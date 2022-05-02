using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformEPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformEPCommodity> _actorViewService;
        protected PlatformEPCommodity? _PlatformEPCommodity = new();
        public PlatformEPCommodity? PlatformEPCommodity
        {
            get => _PlatformEPCommodity;
            set
            {
                SetValue(ref _PlatformEPCommodity, value);
            }
        }
        public BasePlatformEPCommodityViewModel(IActorViewService<PlatformEPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformEPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
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
        private PlatformEPCommodity? _postPlatformEPCommodity = new();
        public PlatformEPCommodity? PostPlatformEPCommodity
        {
            get => _postPlatformEPCommodity;
            set
            {
                SetValue(ref _postPlatformEPCommodity, value);
            }
        }
        public PostPlatformEPCommodityViewModel(IActorViewService<PlatformEPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformEPCommodity PlatformEPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformEPCommodity);
            if (PostValue != null)
            {
                PostPlatformEPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEPCommodity = new();
            _postPlatformEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
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
        private PlatformEPCommodity? _putPlatformEPCommodity = new();
        public PlatformEPCommodity? PutPlatformEPCommodity
        {
            get => _putPlatformEPCommodity;
            set
            {
                SetValue(ref _putPlatformEPCommodity, value);
            }
        }
        public PutPlatformEPCommodityViewModel(IActorViewService<PlatformEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformEPCommodity PlatformEPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformEPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEPCommodity = new();
            _putPlatformEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
    {
        public DeletePlatformEPCommodityViewModel(IActorViewService<PlatformEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformEPCommodity = new();
        }
    }
    public class GetsPlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
    {
        private List<PlatformEPCommodity> _PlatformEPCommoditys = new();
        public List<PlatformEPCommodity> PlatformEPCommoditys
        {
            get=> _PlatformEPCommoditys;
            set
            {
                SetValue(ref _PlatformEPCommoditys, value);   
            }
        }
        public GetsPlatformEPCommodityViewModel(IActorViewService<PlatformEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformEPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
