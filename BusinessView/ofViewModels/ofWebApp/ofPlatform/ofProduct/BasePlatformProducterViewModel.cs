using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformProducterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformProducter> _actorViewService;
        protected PlatformProducter? _PlatformProducter = new();
        public PlatformProducter? PlatformProducter
        {
            get => _PlatformProducter;
            set
            {
                SetValue(ref _PlatformProducter, value);
            }
        }
        public BasePlatformProducterViewModel(IActorViewService<PlatformProducter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformProducter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformProducterViewModel : BasePlatformProducterViewModel
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
        private PlatformProducter? _postPlatformProducter = new();
        public PlatformProducter? PostPlatformProducter
        {
            get => _postPlatformProducter;
            set
            {
                SetValue(ref _postPlatformProducter, value);
            }
        }
        public PostPlatformProducterViewModel(IActorViewService<PlatformProducter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformProducter PlatformProducter)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformProducter);
            if (PostValue != null)
            {
                PostPlatformProducter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformProducter = new();
            _postPlatformProducter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformProducterViewModel : BasePlatformProducterViewModel
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
        private PlatformProducter? _putPlatformProducter = new();
        public PlatformProducter? PutPlatformProducter
        {
            get => _putPlatformProducter;
            set
            {
                SetValue(ref _putPlatformProducter, value);
            }
        }
        public PutPlatformProducterViewModel(IActorViewService<PlatformProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformProducter PlatformProducter)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformProducter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformProducter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformProducter = new();
            _putPlatformProducter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformProducterViewModel : BasePlatformProducterViewModel
    {
        public DeletePlatformProducterViewModel(IActorViewService<PlatformProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformProducter = new();
        }
    }
    public class GetsPlatformProducterViewModel : BasePlatformProducterViewModel
    {
        private List<PlatformProducter> _PlatformProducters = new();
        public List<PlatformProducter> PlatformProducters
        {
            get=> _PlatformProducters;
            set
            {
                SetValue(ref _PlatformProducters, value);   
            }
        }
        public GetsPlatformProducterViewModel(IActorViewService<PlatformProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformProducter>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformProducters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformProducters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
