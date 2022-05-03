using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformSOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformSOCommodity> _actorViewService;
        protected PlatformSOCommodity? _PlatformSOCommodity = new();
        public PlatformSOCommodity? PlatformSOCommodity
        {
            get => _PlatformSOCommodity;
            set
            {
                SetValue(ref _PlatformSOCommodity, value);
            }
        }
        public BasePlatformSOCommodityViewModel(IActorViewService<PlatformSOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformSOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
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
        private PlatformSOCommodity? _postPlatformSOCommodity = new();
        public PlatformSOCommodity? PostPlatformSOCommodity
        {
            get => _postPlatformSOCommodity;
            set
            {
                SetValue(ref _postPlatformSOCommodity, value);
            }
        }
        public PostPlatformSOCommodityViewModel(IActorViewService<PlatformSOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformSOCommodity PlatformSOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformSOCommodity);
            if (PostValue != null)
            {
                PostPlatformSOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSOCommodity = new();
            _postPlatformSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
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
        private PlatformSOCommodity? _putPlatformSOCommodity = new();
        public PlatformSOCommodity? PutPlatformSOCommodity
        {
            get => _putPlatformSOCommodity;
            set
            {
                SetValue(ref _putPlatformSOCommodity, value);
            }
        }
        public PutPlatformSOCommodityViewModel(IActorViewService<PlatformSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformSOCommodity PlatformSOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformSOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSOCommodity = new();
            _putPlatformSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
    {
        public DeletePlatformSOCommodityViewModel(IActorViewService<PlatformSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformSOCommodity = new();
        }
    }
    public class GetsPlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
    {
        private List<PlatformSOCommodity> _PlatformSOCommoditys = new();
        public List<PlatformSOCommodity> PlatformSOCommoditys
        {
            get=> _PlatformSOCommoditys;
            set
            {
                SetValue(ref _PlatformSOCommoditys, value);   
            }
        }
        public GetsPlatformSOCommodityViewModel(IActorViewService<PlatformSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformSOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
