using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformOCommodity> _actorViewService;
        protected PlatformOCommodity? _PlatformOCommodity = new();
        public PlatformOCommodity? PlatformOCommodity
        {
            get => _PlatformOCommodity;
            set
            {
                SetValue(ref _PlatformOCommodity, value);
            }
        }
        public BasePlatformOCommodityViewModel(IActorViewService<PlatformOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformOCommodityViewModel : BasePlatformOCommodityViewModel
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
        private PlatformOCommodity? _postPlatformOCommodity = new();
        public PlatformOCommodity? PostPlatformOCommodity
        {
            get => _postPlatformOCommodity;
            set
            {
                SetValue(ref _postPlatformOCommodity, value);
            }
        }
        public PostPlatformOCommodityViewModel(IActorViewService<PlatformOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformOCommodity PlatformOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformOCommodity);
            if (PostValue != null)
            {
                PostPlatformOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformOCommodity = new();
            _postPlatformOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformOCommodityViewModel : BasePlatformOCommodityViewModel
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
        private PlatformOCommodity? _putPlatformOCommodity = new();
        public PlatformOCommodity? PutPlatformOCommodity
        {
            get => _putPlatformOCommodity;
            set
            {
                SetValue(ref _putPlatformOCommodity, value);
            }
        }
        public PutPlatformOCommodityViewModel(IActorViewService<PlatformOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformOCommodity PlatformOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformOCommodity = new();
            _putPlatformOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformOCommodityViewModel : BasePlatformOCommodityViewModel
    {
        public DeletePlatformOCommodityViewModel(IActorViewService<PlatformOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformOCommodity = new();
        }
    }
    public class GetsPlatformOCommodityViewModel : BasePlatformOCommodityViewModel
    {
        private List<PlatformOCommodity> _PlatformOCommoditys = new();
        public List<PlatformOCommodity> PlatformOCommoditys
        {
            get=> _PlatformOCommoditys;
            set
            {
                SetValue(ref _PlatformOCommoditys, value);   
            }
        }
        public GetsPlatformOCommodityViewModel(IActorViewService<PlatformOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
