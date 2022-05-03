using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRBusinessPartViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformHRBusinessPart? _PlatformHRBusinessPart = new();
        public PlatformHRBusinessPart? PlatformHRBusinessPart
        {
            get => _PlatformHRBusinessPart;
            set
            {
                SetValue(ref _PlatformHRBusinessPart, value);
            }
        }
        public BasePlatformHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHRBusinessPart = await _PlatformActorContext.GetByIdAsync<PlatformHRBusinessPart>(id);
        }
    }
    public class PostPlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
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
        private PlatformHRBusinessPart? _postPlatformHRBusinessPart = new();
        public PlatformHRBusinessPart? PostPlatformHRBusinessPart
        {
            get => _postPlatformHRBusinessPart;
            set
            {
                SetValue(ref _postPlatformHRBusinessPart, value);
            }
        }
        public PostPlatformHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformHRBusinessPart PlatformHRBusinessPart)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformHRBusinessPart>(PlatformHRBusinessPart);
            if (PostValue != null)
            {
                PostPlatformHRBusinessPart = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformHRBusinessPart = new();
            _postPlatformHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
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
        private PlatformHRBusinessPart? _putPlatformHRBusinessPart = new();
        public PlatformHRBusinessPart? PutPlatformHRBusinessPart
        {
            get => _putPlatformHRBusinessPart;
            set
            {
                SetValue(ref _putPlatformHRBusinessPart, value);
            }
        }
        public PutPlatformHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformHRBusinessPart PlatformHRBusinessPart)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformHRBusinessPart>(PlatformHRBusinessPart);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformHRBusinessPart = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformHRBusinessPart = new();
            _putPlatformHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
    {
        public DeletePlatformHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformHRBusinessPart>(id);
        }
        public void Reset()
        {
            PlatformHRBusinessPart = new();
        }
    }
    public class GetsPlatformHRBusinessPartViewModel : BasePlatformHRBusinessPartViewModel
    {
        private List<PlatformHRBusinessPart> _PlatformHRBusinessParts = new();
        public List<PlatformHRBusinessPart> PlatformHRBusinessParts
        {
            get=> _PlatformHRBusinessParts;
            set
            {
                SetValue(ref _PlatformHRBusinessParts, value);   
            }
        }
        public GetsPlatformHRBusinessPartViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHRBusinessPart>? dtos = await _PlatformActorContext.GetsAsync<PlatformHRBusinessPart>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformHRBusinessPart>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformHRBusinessPart>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformHRBusinessParts.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHRBusinessParts.Remove(obj); OnPropertyChanged(); }
        }
    }
}
