using BusinessView.ofGeneric;
using BusinessView.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformSGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformSGOC> _actorViewService;
        protected PlatformSGOC? _PlatformSGOC = new();
        public PlatformSGOC? PlatformSGOC
        {
            get => _PlatformSGOC;
            set
            {
                SetValue(ref _PlatformSGOC, value);
            }
        }
        public BasePlatformSGOCViewModel(IActorViewService<PlatformSGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformSGOCViewModel : BasePlatformSGOCViewModel
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
        private PlatformSGOC? _postPlatformSGOC = new();
        public PlatformSGOC? PostPlatformSGOC
        {
            get => _postPlatformSGOC;
            set
            {
                SetValue(ref _postPlatformSGOC, value);
            }
        }
        public PostPlatformSGOCViewModel(IActorViewService<PlatformSGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformSGOC PlatformSGOC)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformSGOC);
            if (PostValue != null)
            {
                PostPlatformSGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSGOC = new();
            _postPlatformSGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSGOCViewModel : BasePlatformSGOCViewModel
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
        private PlatformSGOC? _putPlatformSGOC = new();
        public PlatformSGOC? PutPlatformSGOC
        {
            get => _putPlatformSGOC;
            set
            {
                SetValue(ref _putPlatformSGOC, value);
            }
        }
        public PutPlatformSGOCViewModel(IActorViewService<PlatformSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformSGOC PlatformSGOC)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformSGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSGOC = new();
            _putPlatformSGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSGOCViewModel : BasePlatformSGOCViewModel
    {
        public DeletePlatformSGOCViewModel(IActorViewService<PlatformSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformSGOC = new();
        }
    }
    public class GetsPlatformSGOCViewModel : BasePlatformSGOCViewModel
    {
        private List<PlatformSGOC> _PlatformSGOCs = new();
        public List<PlatformSGOC> PlatformSGOCs
        {
            get=> _PlatformSGOCs;
            set
            {
                SetValue(ref _PlatformSGOCs, value);   
            }
        }
        public GetsPlatformSGOCViewModel(IActorViewService<PlatformSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSGOC>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformSGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
