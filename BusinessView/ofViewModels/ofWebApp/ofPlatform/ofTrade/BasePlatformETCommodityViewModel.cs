using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformETCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformETCommodity? _PlatformETCommodity = new();
        public PlatformETCommodity? PlatformETCommodity
        {
            get => _PlatformETCommodity;
            set
            {
                SetValue(ref _PlatformETCommodity, value);
            }
        }
        public BasePlatformETCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformETCommodity = await _PlatformActorContext.GetByIdAsync<PlatformETCommodity>(id);
        }
    }
    public class PostPlatformETCommodityViewModel : BasePlatformETCommodityViewModel
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
        private PlatformETCommodity? _postPlatformETCommodity = new();
        public PlatformETCommodity? PostPlatformETCommodity
        {
            get => _postPlatformETCommodity;
            set
            {
                SetValue(ref _postPlatformETCommodity, value);
            }
        }
        public PostPlatformETCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformETCommodity PlatformETCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformETCommodity>(PlatformETCommodity);
            if (PostValue != null)
            {
                PostPlatformETCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformETCommodity = new();
            _postPlatformETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformETCommodityViewModel : BasePlatformETCommodityViewModel
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
        private PlatformETCommodity? _putPlatformETCommodity = new();
        public PlatformETCommodity? PutPlatformETCommodity
        {
            get => _putPlatformETCommodity;
            set
            {
                SetValue(ref _putPlatformETCommodity, value);
            }
        }
        public PutPlatformETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformETCommodity PlatformETCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformETCommodity>(PlatformETCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformETCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformETCommodity = new();
            _putPlatformETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformETCommodityViewModel : BasePlatformETCommodityViewModel
    {
        public DeletePlatformETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformETCommodity>(id);
        }
        public void Reset()
        {
            PlatformETCommodity = new();
        }
    }
    public class GetsPlatformETCommodityViewModel : BasePlatformETCommodityViewModel
    {
        private List<PlatformETCommodity> _PlatformETCommoditys = new();
        public List<PlatformETCommodity> PlatformETCommoditys
        {
            get=> _PlatformETCommoditys;
            set
            {
                SetValue(ref _PlatformETCommoditys, value);   
            }
        }
        public GetsPlatformETCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformETCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformETCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformETCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformETCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformETCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformETCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
