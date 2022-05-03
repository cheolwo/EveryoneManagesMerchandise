using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMCommodity
{
    public class BasePlatformMCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMCommodity? _PlatformMCommodity = new();
        public PlatformMCommodity? PlatformMCommodity
        {
            get => _PlatformMCommodity;
            set
            {
                SetValue(ref _PlatformMCommodity, value);
            }
        }
        public BasePlatformMCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMCommodity = await _PlatformActorContext.GetByIdAsync<PlatformMCommodity>(id);
        }
    }
    public class PostPlatformMCommodityViewModel : BasePlatformMCommodityViewModel
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
        private PlatformMCommodity? _postPlatformMCommodity = new();
        public PlatformMCommodity? PostPlatformMCommodity
        {
            get => _postPlatformMCommodity;
            set
            {
                SetValue(ref _postPlatformMCommodity, value);
            }
        }
        public PostPlatformMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMCommodity PlatformMCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMCommodity>(PlatformMCommodity);
            if (PostValue != null)
            {
                PostPlatformMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMCommodity = new();
            _postPlatformMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMCommodityViewModel : BasePlatformMCommodityViewModel
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
        private PlatformMCommodity? _putPlatformMCommodity = new();
        public PlatformMCommodity? PutPlatformMCommodity
        {
            get => _putPlatformMCommodity;
            set
            {
                SetValue(ref _putPlatformMCommodity, value);
            }
        }
        public PutPlatformMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMCommodity PlatformMCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMCommodity>(PlatformMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMCommodity = new();
            _putPlatformMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMCommodityViewModel : BasePlatformMCommodityViewModel
    {
        public DeletePlatformMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMCommodity>(id);
        }
        public void Reset()
        {
            PlatformMCommodity = new();
        }
    }
    public class GetsPlatformMCommodityViewModel : BasePlatformMCommodityViewModel
    {
        private List<PlatformMCommodity> _PlatformMCommoditys = new();
        public List<PlatformMCommodity> PlatformMCommoditys
        {
            get=> _PlatformMCommoditys;
            set
            {
                SetValue(ref _PlatformMCommoditys, value);   
            }
        }
        public GetsPlatformMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
