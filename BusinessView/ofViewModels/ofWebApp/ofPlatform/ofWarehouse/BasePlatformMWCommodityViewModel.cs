using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformMWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMWCommodity> _actorViewService;
        protected PlatformMWCommodity? _PlatformMWCommodity = new();
        public PlatformMWCommodity? PlatformMWCommodity
        {
            get => _PlatformMWCommodity;
            set
            {
                SetValue(ref _PlatformMWCommodity, value);
            }
        }
        public BasePlatformMWCommodityViewModel(IActorViewService<PlatformMWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
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
        private PlatformMWCommodity? _postPlatformMWCommodity = new();
        public PlatformMWCommodity? PostPlatformMWCommodity
        {
            get => _postPlatformMWCommodity;
            set
            {
                SetValue(ref _postPlatformMWCommodity, value);
            }
        }
        public PostPlatformMWCommodityViewModel(IActorViewService<PlatformMWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMWCommodity PlatformMWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMWCommodity);
            if (PostValue != null)
            {
                PostPlatformMWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMWCommodity = new();
            _postPlatformMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
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
        private PlatformMWCommodity? _putPlatformMWCommodity = new();
        public PlatformMWCommodity? PutPlatformMWCommodity
        {
            get => _putPlatformMWCommodity;
            set
            {
                SetValue(ref _putPlatformMWCommodity, value);
            }
        }
        public PutPlatformMWCommodityViewModel(IActorViewService<PlatformMWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMWCommodity PlatformMWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMWCommodity = new();
            _putPlatformMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
    {
        public DeletePlatformMWCommodityViewModel(IActorViewService<PlatformMWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMWCommodity = new();
        }
    }
    public class GetsPlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
    {
        private List<PlatformMWCommodity> _PlatformMWCommoditys = new();
        public List<PlatformMWCommodity> PlatformMWCommoditys
        {
            get=> _PlatformMWCommoditys;
            set
            {
                SetValue(ref _PlatformMWCommoditys, value);   
            }
        }
        public GetsPlatformMWCommodityViewModel(IActorViewService<PlatformMWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
