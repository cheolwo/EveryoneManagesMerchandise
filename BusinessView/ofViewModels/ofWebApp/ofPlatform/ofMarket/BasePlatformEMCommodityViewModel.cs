using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformEMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformEMCommodity> _actorViewService;
        protected PlatformEMCommodity? _PlatformEMCommodity = new();
        public PlatformEMCommodity? PlatformEMCommodity
        {
            get => _PlatformEMCommodity;
            set
            {
                SetValue(ref _PlatformEMCommodity, value);
            }
        }
        public BasePlatformEMCommodityViewModel(IActorViewService<PlatformEMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformEMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
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
        private PlatformEMCommodity? _postPlatformEMCommodity = new();
        public PlatformEMCommodity? PostPlatformEMCommodity
        {
            get => _postPlatformEMCommodity;
            set
            {
                SetValue(ref _postPlatformEMCommodity, value);
            }
        }
        public PostPlatformEMCommodityViewModel(IActorViewService<PlatformEMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformEMCommodity PlatformEMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformEMCommodity);
            if (PostValue != null)
            {
                PostPlatformEMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEMCommodity = new();
            _postPlatformEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
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
        private PlatformEMCommodity? _putPlatformEMCommodity = new();
        public PlatformEMCommodity? PutPlatformEMCommodity
        {
            get => _putPlatformEMCommodity;
            set
            {
                SetValue(ref _putPlatformEMCommodity, value);
            }
        }
        public PutPlatformEMCommodityViewModel(IActorViewService<PlatformEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformEMCommodity PlatformEMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformEMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEMCommodity = new();
            _putPlatformEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
    {
        public DeletePlatformEMCommodityViewModel(IActorViewService<PlatformEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformEMCommodity = new();
        }
    }
    public class GetsPlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
    {
        private List<PlatformEMCommodity> _PlatformEMCommoditys = new();
        public List<PlatformEMCommodity> PlatformEMCommoditys
        {
            get=> _PlatformEMCommoditys;
            set
            {
                SetValue(ref _PlatformEMCommoditys, value);   
            }
        }
        public GetsPlatformEMCommodityViewModel(IActorViewService<PlatformEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformEMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
