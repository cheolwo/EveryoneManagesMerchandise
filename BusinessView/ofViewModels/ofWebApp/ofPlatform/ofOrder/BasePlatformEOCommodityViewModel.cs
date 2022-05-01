using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformEOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformEOCommodity> _actorViewService;
        protected PlatformEOCommodity? _PlatformEOCommodity = new();
        public PlatformEOCommodity? PlatformEOCommodity
        {
            get => _PlatformEOCommodity;
            set
            {
                SetValue(ref _PlatformEOCommodity, value);
            }
        }
        public BasePlatformEOCommodityViewModel(IActorViewService<PlatformEOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformEOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
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
        private PlatformEOCommodity? _postPlatformEOCommodity = new();
        public PlatformEOCommodity? PostPlatformEOCommodity
        {
            get => _postPlatformEOCommodity;
            set
            {
                SetValue(ref _postPlatformEOCommodity, value);
            }
        }
        public PostPlatformEOCommodityViewModel(IActorViewService<PlatformEOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformEOCommodity PlatformEOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformEOCommodity);
            if (PostValue != null)
            {
                PostPlatformEOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEOCommodity = new();
            _postPlatformEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
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
        private PlatformEOCommodity? _putPlatformEOCommodity = new();
        public PlatformEOCommodity? PutPlatformEOCommodity
        {
            get => _putPlatformEOCommodity;
            set
            {
                SetValue(ref _putPlatformEOCommodity, value);
            }
        }
        public PutPlatformEOCommodityViewModel(IActorViewService<PlatformEOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformEOCommodity PlatformEOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformEOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEOCommodity = new();
            _putPlatformEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
    {
        public DeletePlatformEOCommodityViewModel(IActorViewService<PlatformEOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformEOCommodity = new();
        }
    }
    public class GetsPlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
    {
        private List<PlatformEOCommodity> _PlatformEOCommoditys = new();
        public List<PlatformEOCommodity> PlatformEOCommoditys
        {
            get=> _PlatformEOCommoditys;
            set
            {
                SetValue(ref _PlatformEOCommoditys, value);   
            }
        }
        public GetsPlatformEOCommodityViewModel(IActorViewService<PlatformEOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEOCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformEOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
