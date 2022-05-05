using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformIncomingTagViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformIncomingTag? _PlatformIncomingTag = new();
        public PlatformIncomingTag? PlatformIncomingTag
        {
            get => _PlatformIncomingTag;
            set
            {
                SetValue(ref _PlatformIncomingTag, value);
            }
        }
        public BasePlatformIncomingTagViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformIncomingTag = await _PlatformActorContext.GetByIdAsync<PlatformIncomingTag>(id);
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
        public PostPlatformIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformIncomingTag PlatformIncomingTag)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformIncomingTag>(PlatformIncomingTag);
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
        public PutPlatformIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformIncomingTag PlatformIncomingTag)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformIncomingTag>(PlatformIncomingTag);
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
        public DeletePlatformIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformIncomingTag>(id);
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
        public GetsPlatformIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformIncomingTag>? dtos = await _PlatformActorContext.GetsAsync<PlatformIncomingTag>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformIncomingTag>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformIncomingTag>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformIncomingTags.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformIncomingTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
