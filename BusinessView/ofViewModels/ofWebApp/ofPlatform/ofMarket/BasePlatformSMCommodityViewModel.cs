using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofMarket.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofSMCommodity
{
    public class BasePlatformSMCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformSMCommodity? _PlatformSMCommodity = new();
        public PlatformSMCommodity? PlatformSMCommodity
        {
            get => _PlatformSMCommodity;
            set
            {
                SetValue(ref _PlatformSMCommodity, value);
            }
        }
        public BasePlatformSMCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSMCommodity = await _PlatformActorContext.GetByIdAsync<PlatformSMCommodity>(id);
        }
    }
    public class PostPlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
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
        private PlatformSMCommodity? _postPlatformSMCommodity = new();
        public PlatformSMCommodity? PostPlatformSMCommodity
        {
            get => _postPlatformSMCommodity;
            set
            {
                SetValue(ref _postPlatformSMCommodity, value);
            }
        }
        public PostPlatformSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformSMCommodity PlatformSMCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformSMCommodity>(PlatformSMCommodity);
            if (PostValue != null)
            {
                PostPlatformSMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSMCommodity = new();
            _postPlatformSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
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
        private PlatformSMCommodity? _putPlatformSMCommodity = new();
        public PlatformSMCommodity? PutPlatformSMCommodity
        {
            get => _putPlatformSMCommodity;
            set
            {
                SetValue(ref _putPlatformSMCommodity, value);
            }
        }
        public PutPlatformSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformSMCommodity PlatformSMCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformSMCommodity>(PlatformSMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSMCommodity = new();
            _putPlatformSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
    {
        public DeletePlatformSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformSMCommodity>(id);
        }
        public void Reset()
        {
            PlatformSMCommodity = new();
        }
    }
    public class GetsPlatformSMCommodityViewModel : BasePlatformSMCommodityViewModel
    {
        private List<PlatformSMCommodity> _PlatformSMCommoditys = new();
        public List<PlatformSMCommodity> PlatformSMCommoditys
        {
            get=> _PlatformSMCommoditys;
            set
            {
                SetValue(ref _PlatformSMCommoditys, value);   
            }
        }
        public GetsPlatformSMCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSMCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformSMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformSMCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformSMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformSMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
