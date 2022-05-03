using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformEOCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformEOCommodity? _PlatformEOCommodity = new();
        public PlatformEOCommodity? PlatformEOCommodity
        {
            get => _PlatformEOCommodity;
            set
            {
                SetValue(ref _PlatformEOCommodity, value);
            }
        }
        public BasePlatformEOCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformEOCommodity = await _PlatformActorContext.GetByIdAsync<PlatformEOCommodity>(id);
        }
    }
    public class PostPlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
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
        private PlatformEOCommodity? _postPlatformEOCommodity = new();
        public PlatformEOCommodity? PostPlatformEOCommodity
        {
            get => _postPlatformEOCommodity;
            set
            {
                SetValue(ref _postPlatformEOCommodity, value);
            }
        }
        public PostPlatformEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformEOCommodity PlatformEOCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformEOCommodity>(PlatformEOCommodity);
            if (PostValue != null)
            {
                PostPlatformEOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEOCommodity = new();
            _postPlatformEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
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
        private PlatformEOCommodity? _putPlatformEOCommodity = new();
        public PlatformEOCommodity? PutPlatformEOCommodity
        {
            get => _putPlatformEOCommodity;
            set
            {
                SetValue(ref _putPlatformEOCommodity, value);
            }
        }
        public PutPlatformEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformEOCommodity PlatformEOCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformEOCommodity>(PlatformEOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEOCommodity = new();
            _putPlatformEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
    {
        public DeletePlatformEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformEOCommodity>(id);
        }
        public void Reset()
        {
            PlatformEOCommodity = new();
        }
    }
    public class GetsPlatformEOCommodityViewModel : BasePlatformEOCommodityViewModel
    {
        private List<PlatformEOCommodity> _PlatformEOCommoditys = new();
        public List<PlatformEOCommodity> PlatformEOCommoditys
        {
            get=> _PlatformEOCommoditys;
            set
            {
                SetValue(ref _PlatformEOCommoditys, value);   
            }
        }
        public GetsPlatformEOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEOCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformEOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformEOCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformEOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformEOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
