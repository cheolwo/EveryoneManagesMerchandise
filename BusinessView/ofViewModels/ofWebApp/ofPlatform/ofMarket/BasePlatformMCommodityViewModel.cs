using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMCommodity> _actorViewService;
        protected PlatformMCommodity? _PlatformMCommodity = new();
        public PlatformMCommodity? PlatformMCommodity
        {
            get => _PlatformMCommodity;
            set
            {
                SetValue(ref _PlatformMCommodity, value);
            }
        }
        public BasePlatformMCommodityViewModel(IActorViewService<PlatformMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMCommodityViewModel : BasePlatformMCommodityViewModel
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
        private PlatformMCommodity? _postPlatformMCommodity = new();
        public PlatformMCommodity? PostPlatformMCommodity
        {
            get => _postPlatformMCommodity;
            set
            {
                SetValue(ref _postPlatformMCommodity, value);
            }
        }
        public PostPlatformMCommodityViewModel(IActorViewService<PlatformMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMCommodity PlatformMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMCommodity);
            if (PostValue != null)
            {
                PostPlatformMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMCommodity = new();
            _postPlatformMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMCommodityViewModel : BasePlatformMCommodityViewModel
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
        private PlatformMCommodity? _putPlatformMCommodity = new();
        public PlatformMCommodity? PutPlatformMCommodity
        {
            get => _putPlatformMCommodity;
            set
            {
                SetValue(ref _putPlatformMCommodity, value);
            }
        }
        public PutPlatformMCommodityViewModel(IActorViewService<PlatformMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMCommodity PlatformMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMCommodity = new();
            _putPlatformMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMCommodityViewModel : BasePlatformMCommodityViewModel
    {
        public DeletePlatformMCommodityViewModel(IActorViewService<PlatformMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMCommodity = new();
        }
    }
    public class GetsPlatformMCommodityViewModel : BasePlatformMCommodityViewModel
    {
        private List<PlatformMCommodity> _PlatformMCommoditys = new();
        public List<PlatformMCommodity> PlatformMCommoditys
        {
            get=> _PlatformMCommoditys;
            set
            {
                SetValue(ref _PlatformMCommoditys, value);   
            }
        }
        public GetsPlatformMCommodityViewModel(IActorViewService<PlatformMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
