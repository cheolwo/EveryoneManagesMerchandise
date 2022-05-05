using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformTradeCenterViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformTradeCenter? _PlatformTradeCenter = new();
        public PlatformTradeCenter? PlatformTradeCenter
        {
            get => _PlatformTradeCenter;
            set
            {
                SetValue(ref _PlatformTradeCenter, value);
            }
        }
        public BasePlatformTradeCenterViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformTradeCenter = await _PlatformActorContext.GetByIdAsync<PlatformTradeCenter>(id);
        }
    }
    public class PostPlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
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
        private PlatformTradeCenter? _postPlatformTradeCenter = new();
        public PlatformTradeCenter? PostPlatformTradeCenter
        {
            get => _postPlatformTradeCenter;
            set
            {
                SetValue(ref _postPlatformTradeCenter, value);
            }
        }
        public PostPlatformTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformTradeCenter PlatformTradeCenter)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformTradeCenter>(PlatformTradeCenter);
            if (PostValue != null)
            {
                PostPlatformTradeCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformTradeCenter = new();
            _postPlatformTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
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
        private PlatformTradeCenter? _putPlatformTradeCenter = new();
        public PlatformTradeCenter? PutPlatformTradeCenter
        {
            get => _putPlatformTradeCenter;
            set
            {
                SetValue(ref _putPlatformTradeCenter, value);
            }
        }
        public PutPlatformTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformTradeCenter PlatformTradeCenter)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformTradeCenter>(PlatformTradeCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformTradeCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformTradeCenter = new();
            _putPlatformTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
    {
        public DeletePlatformTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformTradeCenter>(id);
        }
        public void Reset()
        {
            PlatformTradeCenter = new();
        }
    }
    public class GetsPlatformTradeCenterViewModel : BasePlatformTradeCenterViewModel
    {
        private List<PlatformTradeCenter> _PlatformTradeCenters = new();
        public List<PlatformTradeCenter> PlatformTradeCenters
        {
            get=> _PlatformTradeCenters;
            set
            {
                SetValue(ref _PlatformTradeCenters, value);   
            }
        }
        public GetsPlatformTradeCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformTradeCenter>? dtos = await _PlatformActorContext.GetsAsync<PlatformTradeCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformTradeCenter>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformTradeCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformTradeCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformTradeCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
