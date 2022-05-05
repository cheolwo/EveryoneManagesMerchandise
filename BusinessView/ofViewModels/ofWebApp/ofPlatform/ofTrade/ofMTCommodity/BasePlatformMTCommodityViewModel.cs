using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformMTCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMTCommodity? _PlatformMTCommodity = new();
        public PlatformMTCommodity? PlatformMTCommodity
        {
            get => _PlatformMTCommodity;
            set
            {
                SetValue(ref _PlatformMTCommodity, value);
            }
        }
        public BasePlatformMTCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMTCommodity = await _PlatformActorContext.GetByIdAsync<PlatformMTCommodity>(id);
        }
    }
    public class PostPlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
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
        private PlatformMTCommodity? _postPlatformMTCommodity = new();
        public PlatformMTCommodity? PostPlatformMTCommodity
        {
            get => _postPlatformMTCommodity;
            set
            {
                SetValue(ref _postPlatformMTCommodity, value);
            }
        }
        public PostPlatformMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMTCommodity PlatformMTCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMTCommodity>(PlatformMTCommodity);
            if (PostValue != null)
            {
                PostPlatformMTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMTCommodity = new();
            _postPlatformMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
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
        private PlatformMTCommodity? _putPlatformMTCommodity = new();
        public PlatformMTCommodity? PutPlatformMTCommodity
        {
            get => _putPlatformMTCommodity;
            set
            {
                SetValue(ref _putPlatformMTCommodity, value);
            }
        }
        public PutPlatformMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMTCommodity PlatformMTCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMTCommodity>(PlatformMTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMTCommodity = new();
            _putPlatformMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
    {
        public DeletePlatformMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMTCommodity>(id);
        }
        public void Reset()
        {
            PlatformMTCommodity = new();
        }
    }
    public class GetsPlatformMTCommodityViewModel : BasePlatformMTCommodityViewModel
    {
        private List<PlatformMTCommodity> _PlatformMTCommoditys = new();
        public List<PlatformMTCommodity> PlatformMTCommoditys
        {
            get=> _PlatformMTCommoditys;
            set
            {
                SetValue(ref _PlatformMTCommoditys, value);   
            }
        }
        public GetsPlatformMTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMTCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformMTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMTCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
