using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformMOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMOCommodity> _actorViewService;
        protected PlatformMOCommodity? _PlatformMOCommodity = new();
        public PlatformMOCommodity? PlatformMOCommodity
        {
            get => _PlatformMOCommodity;
            set
            {
                SetValue(ref _PlatformMOCommodity, value);
            }
        }
        public BasePlatformMOCommodityViewModel(IActorViewService<PlatformMOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
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
        private PlatformMOCommodity? _postPlatformMOCommodity = new();
        public PlatformMOCommodity? PostPlatformMOCommodity
        {
            get => _postPlatformMOCommodity;
            set
            {
                SetValue(ref _postPlatformMOCommodity, value);
            }
        }
        public PostPlatformMOCommodityViewModel(IActorViewService<PlatformMOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMOCommodity PlatformMOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMOCommodity);
            if (PostValue != null)
            {
                PostPlatformMOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMOCommodity = new();
            _postPlatformMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
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
        private PlatformMOCommodity? _putPlatformMOCommodity = new();
        public PlatformMOCommodity? PutPlatformMOCommodity
        {
            get => _putPlatformMOCommodity;
            set
            {
                SetValue(ref _putPlatformMOCommodity, value);
            }
        }
        public PutPlatformMOCommodityViewModel(IActorViewService<PlatformMOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMOCommodity PlatformMOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMOCommodity = new();
            _putPlatformMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
    {
        public DeletePlatformMOCommodityViewModel(IActorViewService<PlatformMOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMOCommodity = new();
        }
    }
    public class GetsPlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
    {
        private List<PlatformMOCommodity> _PlatformMOCommoditys = new();
        public List<PlatformMOCommodity> PlatformMOCommoditys
        {
            get=> _PlatformMOCommoditys;
            set
            {
                SetValue(ref _PlatformMOCommoditys, value);   
            }
        }
        public GetsPlatformMOCommodityViewModel(IActorViewService<PlatformMOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMOCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
