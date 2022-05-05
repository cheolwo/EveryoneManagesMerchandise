using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformSWCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformSWCommodity? _PlatformSWCommodity = new();
        public PlatformSWCommodity? PlatformSWCommodity
        {
            get => _PlatformSWCommodity;
            set
            {
                SetValue(ref _PlatformSWCommodity, value);
            }
        }
        public BasePlatformSWCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSWCommodity = await _PlatformActorContext.GetByIdAsync<PlatformSWCommodity>(id);
        }
    }
    public class PostPlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
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
        private PlatformSWCommodity? _postPlatformSWCommodity = new();
        public PlatformSWCommodity? PostPlatformSWCommodity
        {
            get => _postPlatformSWCommodity;
            set
            {
                SetValue(ref _postPlatformSWCommodity, value);
            }
        }
        public PostPlatformSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformSWCommodity PlatformSWCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformSWCommodity>(PlatformSWCommodity);
            if (PostValue != null)
            {
                PostPlatformSWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSWCommodity = new();
            _postPlatformSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
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
        private PlatformSWCommodity? _putPlatformSWCommodity = new();
        public PlatformSWCommodity? PutPlatformSWCommodity
        {
            get => _putPlatformSWCommodity;
            set
            {
                SetValue(ref _putPlatformSWCommodity, value);
            }
        }
        public PutPlatformSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformSWCommodity PlatformSWCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformSWCommodity>(PlatformSWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSWCommodity = new();
            _putPlatformSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
    {
        public DeletePlatformSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformSWCommodity>(id);
        }
        public void Reset()
        {
            PlatformSWCommodity = new();
        }
    }
    public class GetsPlatformSWCommodityViewModel : BasePlatformSWCommodityViewModel
    {
        private List<PlatformSWCommodity> _PlatformSWCommoditys = new();
        public List<PlatformSWCommodity> PlatformSWCommoditys
        {
            get=> _PlatformSWCommoditys;
            set
            {
                SetValue(ref _PlatformSWCommoditys, value);   
            }
        }
        public GetsPlatformSWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSWCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformSWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformSWCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformSWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformSWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
