using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMMCommodity
{
    public class BasePlatformMMCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMMCommodity? _PlatformMMCommodity = new();
        public PlatformMMCommodity? PlatformMMCommodity
        {
            get => _PlatformMMCommodity;
            set
            {
                SetValue(ref _PlatformMMCommodity, value);
            }
        }
        public BasePlatformMMCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMMCommodity = await _PlatformActorContext.GetByIdAsync<PlatformMMCommodity>(id);
        }
    }
    public class PostPlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
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
        private PlatformMMCommodity? _postPlatformMMCommodity = new();
        public PlatformMMCommodity? PostPlatformMMCommodity
        {
            get => _postPlatformMMCommodity;
            set
            {
                SetValue(ref _postPlatformMMCommodity, value);
            }
        }
        public PostPlatformMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMMCommodity PlatformMMCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMMCommodity>(PlatformMMCommodity);
            if (PostValue != null)
            {
                PostPlatformMMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMMCommodity = new();
            _postPlatformMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
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
        private PlatformMMCommodity? _putPlatformMMCommodity = new();
        public PlatformMMCommodity? PutPlatformMMCommodity
        {
            get => _putPlatformMMCommodity;
            set
            {
                SetValue(ref _putPlatformMMCommodity, value);
            }
        }
        public PutPlatformMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMMCommodity PlatformMMCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMMCommodity>(PlatformMMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMMCommodity = new();
            _putPlatformMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
    {
        public DeletePlatformMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMMCommodity>(id);
        }
        public void Reset()
        {
            PlatformMMCommodity = new();
        }
    }
    public class GetsPlatformMMCommodityViewModel : BasePlatformMMCommodityViewModel
    {
        private List<PlatformMMCommodity> _PlatformMMCommoditys = new();
        public List<PlatformMMCommodity> PlatformMMCommoditys
        {
            get=> _PlatformMMCommoditys;
            set
            {
                SetValue(ref _PlatformMMCommoditys, value);   
            }
        }
        public GetsPlatformMMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMMCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformMMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMMCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
