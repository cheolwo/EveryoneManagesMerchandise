using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformSPCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformSPCommodity? _PlatformSPCommodity = new();
        public PlatformSPCommodity? PlatformSPCommodity
        {
            get => _PlatformSPCommodity;
            set
            {
                SetValue(ref _PlatformSPCommodity, value);
            }
        }
        public BasePlatformSPCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSPCommodity = await _PlatformActorContext.GetByIdAsync<PlatformSPCommodity>(id);
        }
    }
    public class PostPlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
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
        private PlatformSPCommodity? _postPlatformSPCommodity = new();
        public PlatformSPCommodity? PostPlatformSPCommodity
        {
            get => _postPlatformSPCommodity;
            set
            {
                SetValue(ref _postPlatformSPCommodity, value);
            }
        }
        public PostPlatformSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformSPCommodity PlatformSPCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformSPCommodity>(PlatformSPCommodity);
            if (PostValue != null)
            {
                PostPlatformSPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSPCommodity = new();
            _postPlatformSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
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
        private PlatformSPCommodity? _putPlatformSPCommodity = new();
        public PlatformSPCommodity? PutPlatformSPCommodity
        {
            get => _putPlatformSPCommodity;
            set
            {
                SetValue(ref _putPlatformSPCommodity, value);
            }
        }
        public PutPlatformSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformSPCommodity PlatformSPCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformSPCommodity>(PlatformSPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSPCommodity = new();
            _putPlatformSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
    {
        public DeletePlatformSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformSPCommodity>(id);
        }
        public void Reset()
        {
            PlatformSPCommodity = new();
        }
    }
    public class GetsPlatformSPCommodityViewModel : BasePlatformSPCommodityViewModel
    {
        private List<PlatformSPCommodity> _PlatformSPCommoditys = new();
        public List<PlatformSPCommodity> PlatformSPCommoditys
        {
            get=> _PlatformSPCommoditys;
            set
            {
                SetValue(ref _PlatformSPCommoditys, value);   
            }
        }
        public GetsPlatformSPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSPCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformSPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformSPCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformSPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformSPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
