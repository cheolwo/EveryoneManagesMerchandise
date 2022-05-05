using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket
{
    public class BasePlatformEMCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformEMCommodity? _PlatformEMCommodity = new();
        public PlatformEMCommodity? PlatformEMCommodity
        {
            get => _PlatformEMCommodity;
            set
            {
                SetValue(ref _PlatformEMCommodity, value);
            }
        }
        public BasePlatformEMCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformEMCommodity = await _PlatformActorContext.GetByIdAsync<PlatformEMCommodity>(id);
        }
    }
    public class PostPlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
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
        private PlatformEMCommodity? _postPlatformEMCommodity = new();
        public PlatformEMCommodity? PostPlatformEMCommodity
        {
            get => _postPlatformEMCommodity;
            set
            {
                SetValue(ref _postPlatformEMCommodity, value);
            }
        }
        public PostPlatformEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformEMCommodity PlatformEMCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformEMCommodity>(PlatformEMCommodity);
            if (PostValue != null)
            {
                PostPlatformEMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEMCommodity = new();
            _postPlatformEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
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
        private PlatformEMCommodity? _putPlatformEMCommodity = new();
        public PlatformEMCommodity? PutPlatformEMCommodity
        {
            get => _putPlatformEMCommodity;
            set
            {
                SetValue(ref _putPlatformEMCommodity, value);
            }
        }
        public PutPlatformEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformEMCommodity PlatformEMCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformEMCommodity>(PlatformEMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEMCommodity = new();
            _putPlatformEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
    {
        public DeletePlatformEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformEMCommodity>(id);
        }
        public void Reset()
        {
            PlatformEMCommodity = new();
        }
    }
    public class GetsPlatformEMCommodityViewModel : BasePlatformEMCommodityViewModel
    {
        private List<PlatformEMCommodity> _PlatformEMCommoditys = new();
        public List<PlatformEMCommodity> PlatformEMCommoditys
        {
            get=> _PlatformEMCommoditys;
            set
            {
                SetValue(ref _PlatformEMCommoditys, value);   
            }
        }
        public GetsPlatformEMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEMCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformEMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformEMCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformEMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformEMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
