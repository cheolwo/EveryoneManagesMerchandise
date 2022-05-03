using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformMOCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMOCommodity? _PlatformMOCommodity = new();
        public PlatformMOCommodity? PlatformMOCommodity
        {
            get => _PlatformMOCommodity;
            set
            {
                SetValue(ref _PlatformMOCommodity, value);
            }
        }
        public BasePlatformMOCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMOCommodity = await _PlatformActorContext.GetByIdAsync<PlatformMOCommodity>(id);
        }
    }
    public class PostPlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
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
        private PlatformMOCommodity? _postPlatformMOCommodity = new();
        public PlatformMOCommodity? PostPlatformMOCommodity
        {
            get => _postPlatformMOCommodity;
            set
            {
                SetValue(ref _postPlatformMOCommodity, value);
            }
        }
        public PostPlatformMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMOCommodity PlatformMOCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMOCommodity>(PlatformMOCommodity);
            if (PostValue != null)
            {
                PostPlatformMOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMOCommodity = new();
            _postPlatformMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
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
        private PlatformMOCommodity? _putPlatformMOCommodity = new();
        public PlatformMOCommodity? PutPlatformMOCommodity
        {
            get => _putPlatformMOCommodity;
            set
            {
                SetValue(ref _putPlatformMOCommodity, value);
            }
        }
        public PutPlatformMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMOCommodity PlatformMOCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMOCommodity>(PlatformMOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMOCommodity = new();
            _putPlatformMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
    {
        public DeletePlatformMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMOCommodity>(id);
        }
        public void Reset()
        {
            PlatformMOCommodity = new();
        }
    }
    public class GetsPlatformMOCommodityViewModel : BasePlatformMOCommodityViewModel
    {
        private List<PlatformMOCommodity> _PlatformMOCommoditys = new();
        public List<PlatformMOCommodity> PlatformMOCommoditys
        {
            get=> _PlatformMOCommoditys;
            set
            {
                SetValue(ref _PlatformMOCommoditys, value);   
            }
        }
        public GetsPlatformMOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMOCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformMOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMOCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
