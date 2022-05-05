using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformSOCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformSOCommodity? _PlatformSOCommodity = new();
        public PlatformSOCommodity? PlatformSOCommodity
        {
            get => _PlatformSOCommodity;
            set
            {
                SetValue(ref _PlatformSOCommodity, value);
            }
        }
        public BasePlatformSOCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSOCommodity = await _PlatformActorContext.GetByIdAsync<PlatformSOCommodity>(id);
        }
    }
    public class PostPlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
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
        private PlatformSOCommodity? _postPlatformSOCommodity = new();
        public PlatformSOCommodity? PostPlatformSOCommodity
        {
            get => _postPlatformSOCommodity;
            set
            {
                SetValue(ref _postPlatformSOCommodity, value);
            }
        }
        public PostPlatformSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformSOCommodity PlatformSOCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformSOCommodity>(PlatformSOCommodity);
            if (PostValue != null)
            {
                PostPlatformSOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSOCommodity = new();
            _postPlatformSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
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
        private PlatformSOCommodity? _putPlatformSOCommodity = new();
        public PlatformSOCommodity? PutPlatformSOCommodity
        {
            get => _putPlatformSOCommodity;
            set
            {
                SetValue(ref _putPlatformSOCommodity, value);
            }
        }
        public PutPlatformSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformSOCommodity PlatformSOCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformSOCommodity>(PlatformSOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSOCommodity = new();
            _putPlatformSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
    {
        public DeletePlatformSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformSOCommodity>(id);
        }
        public void Reset()
        {
            PlatformSOCommodity = new();
        }
    }
    public class GetsPlatformSOCommodityViewModel : BasePlatformSOCommodityViewModel
    {
        private List<PlatformSOCommodity> _PlatformSOCommoditys = new();
        public List<PlatformSOCommodity> PlatformSOCommoditys
        {
            get=> _PlatformSOCommoditys;
            set
            {
                SetValue(ref _PlatformSOCommoditys, value);   
            }
        }
        public GetsPlatformSOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSOCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformSOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformSOCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformSOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformSOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
