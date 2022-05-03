using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformGOCCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformGOCC> _actorViewService;
        protected PlatformGOCC? _PlatformGOCC = new();
        public PlatformGOCC? PlatformGOCC
        {
            get => _PlatformGOCC;
            set
            {
                SetValue(ref _PlatformGOCC, value);
            }
        }
        public BasePlatformGOCCViewModel(IActorViewService<PlatformGOCC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformGOCC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformGOCCViewModel : BasePlatformGOCCViewModel
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
        private PlatformGOCC? _postPlatformGOCC = new();
        public PlatformGOCC? PostPlatformGOCC
        {
            get => _postPlatformGOCC;
            set
            {
                SetValue(ref _postPlatformGOCC, value);
            }
        }
        public PostPlatformGOCCViewModel(IActorViewService<PlatformGOCC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformGOCC PlatformGOCC)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformGOCC);
            if (PostValue != null)
            {
                PostPlatformGOCC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformGOCC = new();
            _postPlatformGOCC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformGOCCViewModel : BasePlatformGOCCViewModel
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
        private PlatformGOCC? _putPlatformGOCC = new();
        public PlatformGOCC? PutPlatformGOCC
        {
            get => _putPlatformGOCC;
            set
            {
                SetValue(ref _putPlatformGOCC, value);
            }
        }
        public PutPlatformGOCCViewModel(IActorViewService<PlatformGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformGOCC PlatformGOCC)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformGOCC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformGOCC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformGOCC = new();
            _putPlatformGOCC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformGOCCViewModel : BasePlatformGOCCViewModel
    {
        public DeletePlatformGOCCViewModel(IActorViewService<PlatformGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformGOCC = new();
        }
    }
    public class GetsPlatformGOCCViewModel : BasePlatformGOCCViewModel
    {
        private List<PlatformGOCC> _PlatformGOCCs = new();
        public List<PlatformGOCC> PlatformGOCCs
        {
            get=> _PlatformGOCCs;
            set
            {
                SetValue(ref _PlatformGOCCs, value);   
            }
        }
        public GetsPlatformGOCCViewModel(IActorViewService<PlatformGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformGOCC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformGOCCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformGOCCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
