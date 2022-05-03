using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder
{
    public class BasePlatformOCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformOCommodity? _PlatformOCommodity = new();
        public PlatformOCommodity? PlatformOCommodity
        {
            get => _PlatformOCommodity;
            set
            {
                SetValue(ref _PlatformOCommodity, value);
            }
        }
        public BasePlatformOCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformOCommodity = await _PlatformActorContext.GetByIdAsync<PlatformOCommodity>(id);
        }
    }
    public class PostPlatformOCommodityViewModel : BasePlatformOCommodityViewModel
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
        private PlatformOCommodity? _postPlatformOCommodity = new();
        public PlatformOCommodity? PostPlatformOCommodity
        {
            get => _postPlatformOCommodity;
            set
            {
                SetValue(ref _postPlatformOCommodity, value);
            }
        }
        public PostPlatformOCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformOCommodity PlatformOCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformOCommodity>(PlatformOCommodity);
            if (PostValue != null)
            {
                PostPlatformOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformOCommodity = new();
            _postPlatformOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformOCommodityViewModel : BasePlatformOCommodityViewModel
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
        private PlatformOCommodity? _putPlatformOCommodity = new();
        public PlatformOCommodity? PutPlatformOCommodity
        {
            get => _putPlatformOCommodity;
            set
            {
                SetValue(ref _putPlatformOCommodity, value);
            }
        }
        public PutPlatformOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformOCommodity PlatformOCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformOCommodity>(PlatformOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformOCommodity = new();
            _putPlatformOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformOCommodityViewModel : BasePlatformOCommodityViewModel
    {
        public DeletePlatformOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformOCommodity>(id);
        }
        public void Reset()
        {
            PlatformOCommodity = new();
        }
    }
    public class GetsPlatformOCommodityViewModel : BasePlatformOCommodityViewModel
    {
        private List<PlatformOCommodity> _PlatformOCommoditys = new();
        public List<PlatformOCommodity> PlatformOCommoditys
        {
            get=> _PlatformOCommoditys;
            set
            {
                SetValue(ref _PlatformOCommoditys, value);   
            }
        }
        public GetsPlatformOCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformOCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformOCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
