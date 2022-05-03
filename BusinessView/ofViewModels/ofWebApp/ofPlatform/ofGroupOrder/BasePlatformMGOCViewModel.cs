using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformMGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformMGOC> _actorViewService;
        protected PlatformMGOC? _PlatformMGOC = new();
        public PlatformMGOC? PlatformMGOC
        {
            get => _PlatformMGOC;
            set
            {
                SetValue(ref _PlatformMGOC, value);
            }
        }
        public BasePlatformMGOCViewModel(IActorViewService<PlatformMGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformMGOCViewModel : BasePlatformMGOCViewModel
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
        private PlatformMGOC? _postPlatformMGOC = new();
        public PlatformMGOC? PostPlatformMGOC
        {
            get => _postPlatformMGOC;
            set
            {
                SetValue(ref _postPlatformMGOC, value);
            }
        }
        public PostPlatformMGOCViewModel(IActorViewService<PlatformMGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformMGOC PlatformMGOC)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformMGOC);
            if (PostValue != null)
            {
                PostPlatformMGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMGOC = new();
            _postPlatformMGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMGOCViewModel : BasePlatformMGOCViewModel
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
        private PlatformMGOC? _putPlatformMGOC = new();
        public PlatformMGOC? PutPlatformMGOC
        {
            get => _putPlatformMGOC;
            set
            {
                SetValue(ref _putPlatformMGOC, value);
            }
        }
        public PutPlatformMGOCViewModel(IActorViewService<PlatformMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformMGOC PlatformMGOC)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformMGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMGOC = new();
            _putPlatformMGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMGOCViewModel : BasePlatformMGOCViewModel
    {
        public DeletePlatformMGOCViewModel(IActorViewService<PlatformMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformMGOC = new();
        }
    }
    public class GetsPlatformMGOCViewModel : BasePlatformMGOCViewModel
    {
        private List<PlatformMGOC> _PlatformMGOCs = new();
        public List<PlatformMGOC> PlatformMGOCs
        {
            get=> _PlatformMGOCs;
            set
            {
                SetValue(ref _PlatformMGOCs, value);   
            }
        }
        public GetsPlatformMGOCViewModel(IActorViewService<PlatformMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMGOC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformMGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
