using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformOrderCenterViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformOrderCenter? _PlatformOrderCenter = new();
        public PlatformOrderCenter? PlatformOrderCenter
        {
            get => _PlatformOrderCenter;
            set
            {
                SetValue(ref _PlatformOrderCenter, value);
            }
        }
        public BasePlatformOrderCenterViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformOrderCenter = await _PlatformActorContext.GetByIdAsync<PlatformOrderCenter>(id);
        }
    }
    public class PostPlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
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
        private PlatformOrderCenter? _postPlatformOrderCenter = new();
        public PlatformOrderCenter? PostPlatformOrderCenter
        {
            get => _postPlatformOrderCenter;
            set
            {
                SetValue(ref _postPlatformOrderCenter, value);
            }
        }
        public PostPlatformOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformOrderCenter PlatformOrderCenter)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformOrderCenter>(PlatformOrderCenter);
            if (PostValue != null)
            {
                PostPlatformOrderCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformOrderCenter = new();
            _postPlatformOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
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
        private PlatformOrderCenter? _putPlatformOrderCenter = new();
        public PlatformOrderCenter? PutPlatformOrderCenter
        {
            get => _putPlatformOrderCenter;
            set
            {
                SetValue(ref _putPlatformOrderCenter, value);
            }
        }
        public PutPlatformOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformOrderCenter PlatformOrderCenter)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformOrderCenter>(PlatformOrderCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformOrderCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformOrderCenter = new();
            _putPlatformOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
    {
        public DeletePlatformOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformOrderCenter>(id);
        }
        public void Reset()
        {
            PlatformOrderCenter = new();
        }
    }
    public class GetsPlatformOrderCenterViewModel : BasePlatformOrderCenterViewModel
    {
        private List<PlatformOrderCenter> _PlatformOrderCenters = new();
        public List<PlatformOrderCenter> PlatformOrderCenters
        {
            get=> _PlatformOrderCenters;
            set
            {
                SetValue(ref _PlatformOrderCenters, value);   
            }
        }
        public GetsPlatformOrderCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformOrderCenter>? dtos = await _PlatformActorContext.GetsAsync<PlatformOrderCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformOrderCenter>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformOrderCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformOrderCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformOrderCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
