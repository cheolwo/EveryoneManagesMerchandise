using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformDividedTagViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformDividedTag> _actorViewService;
        protected PlatformDividedTag? _PlatformDividedTag = new();
        public PlatformDividedTag? PlatformDividedTag
        {
            get => _PlatformDividedTag;
            set
            {
                SetValue(ref _PlatformDividedTag, value);
            }
        }
        public BasePlatformDividedTagViewModel(IActorViewService<PlatformDividedTag> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformDividedTag = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformDividedTagViewModel : BasePlatformDividedTagViewModel
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
        private PlatformDividedTag? _postPlatformDividedTag = new();
        public PlatformDividedTag? PostPlatformDividedTag
        {
            get => _postPlatformDividedTag;
            set
            {
                SetValue(ref _postPlatformDividedTag, value);
            }
        }
        public PostPlatformDividedTagViewModel(IActorViewService<PlatformDividedTag> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformDividedTag PlatformDividedTag)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformDividedTag);
            if (PostValue != null)
            {
                PostPlatformDividedTag = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformDividedTag = new();
            _postPlatformDividedTag = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformDividedTagViewModel : BasePlatformDividedTagViewModel
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
        private PlatformDividedTag? _putPlatformDividedTag = new();
        public PlatformDividedTag? PutPlatformDividedTag
        {
            get => _putPlatformDividedTag;
            set
            {
                SetValue(ref _putPlatformDividedTag, value);
            }
        }
        public PutPlatformDividedTagViewModel(IActorViewService<PlatformDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformDividedTag PlatformDividedTag)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformDividedTag);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformDividedTag = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformDividedTag = new();
            _putPlatformDividedTag = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformDividedTagViewModel : BasePlatformDividedTagViewModel
    {
        public DeletePlatformDividedTagViewModel(IActorViewService<PlatformDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformDividedTag = new();
        }
    }
    public class GetsPlatformDividedTagViewModel : BasePlatformDividedTagViewModel
    {
        private List<PlatformDividedTag> _PlatformDividedTags = new();
        public List<PlatformDividedTag> PlatformDividedTags
        {
            get=> _PlatformDividedTags;
            set
            {
                SetValue(ref _PlatformDividedTags, value);   
            }
        }
        public GetsPlatformDividedTagViewModel(IActorViewService<PlatformDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformDividedTag>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformDividedTags.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformDividedTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
