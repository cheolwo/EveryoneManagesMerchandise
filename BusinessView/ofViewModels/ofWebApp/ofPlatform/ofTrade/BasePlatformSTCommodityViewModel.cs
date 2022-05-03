using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade
{
    public class BasePlatformSTCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformSTCommodity? _PlatformSTCommodity = new();
        public PlatformSTCommodity? PlatformSTCommodity
        {
            get => _PlatformSTCommodity;
            set
            {
                SetValue(ref _PlatformSTCommodity, value);
            }
        }
        public BasePlatformSTCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSTCommodity = await _PlatformActorContext.GetByIdAsync<PlatformSTCommodity>(id);
        }
    }
    public class PostPlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
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
        private PlatformSTCommodity? _postPlatformSTCommodity = new();
        public PlatformSTCommodity? PostPlatformSTCommodity
        {
            get => _postPlatformSTCommodity;
            set
            {
                SetValue(ref _postPlatformSTCommodity, value);
            }
        }
        public PostPlatformSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformSTCommodity PlatformSTCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformSTCommodity>(PlatformSTCommodity);
            if (PostValue != null)
            {
                PostPlatformSTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSTCommodity = new();
            _postPlatformSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
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
        private PlatformSTCommodity? _putPlatformSTCommodity = new();
        public PlatformSTCommodity? PutPlatformSTCommodity
        {
            get => _putPlatformSTCommodity;
            set
            {
                SetValue(ref _putPlatformSTCommodity, value);
            }
        }
        public PutPlatformSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformSTCommodity PlatformSTCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformSTCommodity>(PlatformSTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSTCommodity = new();
            _putPlatformSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
    {
        public DeletePlatformSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformSTCommodity>(id);
        }
        public void Reset()
        {
            PlatformSTCommodity = new();
        }
    }
    public class GetsPlatformSTCommodityViewModel : BasePlatformSTCommodityViewModel
    {
        private List<PlatformSTCommodity> _PlatformSTCommoditys = new();
        public List<PlatformSTCommodity> PlatformSTCommoditys
        {
            get=> _PlatformSTCommoditys;
            set
            {
                SetValue(ref _PlatformSTCommoditys, value);   
            }
        }
        public GetsPlatformSTCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSTCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformSTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformSTCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformSTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformSTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
