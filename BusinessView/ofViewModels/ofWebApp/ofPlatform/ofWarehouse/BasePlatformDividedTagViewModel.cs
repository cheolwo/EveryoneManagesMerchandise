using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformDividedTagViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformDividedTag? _PlatformDividedTag = new();
        public PlatformDividedTag? PlatformDividedTag
        {
            get => _PlatformDividedTag;
            set
            {
                SetValue(ref _PlatformDividedTag, value);
            }
        }
        public BasePlatformDividedTagViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformDividedTag = await _PlatformActorContext.GetByIdAsync<PlatformDividedTag>(id);
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
        public PostPlatformDividedTagViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformDividedTag PlatformDividedTag)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformDividedTag>(PlatformDividedTag);
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
        public PutPlatformDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformDividedTag PlatformDividedTag)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformDividedTag>(PlatformDividedTag);
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
        public DeletePlatformDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformDividedTag>(id);
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
        public GetsPlatformDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformDividedTag>? dtos = await _PlatformActorContext.GetsAsync<PlatformDividedTag>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformDividedTag>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformDividedTag>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformDividedTags.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformDividedTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
