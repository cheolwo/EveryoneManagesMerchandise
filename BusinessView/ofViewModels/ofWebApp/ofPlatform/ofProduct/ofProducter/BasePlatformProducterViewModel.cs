using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProducterViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformProducter? _PlatformProducter = new();
        public PlatformProducter? PlatformProducter
        {
            get => _PlatformProducter;
            set
            {
                SetValue(ref _PlatformProducter, value);
            }
        }
        public BasePlatformProducterViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformProducter = await _PlatformActorContext.GetByIdAsync<PlatformProducter>(id);
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
        public PostPlatformProducterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformProducter PlatformProducter)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformProducter>(PlatformProducter);
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
        public PutPlatformProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformProducter PlatformProducter)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformProducter>(PlatformProducter);
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
        public DeletePlatformProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformProducter>(id);
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
        public GetsPlatformProducterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformProducter>? dtos = await _PlatformActorContext.GetsAsync<PlatformProducter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformProducter>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformProducter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformProducters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformProducters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
