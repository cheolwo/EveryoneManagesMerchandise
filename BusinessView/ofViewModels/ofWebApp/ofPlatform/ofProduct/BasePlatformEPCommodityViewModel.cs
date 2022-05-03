using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformEPCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformEPCommodity? _PlatformEPCommodity = new();
        public PlatformEPCommodity? PlatformEPCommodity
        {
            get => _PlatformEPCommodity;
            set
            {
                SetValue(ref _PlatformEPCommodity, value);
            }
        }
        public BasePlatformEPCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformEPCommodity = await _PlatformActorContext.GetByIdAsync<PlatformEPCommodity>(id);
        }
    }
    public class PostPlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
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
        private PlatformEPCommodity? _postPlatformEPCommodity = new();
        public PlatformEPCommodity? PostPlatformEPCommodity
        {
            get => _postPlatformEPCommodity;
            set
            {
                SetValue(ref _postPlatformEPCommodity, value);
            }
        }
        public PostPlatformEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformEPCommodity PlatformEPCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformEPCommodity>(PlatformEPCommodity);
            if (PostValue != null)
            {
                PostPlatformEPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEPCommodity = new();
            _postPlatformEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
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
        private PlatformEPCommodity? _putPlatformEPCommodity = new();
        public PlatformEPCommodity? PutPlatformEPCommodity
        {
            get => _putPlatformEPCommodity;
            set
            {
                SetValue(ref _putPlatformEPCommodity, value);
            }
        }
        public PutPlatformEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformEPCommodity PlatformEPCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformEPCommodity>(PlatformEPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEPCommodity = new();
            _putPlatformEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
    {
        public DeletePlatformEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformEPCommodity>(id);
        }
        public void Reset()
        {
            PlatformEPCommodity = new();
        }
    }
    public class GetsPlatformEPCommodityViewModel : BasePlatformEPCommodityViewModel
    {
        private List<PlatformEPCommodity> _PlatformEPCommoditys = new();
        public List<PlatformEPCommodity> PlatformEPCommoditys
        {
            get=> _PlatformEPCommoditys;
            set
            {
                SetValue(ref _PlatformEPCommoditys, value);   
            }
        }
        public GetsPlatformEPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEPCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformEPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformEPCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformEPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformEPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
