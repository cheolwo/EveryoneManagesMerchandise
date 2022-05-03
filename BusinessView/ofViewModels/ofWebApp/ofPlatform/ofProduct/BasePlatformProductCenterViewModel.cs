using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProductCenterViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformProductCenter? _PlatformProductCenter = new();
        public PlatformProductCenter? PlatformProductCenter
        {
            get => _PlatformProductCenter;
            set
            {
                SetValue(ref _PlatformProductCenter, value);
            }
        }
        public BasePlatformProductCenterViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformProductCenter = await _PlatformActorContext.GetByIdAsync<PlatformProductCenter>(id);
        }
    }
    public class PostPlatformProductCenterViewModel : BasePlatformProductCenterViewModel
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
        private PlatformProductCenter? _postPlatformProductCenter = new();
        public PlatformProductCenter? PostPlatformProductCenter
        {
            get => _postPlatformProductCenter;
            set
            {
                SetValue(ref _postPlatformProductCenter, value);
            }
        }
        public PostPlatformProductCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformProductCenter PlatformProductCenter)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformProductCenter>(PlatformProductCenter);
            if (PostValue != null)
            {
                PostPlatformProductCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformProductCenter = new();
            _postPlatformProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformProductCenterViewModel : BasePlatformProductCenterViewModel
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
        private PlatformProductCenter? _putPlatformProductCenter = new();
        public PlatformProductCenter? PutPlatformProductCenter
        {
            get => _putPlatformProductCenter;
            set
            {
                SetValue(ref _putPlatformProductCenter, value);
            }
        }
        public PutPlatformProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformProductCenter PlatformProductCenter)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformProductCenter>(PlatformProductCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformProductCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformProductCenter = new();
            _putPlatformProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformProductCenterViewModel : BasePlatformProductCenterViewModel
    {
        public DeletePlatformProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformProductCenter>(id);
        }
        public void Reset()
        {
            PlatformProductCenter = new();
        }
    }
    public class GetsPlatformProductCenterViewModel : BasePlatformProductCenterViewModel
    {
        private List<PlatformProductCenter> _PlatformProductCenters = new();
        public List<PlatformProductCenter> PlatformProductCenters
        {
            get=> _PlatformProductCenters;
            set
            {
                SetValue(ref _PlatformProductCenters, value);   
            }
        }
        public GetsPlatformProductCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformProductCenter>? dtos = await _PlatformActorContext.GetsAsync<PlatformProductCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProductCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformProductCenter>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformProductCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProductCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformProductCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformProductCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
