using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformPCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformPCommodity? _PlatformPCommodity = new();
        public PlatformPCommodity? PlatformPCommodity
        {
            get => _PlatformPCommodity;
            set
            {
                SetValue(ref _PlatformPCommodity, value);
            }
        }
        public BasePlatformPCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformPCommodity = await _PlatformActorContext.GetByIdAsync<PlatformPCommodity>(id);
        }
    }
    public class PostPlatformPCommodityViewModel : BasePlatformPCommodityViewModel
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
        private PlatformPCommodity? _postPlatformPCommodity = new();
        public PlatformPCommodity? PostPlatformPCommodity
        {
            get => _postPlatformPCommodity;
            set
            {
                SetValue(ref _postPlatformPCommodity, value);
            }
        }
        public PostPlatformPCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformPCommodity PlatformPCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformPCommodity>(PlatformPCommodity);
            if (PostValue != null)
            {
                PostPlatformPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformPCommodity = new();
            _postPlatformPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformPCommodityViewModel : BasePlatformPCommodityViewModel
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
        private PlatformPCommodity? _putPlatformPCommodity = new();
        public PlatformPCommodity? PutPlatformPCommodity
        {
            get => _putPlatformPCommodity;
            set
            {
                SetValue(ref _putPlatformPCommodity, value);
            }
        }
        public PutPlatformPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformPCommodity PlatformPCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformPCommodity>(PlatformPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformPCommodity = new();
            _putPlatformPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformPCommodityViewModel : BasePlatformPCommodityViewModel
    {
        public DeletePlatformPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformPCommodity>(id);
        }
        public void Reset()
        {
            PlatformPCommodity = new();
        }
    }
    public class GetsPlatformPCommodityViewModel : BasePlatformPCommodityViewModel
    {
        private List<PlatformPCommodity> _PlatformPCommoditys = new();
        public List<PlatformPCommodity> PlatformPCommoditys
        {
            get=> _PlatformPCommoditys;
            set
            {
                SetValue(ref _PlatformPCommoditys, value);   
            }
        }
        public GetsPlatformPCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformPCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformPCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
