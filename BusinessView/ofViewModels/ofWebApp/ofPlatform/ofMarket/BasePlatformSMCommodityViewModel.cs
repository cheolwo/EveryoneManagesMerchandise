using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformSMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformSMCommodity> _actorViewService;
        protected PlatformSMCommodity? _PlatformSMCommodity = new();
        public PlatformSMCommodity? PlatformSMCommodity
        {
            get => _PlatformSMCommodity;
            set
            {
                SetValue(ref _PlatformSMCommodity, value);
            }
        }
        public BasePlatformSMCommodityViewModel(IActorViewService<PlatformSMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformSMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
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
        private PlatformSMCommodity? _postPlatformSMCommodity = new();
        public PlatformSMCommodity? PostPlatformSMCommodity
        {
            get => _postPlatformSMCommodity;
            set
            {
                SetValue(ref _postPlatformSMCommodity, value);
            }
        }
        public PostPlatformSMCommodityViewModel(IActorViewService<PlatformSMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformSMCommodity PlatformSMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformSMCommodity);
            if (PostValue != null)
            {
                PostPlatformSMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSMCommodity = new();
            _postPlatformSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
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
        private PlatformSMCommodity? _putPlatformSMCommodity = new();
        public PlatformSMCommodity? PutPlatformSMCommodity
        {
            get => _putPlatformSMCommodity;
            set
            {
                SetValue(ref _putPlatformSMCommodity, value);
            }
        }
        public PutPlatformSMCommodityViewModel(IActorViewService<PlatformSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformSMCommodity PlatformSMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformSMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSMCommodity = new();
            _putPlatformSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
    {
        public DeletePlatformSMCommodityViewModel(IActorViewService<PlatformSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformSMCommodity = new();
        }
    }
    public class GetsPlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
    {
        private List<PlatformSMCommodity> _PlatformSMCommoditys = new();
        public List<PlatformSMCommodity> PlatformSMCommoditys
        {
            get=> _PlatformSMCommoditys;
            set
            {
                SetValue(ref _PlatformSMCommoditys, value);   
            }
        }
        public GetsPlatformSMCommodityViewModel(IActorViewService<PlatformSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformSMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
