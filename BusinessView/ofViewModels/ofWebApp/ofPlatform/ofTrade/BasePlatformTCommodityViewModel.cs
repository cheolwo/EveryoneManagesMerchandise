using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformTCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformTCommodity? _PlatformTCommodity = new();
        public PlatformTCommodity? PlatformTCommodity
        {
            get => _PlatformTCommodity;
            set
            {
                SetValue(ref _PlatformTCommodity, value);
            }
        }
        public BasePlatformTCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformTCommodity = await _PlatformActorContext.GetByIdAsync<PlatformTCommodity>(id);
        }
    }
    public class PostPlatformTCommodityViewModel : BasePlatformTCommodityViewModel
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
        private PlatformTCommodity? _postPlatformTCommodity = new();
        public PlatformTCommodity? PostPlatformTCommodity
        {
            get => _postPlatformTCommodity;
            set
            {
                SetValue(ref _postPlatformTCommodity, value);
            }
        }
        public PostPlatformTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformTCommodity PlatformTCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformTCommodity>(PlatformTCommodity);
            if (PostValue != null)
            {
                PostPlatformTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformTCommodity = new();
            _postPlatformTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformTCommodityViewModel : BasePlatformTCommodityViewModel
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
        private PlatformTCommodity? _putPlatformTCommodity = new();
        public PlatformTCommodity? PutPlatformTCommodity
        {
            get => _putPlatformTCommodity;
            set
            {
                SetValue(ref _putPlatformTCommodity, value);
            }
        }
        public PutPlatformTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformTCommodity PlatformTCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformTCommodity>(PlatformTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformTCommodity = new();
            _putPlatformTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformTCommodityViewModel : BasePlatformTCommodityViewModel
    {
        public DeletePlatformTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformTCommodity>(id);
        }
        public void Reset()
        {
            PlatformTCommodity = new();
        }
    }
    public class GetsPlatformTCommodityViewModel : BasePlatformTCommodityViewModel
    {
        private List<PlatformTCommodity> _PlatformTCommoditys = new();
        public List<PlatformTCommodity> PlatformTCommoditys
        {
            get=> _PlatformTCommoditys;
            set
            {
                SetValue(ref _PlatformTCommoditys, value);   
            }
        }
        public GetsPlatformTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformTCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformTCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
