using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformMWCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMWCommodity? _PlatformMWCommodity = new();
        public PlatformMWCommodity? PlatformMWCommodity
        {
            get => _PlatformMWCommodity;
            set
            {
                SetValue(ref _PlatformMWCommodity, value);
            }
        }
        public BasePlatformMWCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMWCommodity = await _PlatformActorContext.GetByIdAsync<PlatformMWCommodity>(id);
        }
    }
    public class PostPlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
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
        private PlatformMWCommodity? _postPlatformMWCommodity = new();
        public PlatformMWCommodity? PostPlatformMWCommodity
        {
            get => _postPlatformMWCommodity;
            set
            {
                SetValue(ref _postPlatformMWCommodity, value);
            }
        }
        public PostPlatformMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMWCommodity PlatformMWCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMWCommodity>(PlatformMWCommodity);
            if (PostValue != null)
            {
                PostPlatformMWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMWCommodity = new();
            _postPlatformMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
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
        private PlatformMWCommodity? _putPlatformMWCommodity = new();
        public PlatformMWCommodity? PutPlatformMWCommodity
        {
            get => _putPlatformMWCommodity;
            set
            {
                SetValue(ref _putPlatformMWCommodity, value);
            }
        }
        public PutPlatformMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMWCommodity PlatformMWCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMWCommodity>(PlatformMWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMWCommodity = new();
            _putPlatformMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
    {
        public DeletePlatformMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMWCommodity>(id);
        }
        public void Reset()
        {
            PlatformMWCommodity = new();
        }
    }
    public class GetsPlatformMWCommodityViewModel : BasePlatformMWCommodityViewModel
    {
        private List<PlatformMWCommodity> _PlatformMWCommoditys = new();
        public List<PlatformMWCommodity> PlatformMWCommoditys
        {
            get=> _PlatformMWCommoditys;
            set
            {
                SetValue(ref _PlatformMWCommoditys, value);   
            }
        }
        public GetsPlatformMWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMWCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformMWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMWCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
