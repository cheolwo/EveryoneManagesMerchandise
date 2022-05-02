using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformIncomingTagViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformIncomingTag> _actorViewService;
        protected PlatformIncomingTag? _PlatformIncomingTag = new();
        public PlatformIncomingTag? PlatformIncomingTag
        {
            get => _PlatformIncomingTag;
            set
            {
                SetValue(ref _PlatformIncomingTag, value);
            }
        }
        public BasePlatformIncomingTagViewModel(IActorViewService<PlatformIncomingTag> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformIncomingTag = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformIncomingTagViewModel : BasePlatformIncomingTagViewModel
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
        private PlatformIncomingTag? _postPlatformIncomingTag = new();
        public PlatformIncomingTag? PostPlatformIncomingTag
        {
            get => _postPlatformIncomingTag;
            set
            {
                SetValue(ref _postPlatformIncomingTag, value);
            }
        }
        public PostPlatformIncomingTagViewModel(IActorViewService<PlatformIncomingTag> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformIncomingTag PlatformIncomingTag)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformIncomingTag);
            if (PostValue != null)
            {
                PostPlatformIncomingTag = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformIncomingTag = new();
            _postPlatformIncomingTag = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformIncomingTagViewModel : BasePlatformIncomingTagViewModel
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
        private PlatformIncomingTag? _putPlatformIncomingTag = new();
        public PlatformIncomingTag? PutPlatformIncomingTag
        {
            get => _putPlatformIncomingTag;
            set
            {
                SetValue(ref _putPlatformIncomingTag, value);
            }
        }
        public PutPlatformIncomingTagViewModel(IActorViewService<PlatformIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformIncomingTag PlatformIncomingTag)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformIncomingTag);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformIncomingTag = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformIncomingTag = new();
            _putPlatformIncomingTag = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformIncomingTagViewModel : BasePlatformIncomingTagViewModel
    {
        public DeletePlatformIncomingTagViewModel(IActorViewService<PlatformIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformIncomingTag = new();
        }
    }
    public class GetsPlatformIncomingTagViewModel : BasePlatformIncomingTagViewModel
    {
        private List<PlatformIncomingTag> _PlatformIncomingTags = new();
        public List<PlatformIncomingTag> PlatformIncomingTags
        {
            get=> _PlatformIncomingTags;
            set
            {
                SetValue(ref _PlatformIncomingTags, value);   
            }
        }
        public GetsPlatformIncomingTagViewModel(IActorViewService<PlatformIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformIncomingTag>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformIncomingTags.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformIncomingTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
