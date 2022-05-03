using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJCommodityViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformJCommodity? _PlatformJCommodity = new();
        public PlatformJCommodity? PlatformJCommodity
        {
            get => _PlatformJCommodity;
            set
            {
                SetValue(ref _PlatformJCommodity, value);
            }
        }
        public BasePlatformJCommodityViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformJCommodity = await _PlatformActorContext.GetByIdAsync<PlatformJCommodity>(id);
        }
    }
    public class PostPlatformJCommodityViewModel : BasePlatformJCommodityViewModel
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
        private PlatformJCommodity? _postPlatformJCommodity = new();
        public PlatformJCommodity? PostPlatformJCommodity
        {
            get => _postPlatformJCommodity;
            set
            {
                SetValue(ref _postPlatformJCommodity, value);
            }
        }
        public PostPlatformJCommodityViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformJCommodity PlatformJCommodity)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformJCommodity>(PlatformJCommodity);
            if (PostValue != null)
            {
                PostPlatformJCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformJCommodity = new();
            _postPlatformJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformJCommodityViewModel : BasePlatformJCommodityViewModel
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
        private PlatformJCommodity? _putPlatformJCommodity = new();
        public PlatformJCommodity? PutPlatformJCommodity
        {
            get => _putPlatformJCommodity;
            set
            {
                SetValue(ref _putPlatformJCommodity, value);
            }
        }
        public PutPlatformJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformJCommodity PlatformJCommodity)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformJCommodity>(PlatformJCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformJCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformJCommodity = new();
            _putPlatformJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformJCommodityViewModel : BasePlatformJCommodityViewModel
    {
        public DeletePlatformJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformJCommodity>(id);
        }
        public void Reset()
        {
            PlatformJCommodity = new();
        }
    }
    public class GetsPlatformJCommodityViewModel : BasePlatformJCommodityViewModel
    {
        private List<PlatformJCommodity> _PlatformJCommoditys = new();
        public List<PlatformJCommodity> PlatformJCommoditys
        {
            get=> _PlatformJCommoditys;
            set
            {
                SetValue(ref _PlatformJCommoditys, value);   
            }
        }
        public GetsPlatformJCommodityViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformJCommodity>? dtos = await _PlatformActorContext.GetsAsync<PlatformJCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformJCommodity>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformJCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformJCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformJCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
