using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformPCommodity> _actorViewService;
        protected PlatformPCommodity? _PlatformPCommodity = new();
        public PlatformPCommodity? PlatformPCommodity
        {
            get => _PlatformPCommodity;
            set
            {
                SetValue(ref _PlatformPCommodity, value);
            }
        }
        public BasePlatformPCommodityViewModel(IActorViewService<PlatformPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformPCommodityViewModel : BasePlatformPCommodityViewModel
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
        private PlatformPCommodity? _postPlatformPCommodity = new();
        public PlatformPCommodity? PostPlatformPCommodity
        {
            get => _postPlatformPCommodity;
            set
            {
                SetValue(ref _postPlatformPCommodity, value);
            }
        }
        public PostPlatformPCommodityViewModel(IActorViewService<PlatformPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformPCommodity PlatformPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformPCommodity);
            if (PostValue != null)
            {
                PostPlatformPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformPCommodity = new();
            _postPlatformPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformPCommodityViewModel : BasePlatformPCommodityViewModel
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
        private PlatformPCommodity? _putPlatformPCommodity = new();
        public PlatformPCommodity? PutPlatformPCommodity
        {
            get => _putPlatformPCommodity;
            set
            {
                SetValue(ref _putPlatformPCommodity, value);
            }
        }
        public PutPlatformPCommodityViewModel(IActorViewService<PlatformPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformPCommodity PlatformPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformPCommodity = new();
            _putPlatformPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformPCommodityViewModel : BasePlatformPCommodityViewModel
    {
        public DeletePlatformPCommodityViewModel(IActorViewService<PlatformPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformPCommodity = new();
        }
    }
    public class GetsPlatformPCommodityViewModel : BasePlatformPCommodityViewModel
    {
        private List<PlatformPCommodity> _PlatformPCommoditys = new();
        public List<PlatformPCommodity> PlatformPCommoditys
        {
            get=> _PlatformPCommoditys;
            set
            {
                SetValue(ref _PlatformPCommoditys, value);   
            }
        }
        public GetsPlatformPCommodityViewModel(IActorViewService<PlatformPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
