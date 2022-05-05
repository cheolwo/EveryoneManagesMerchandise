using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformEWCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformEWCommodity? _PlatformEWCommodity = new();
        public PlatformEWCommodity? PlatformEWCommodity
        {
            get => _PlatformEWCommodity;
            set
            {
                SetValue(ref _PlatformEWCommodity, value);
            }
        }
        public BasePlatformEWCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformEWCommodity = await _PlatformActorContext.GetByIdAsync<PlatformEWCommodity>(id);
        }
    }
    public class PostPlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
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
        private PlatformEWCommodity? _postPlatformEWCommodity = new();
        public PlatformEWCommodity? PostPlatformEWCommodity
        {
            get => _postPlatformEWCommodity;
            set
            {
                SetValue(ref _postPlatformEWCommodity, value);
            }
        }
        public PostPlatformEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformEWCommodity PlatformEWCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformEWCommodity>(PlatformEWCommodity);
            if (PostValue != null)
            {
                PostPlatformEWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformEWCommodity = new();
            _postPlatformEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
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
        private PlatformEWCommodity? _putPlatformEWCommodity = new();
        public PlatformEWCommodity? PutPlatformEWCommodity
        {
            get => _putPlatformEWCommodity;
            set
            {
                SetValue(ref _putPlatformEWCommodity, value);
            }
        }
        public PutPlatformEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformEWCommodity PlatformEWCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformEWCommodity>(PlatformEWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformEWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformEWCommodity = new();
            _putPlatformEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
    {
        public DeletePlatformEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformEWCommodity>(id);
        }
        public void Reset()
        {
            PlatformEWCommodity = new();
        }
    }
    public class GetsPlatformEWCommodityViewModel : BasePlatformEWCommodityViewModel
    {
        private List<PlatformEWCommodity> _PlatformEWCommoditys = new();
        public List<PlatformEWCommodity> PlatformEWCommoditys
        {
            get=> _PlatformEWCommoditys;
            set
            {
                SetValue(ref _PlatformEWCommoditys, value);   
            }
        }
        public GetsPlatformEWCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformEWCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformEWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformEWCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformEWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformEWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformEWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
