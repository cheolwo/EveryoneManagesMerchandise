using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformMMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMMCommodity> _actorViewService;
        protected PlatformMMCommodity? _PlatformMMCommodity = new();
        public PlatformMMCommodity? PlatformMMCommodity
        {
            get => _PlatformMMCommodity;
            set
            {
                SetValue(ref _PlatformMMCommodity, value);
            }
        }
        public BasePlatformMMCommodityViewModel(IActorViewService<PlatformMMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformMMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
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
        private PlatformMMCommodity? _postPlatformMMCommodity = new();
        public PlatformMMCommodity? PostPlatformMMCommodity
        {
            get => _postPlatformMMCommodity;
            set
            {
                SetValue(ref _postPlatformMMCommodity, value);
            }
        }
        public PostPlatformMMCommodityViewModel(IActorViewService<PlatformMMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMMCommodity PlatformMMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMMCommodity);
            if (PostValue != null)
            {
                PostPlatformMMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMMCommodity = new();
            _postPlatformMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
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
        private PlatformMMCommodity? _putPlatformMMCommodity = new();
        public PlatformMMCommodity? PutPlatformMMCommodity
        {
            get => _putPlatformMMCommodity;
            set
            {
                SetValue(ref _putPlatformMMCommodity, value);
            }
        }
        public PutPlatformMMCommodityViewModel(IActorViewService<PlatformMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMMCommodity PlatformMMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMMCommodity = new();
            _putPlatformMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
    {
        public DeletePlatformMMCommodityViewModel(IActorViewService<PlatformMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMMCommodity = new();
        }
    }
    public class GetsPlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
    {
        private List<PlatformMMCommodity> _PlatformMMCommoditys = new();
        public List<PlatformMMCommodity> PlatformMMCommoditys
        {
            get=> _PlatformMMCommoditys;
            set
            {
                SetValue(ref _PlatformMMCommoditys, value);   
            }
        }
        public GetsPlatformMMCommodityViewModel(IActorViewService<PlatformMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
