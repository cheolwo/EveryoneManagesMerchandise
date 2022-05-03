using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformEGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformEGOC> _actorViewService;
        protected PlatformEGOC? _PlatformEGOC = new();
        public PlatformEGOC? PlatformEGOC
        {
            get => _PlatformEGOC;
            set
            {
                SetValue(ref _PlatformEGOC, value);
            }
        }
        public BasePlatformEGOCViewModel(IActorViewService<PlatformEGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformEGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformEGOCViewModel : BasePlatformEGOCViewModel
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
        private PlatformEGOC? _postPlatformEGOC = new();
        public PlatformEGOC? PostPlatformEGOC
        {
            get => _postPlatformEGOC;
            set
            {
                SetValue(ref _postPlatformEGOC, value);
            }
        }
        public PostPlatformEGOCViewModel(IActorViewService<PlatformEGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformEGOC PlatformEGOC)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformEGOC);
            if (PostValue != null)
            {
                PostPlatformEGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEGOC = new();
            _postPlatformEGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEGOCViewModel : BasePlatformEGOCViewModel
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
        private PlatformEGOC? _putPlatformEGOC = new();
        public PlatformEGOC? PutPlatformEGOC
        {
            get => _putPlatformEGOC;
            set
            {
                SetValue(ref _putPlatformEGOC, value);
            }
        }
        public PutPlatformEGOCViewModel(IActorViewService<PlatformEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformEGOC PlatformEGOC)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformEGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEGOC = new();
            _putPlatformEGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEGOCViewModel : BasePlatformEGOCViewModel
    {
        public DeletePlatformEGOCViewModel(IActorViewService<PlatformEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformEGOC = new();
        }
    }
    public class GetsPlatformEGOCViewModel : BasePlatformEGOCViewModel
    {
        private List<PlatformEGOC> _PlatformEGOCs = new();
        public List<PlatformEGOC> PlatformEGOCs
        {
            get=> _PlatformEGOCs;
            set
            {
                SetValue(ref _PlatformEGOCs, value);   
            }
        }
        public GetsPlatformEGOCViewModel(IActorViewService<PlatformEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEGOC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformEGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
