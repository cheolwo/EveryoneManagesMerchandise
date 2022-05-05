using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformSGOCViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformSGOC? _PlatformSGOC = new();
        public PlatformSGOC? PlatformSGOC
        {
            get => _PlatformSGOC;
            set
            {
                SetValue(ref _PlatformSGOC, value);
            }
        }
        public BasePlatformSGOCViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformSGOC = await _PlatformActorContext.GetByIdAsync<PlatformSGOC>(id);
        }
    }
    public class PostPlatformSGOCViewModel : BasePlatformSGOCViewModel
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
        private PlatformSGOC? _postPlatformSGOC = new();
        public PlatformSGOC? PostPlatformSGOC
        {
            get => _postPlatformSGOC;
            set
            {
                SetValue(ref _postPlatformSGOC, value);
            }
        }
        public PostPlatformSGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformSGOC PlatformSGOC)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformSGOC>(PlatformSGOC);
            if (PostValue != null)
            {
                PostPlatformSGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformSGOC = new();
            _postPlatformSGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformSGOCViewModel : BasePlatformSGOCViewModel
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
        private PlatformSGOC? _putPlatformSGOC = new();
        public PlatformSGOC? PutPlatformSGOC
        {
            get => _putPlatformSGOC;
            set
            {
                SetValue(ref _putPlatformSGOC, value);
            }
        }
        public PutPlatformSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformSGOC PlatformSGOC)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformSGOC>(PlatformSGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformSGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformSGOC = new();
            _putPlatformSGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformSGOCViewModel : BasePlatformSGOCViewModel
    {
        public DeletePlatformSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformSGOC>(id);
        }
        public void Reset()
        {
            PlatformSGOC = new();
        }
    }
    public class GetsPlatformSGOCViewModel : BasePlatformSGOCViewModel
    {
        private List<PlatformSGOC> _PlatformSGOCs = new();
        public List<PlatformSGOC> PlatformSGOCs
        {
            get=> _PlatformSGOCs;
            set
            {
                SetValue(ref _PlatformSGOCs, value);   
            }
        }
        public GetsPlatformSGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformSGOC>? dtos = await _PlatformActorContext.GetsAsync<PlatformSGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformSGOC>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformSGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformSGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformSGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
