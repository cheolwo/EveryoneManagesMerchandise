using BusinessView.ofGeneric;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformETCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformETCommodity> _actorViewService;
        protected PlatformETCommodity? _PlatformETCommodity = new();
        public PlatformETCommodity? PlatformETCommodity
        {
            get => _PlatformETCommodity;
            set
            {
                SetValue(ref _PlatformETCommodity, value);
            }
        }
        public BasePlatformETCommodityViewModel(IActorViewService<PlatformETCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformETCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformETCommodityViewModel : BasePlatformETCommodityViewModel
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
        private PlatformETCommodity? _postPlatformETCommodity = new();
        public PlatformETCommodity? PostPlatformETCommodity
        {
            get => _postPlatformETCommodity;
            set
            {
                SetValue(ref _postPlatformETCommodity, value);
            }
        }
        public PostPlatformETCommodityViewModel(IActorViewService<PlatformETCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformETCommodity PlatformETCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformETCommodity);
            if (PostValue != null)
            {
                PostPlatformETCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformETCommodity = new();
            _postPlatformETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformETCommodityViewModel : BasePlatformETCommodityViewModel
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
        private PlatformETCommodity? _putPlatformETCommodity = new();
        public PlatformETCommodity? PutPlatformETCommodity
        {
            get => _putPlatformETCommodity;
            set
            {
                SetValue(ref _putPlatformETCommodity, value);
            }
        }
        public PutPlatformETCommodityViewModel(IActorViewService<PlatformETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformETCommodity PlatformETCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformETCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformETCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformETCommodity = new();
            _putPlatformETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformETCommodityViewModel : BasePlatformETCommodityViewModel
    {
        public DeletePlatformETCommodityViewModel(IActorViewService<PlatformETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformETCommodity = new();
        }
    }
    public class GetsPlatformETCommodityViewModel : BasePlatformETCommodityViewModel
    {
        private List<PlatformETCommodity> _PlatformETCommoditys = new();
        public List<PlatformETCommodity> PlatformETCommoditys
        {
            get=> _PlatformETCommoditys;
            set
            {
                SetValue(ref _PlatformETCommoditys, value);   
            }
        }
        public GetsPlatformETCommodityViewModel(IActorViewService<PlatformETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformETCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformETCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformETCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
