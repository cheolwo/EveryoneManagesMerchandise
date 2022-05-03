using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProductLandViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformProductLand> _actorViewService;
        protected PlatformProductLand? _PlatformProductLand = new();
        public PlatformProductLand? PlatformProductLand
        {
            get => _PlatformProductLand;
            set
            {
                SetValue(ref _PlatformProductLand, value);
            }
        }
        public BasePlatformProductLandViewModel(IActorViewService<PlatformProductLand> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformProductLand = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformProductLandViewModel : BasePlatformProductLandViewModel
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
        private PlatformProductLand? _postPlatformProductLand = new();
        public PlatformProductLand? PostPlatformProductLand
        {
            get => _postPlatformProductLand;
            set
            {
                SetValue(ref _postPlatformProductLand, value);
            }
        }
        public PostPlatformProductLandViewModel(IActorViewService<PlatformProductLand> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformProductLand PlatformProductLand)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformProductLand);
            if (PostValue != null)
            {
                PostPlatformProductLand = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformProductLand = new();
            _postPlatformProductLand = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformProductLandViewModel : BasePlatformProductLandViewModel
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
        private PlatformProductLand? _putPlatformProductLand = new();
        public PlatformProductLand? PutPlatformProductLand
        {
            get => _putPlatformProductLand;
            set
            {
                SetValue(ref _putPlatformProductLand, value);
            }
        }
        public PutPlatformProductLandViewModel(IActorViewService<PlatformProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformProductLand PlatformProductLand)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformProductLand);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformProductLand = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformProductLand = new();
            _putPlatformProductLand = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformProductLandViewModel : BasePlatformProductLandViewModel
    {
        public DeletePlatformProductLandViewModel(IActorViewService<PlatformProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformProductLand = new();
        }
    }
    public class GetsPlatformProductLandViewModel : BasePlatformProductLandViewModel
    {
        private List<PlatformProductLand> _PlatformProductLands = new();
        public List<PlatformProductLand> PlatformProductLands
        {
            get=> _PlatformProductLands;
            set
            {
                SetValue(ref _PlatformProductLands, value);   
            }
        }
        public GetsPlatformProductLandViewModel(IActorViewService<PlatformProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformProductLand>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformProductLands.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformProductLands.Remove(obj); OnPropertyChanged(); }
        }
    }
}
