using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformWCommodity> _actorViewService;
        protected PlatformWCommodity? _PlatformWCommodity = new();
        public PlatformWCommodity? PlatformWCommodity
        {
            get => _PlatformWCommodity;
            set
            {
                SetValue(ref _PlatformWCommodity, value);
            }
        }
        public BasePlatformWCommodityViewModel(IActorViewService<PlatformWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformWCommodityViewModel : BasePlatformWCommodityViewModel
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
        private PlatformWCommodity? _postPlatformWCommodity = new();
        public PlatformWCommodity? PostPlatformWCommodity
        {
            get => _postPlatformWCommodity;
            set
            {
                SetValue(ref _postPlatformWCommodity, value);
            }
        }
        public PostPlatformWCommodityViewModel(IActorViewService<PlatformWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformWCommodity PlatformWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformWCommodity);
            if (PostValue != null)
            {
                PostPlatformWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformWCommodity = new();
            _postPlatformWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformWCommodityViewModel : BasePlatformWCommodityViewModel
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
        private PlatformWCommodity? _putPlatformWCommodity = new();
        public PlatformWCommodity? PutPlatformWCommodity
        {
            get => _putPlatformWCommodity;
            set
            {
                SetValue(ref _putPlatformWCommodity, value);
            }
        }
        public PutPlatformWCommodityViewModel(IActorViewService<PlatformWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformWCommodity PlatformWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformWCommodity = new();
            _putPlatformWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformWCommodityViewModel : BasePlatformWCommodityViewModel
    {
        public DeletePlatformWCommodityViewModel(IActorViewService<PlatformWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformWCommodity = new();
        }
    }
    public class GetsPlatformWCommodityViewModel : BasePlatformWCommodityViewModel
    {
        private List<PlatformWCommodity> _PlatformWCommoditys = new();
        public List<PlatformWCommodity> PlatformWCommoditys
        {
            get=> _PlatformWCommoditys;
            set
            {
                SetValue(ref _PlatformWCommoditys, value);   
            }
        }
        public GetsPlatformWCommodityViewModel(IActorViewService<PlatformWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
