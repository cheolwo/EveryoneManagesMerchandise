using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformSWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformSWCommodity> _actorViewService;
        protected PlatformSWCommodity? _PlatformSWCommodity = new();
        public PlatformSWCommodity? PlatformSWCommodity
        {
            get => _PlatformSWCommodity;
            set
            {
                SetValue(ref _PlatformSWCommodity, value);
            }
        }
        public BasePlatformSWCommodityViewModel(IActorViewService<PlatformSWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformSWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
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
        private PlatformSWCommodity? _postPlatformSWCommodity = new();
        public PlatformSWCommodity? PostPlatformSWCommodity
        {
            get => _postPlatformSWCommodity;
            set
            {
                SetValue(ref _postPlatformSWCommodity, value);
            }
        }
        public PostPlatformSWCommodityViewModel(IActorViewService<PlatformSWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformSWCommodity PlatformSWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformSWCommodity);
            if (PostValue != null)
            {
                PostPlatformSWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSWCommodity = new();
            _postPlatformSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
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
        private PlatformSWCommodity? _putPlatformSWCommodity = new();
        public PlatformSWCommodity? PutPlatformSWCommodity
        {
            get => _putPlatformSWCommodity;
            set
            {
                SetValue(ref _putPlatformSWCommodity, value);
            }
        }
        public PutPlatformSWCommodityViewModel(IActorViewService<PlatformSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformSWCommodity PlatformSWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformSWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSWCommodity = new();
            _putPlatformSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
    {
        public DeletePlatformSWCommodityViewModel(IActorViewService<PlatformSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformSWCommodity = new();
        }
    }
    public class GetsPlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
    {
        private List<PlatformSWCommodity> _PlatformSWCommoditys = new();
        public List<PlatformSWCommodity> PlatformSWCommoditys
        {
            get=> _PlatformSWCommoditys;
            set
            {
                SetValue(ref _PlatformSWCommoditys, value);   
            }
        }
        public GetsPlatformSWCommodityViewModel(IActorViewService<PlatformSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSWCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformSWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
