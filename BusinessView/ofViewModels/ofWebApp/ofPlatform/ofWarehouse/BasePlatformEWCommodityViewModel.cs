using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformEWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformEWCommodity> _actorViewService;
        protected PlatformEWCommodity? _PlatformEWCommodity = new();
        public PlatformEWCommodity? PlatformEWCommodity
        {
            get => _PlatformEWCommodity;
            set
            {
                SetValue(ref _PlatformEWCommodity, value);
            }
        }
        public BasePlatformEWCommodityViewModel(IActorViewService<PlatformEWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformEWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
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
        private PlatformEWCommodity? _postPlatformEWCommodity = new();
        public PlatformEWCommodity? PostPlatformEWCommodity
        {
            get => _postPlatformEWCommodity;
            set
            {
                SetValue(ref _postPlatformEWCommodity, value);
            }
        }
        public PostPlatformEWCommodityViewModel(IActorViewService<PlatformEWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformEWCommodity PlatformEWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformEWCommodity);
            if (PostValue != null)
            {
                PostPlatformEWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEWCommodity = new();
            _postPlatformEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
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
        private PlatformEWCommodity? _putPlatformEWCommodity = new();
        public PlatformEWCommodity? PutPlatformEWCommodity
        {
            get => _putPlatformEWCommodity;
            set
            {
                SetValue(ref _putPlatformEWCommodity, value);
            }
        }
        public PutPlatformEWCommodityViewModel(IActorViewService<PlatformEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformEWCommodity PlatformEWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformEWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEWCommodity = new();
            _putPlatformEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
    {
        public DeletePlatformEWCommodityViewModel(IActorViewService<PlatformEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformEWCommodity = new();
        }
    }
    public class GetsPlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
    {
        private List<PlatformEWCommodity> _PlatformEWCommoditys = new();
        public List<PlatformEWCommodity> PlatformEWCommoditys
        {
            get=> _PlatformEWCommoditys;
            set
            {
                SetValue(ref _PlatformEWCommoditys, value);   
            }
        }
        public GetsPlatformEWCommodityViewModel(IActorViewService<PlatformEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformEWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
