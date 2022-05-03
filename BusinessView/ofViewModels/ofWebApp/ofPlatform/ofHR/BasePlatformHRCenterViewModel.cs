using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRCenterViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformHRCenter? _PlatformHRCenter = new();
        public PlatformHRCenter? PlatformHRCenter
        {
            get => _PlatformHRCenter;
            set
            {
                SetValue(ref _PlatformHRCenter, value);
            }
        }
        public BasePlatformHRCenterViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformHRCenter = await _PlatformActorContext.GetByIdAsync<PlatformHRCenter>(id);
        }
    }
    public class PostPlatformHRCenterViewModel : BasePlatformHRCenterViewModel
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
        private PlatformHRCenter? _postPlatformHRCenter = new();
        public PlatformHRCenter? PostPlatformHRCenter
        {
            get => _postPlatformHRCenter;
            set
            {
                SetValue(ref _postPlatformHRCenter, value);
            }
        }
        public PostPlatformHRCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformHRCenter PlatformHRCenter)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformHRCenter>(PlatformHRCenter);
            if (PostValue != null)
            {
                PostPlatformHRCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformHRCenter = new();
            _postPlatformHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformHRCenterViewModel : BasePlatformHRCenterViewModel
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
        private PlatformHRCenter? _putPlatformHRCenter = new();
        public PlatformHRCenter? PutPlatformHRCenter
        {
            get => _putPlatformHRCenter;
            set
            {
                SetValue(ref _putPlatformHRCenter, value);
            }
        }
        public PutPlatformHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformHRCenter PlatformHRCenter)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformHRCenter>(PlatformHRCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformHRCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformHRCenter = new();
            _putPlatformHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformHRCenterViewModel : BasePlatformHRCenterViewModel
    {
        public DeletePlatformHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformHRCenter>(id);
        }
        public void Reset()
        {
            PlatformHRCenter = new();
        }
    }
    public class GetsPlatformHRCenterViewModel : BasePlatformHRCenterViewModel
    {
        private List<PlatformHRCenter> _PlatformHRCenters = new();
        public List<PlatformHRCenter> PlatformHRCenters
        {
            get=> _PlatformHRCenters;
            set
            {
                SetValue(ref _PlatformHRCenters, value);   
            }
        }
        public GetsPlatformHRCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformHRCenter>? dtos = await _PlatformActorContext.GetsAsync<PlatformHRCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformHRCenter>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformHRCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformHRCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformHRCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
