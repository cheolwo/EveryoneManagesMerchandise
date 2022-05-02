using BusinessView.ofDTO.ofJournalDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformJCommodity> _actorViewService;
        protected PlatformJCommodity? _PlatformJCommodity = new();
        public PlatformJCommodity? PlatformJCommodity
        {
            get => _PlatformJCommodity;
            set
            {
                SetValue(ref _PlatformJCommodity, value);
            }
        }
        public BasePlatformJCommodityViewModel(IActorViewService<PlatformJCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformJCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformJCommodityViewModel : BasePlatformJCommodityViewModel
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
        private PlatformJCommodity? _postPlatformJCommodity = new();
        public PlatformJCommodity? PostPlatformJCommodity
        {
            get => _postPlatformJCommodity;
            set
            {
                SetValue(ref _postPlatformJCommodity, value);
            }
        }
        public PostPlatformJCommodityViewModel(IActorViewService<PlatformJCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformJCommodity PlatformJCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformJCommodity);
            if (PostValue != null)
            {
                PostPlatformJCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformJCommodity = new();
            _postPlatformJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformJCommodityViewModel : BasePlatformJCommodityViewModel
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
        private PlatformJCommodity? _putPlatformJCommodity = new();
        public PlatformJCommodity? PutPlatformJCommodity
        {
            get => _putPlatformJCommodity;
            set
            {
                SetValue(ref _putPlatformJCommodity, value);
            }
        }
        public PutPlatformJCommodityViewModel(IActorViewService<PlatformJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformJCommodity PlatformJCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformJCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformJCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformJCommodity = new();
            _putPlatformJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformJCommodityViewModel : BasePlatformJCommodityViewModel
    {
        public DeletePlatformJCommodityViewModel(IActorViewService<PlatformJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformJCommodity = new();
        }
    }
    public class GetsPlatformJCommodityViewModel : BasePlatformJCommodityViewModel
    {
        private List<PlatformJCommodity> _PlatformJCommoditys = new();
        public List<PlatformJCommodity> PlatformJCommoditys
        {
            get=> _PlatformJCommoditys;
            set
            {
                SetValue(ref _PlatformJCommoditys, value);   
            }
        }
        public GetsPlatformJCommodityViewModel(IActorViewService<PlatformJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformJCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformJCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformJCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
