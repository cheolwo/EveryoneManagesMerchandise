using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformMPCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMPCommodity? _PlatformMPCommodity = new();
        public PlatformMPCommodity? PlatformMPCommodity
        {
            get => _PlatformMPCommodity;
            set
            {
                SetValue(ref _PlatformMPCommodity, value);
            }
        }
        public BasePlatformMPCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMPCommodity = await _PlatformActorContext.GetByIdAsync<PlatformMPCommodity>(id);
        }
    }
    public class PostPlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
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
        private PlatformMPCommodity? _postPlatformMPCommodity = new();
        public PlatformMPCommodity? PostPlatformMPCommodity
        {
            get => _postPlatformMPCommodity;
            set
            {
                SetValue(ref _postPlatformMPCommodity, value);
            }
        }
        public PostPlatformMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMPCommodity PlatformMPCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMPCommodity>(PlatformMPCommodity);
            if (PostValue != null)
            {
                PostPlatformMPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMPCommodity = new();
            _postPlatformMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
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
        private PlatformMPCommodity? _putPlatformMPCommodity = new();
        public PlatformMPCommodity? PutPlatformMPCommodity
        {
            get => _putPlatformMPCommodity;
            set
            {
                SetValue(ref _putPlatformMPCommodity, value);
            }
        }
        public PutPlatformMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMPCommodity PlatformMPCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMPCommodity>(PlatformMPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMPCommodity = new();
            _putPlatformMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
    {
        public DeletePlatformMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMPCommodity>(id);
        }
        public void Reset()
        {
            PlatformMPCommodity = new();
        }
    }
    public class GetsPlatformMPCommodityViewModel : BasePlatformMPCommodityViewModel
    {
        private List<PlatformMPCommodity> _PlatformMPCommoditys = new();
        public List<PlatformMPCommodity> PlatformMPCommoditys
        {
            get=> _PlatformMPCommoditys;
            set
            {
                SetValue(ref _PlatformMPCommoditys, value);   
            }
        }
        public GetsPlatformMPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMPCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformMPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMPCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
