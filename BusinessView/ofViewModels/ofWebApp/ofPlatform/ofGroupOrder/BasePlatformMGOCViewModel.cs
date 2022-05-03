using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformMGOCViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformMGOC? _PlatformMGOC = new();
        public PlatformMGOC? PlatformMGOC
        {
            get => _PlatformMGOC;
            set
            {
                SetValue(ref _PlatformMGOC, value);
            }
        }
        public BasePlatformMGOCViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformMGOC = await _PlatformActorContext.GetByIdAsync<PlatformMGOC>(id);
        }
    }
    public class PostPlatformMGOCViewModel : BasePlatformMGOCViewModel
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
        private PlatformMGOC? _postPlatformMGOC = new();
        public PlatformMGOC? PostPlatformMGOC
        {
            get => _postPlatformMGOC;
            set
            {
                SetValue(ref _postPlatformMGOC, value);
            }
        }
        public PostPlatformMGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformMGOC PlatformMGOC)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformMGOC>(PlatformMGOC);
            if (PostValue != null)
            {
                PostPlatformMGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformMGOC = new();
            _postPlatformMGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformMGOCViewModel : BasePlatformMGOCViewModel
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
        private PlatformMGOC? _putPlatformMGOC = new();
        public PlatformMGOC? PutPlatformMGOC
        {
            get => _putPlatformMGOC;
            set
            {
                SetValue(ref _putPlatformMGOC, value);
            }
        }
        public PutPlatformMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformMGOC PlatformMGOC)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformMGOC>(PlatformMGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformMGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformMGOC = new();
            _putPlatformMGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformMGOCViewModel : BasePlatformMGOCViewModel
    {
        public DeletePlatformMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformMGOC>(id);
        }
        public void Reset()
        {
            PlatformMGOC = new();
        }
    }
    public class GetsPlatformMGOCViewModel : BasePlatformMGOCViewModel
    {
        private List<PlatformMGOC> _PlatformMGOCs = new();
        public List<PlatformMGOC> PlatformMGOCs
        {
            get=> _PlatformMGOCs;
            set
            {
                SetValue(ref _PlatformMGOCs, value);   
            }
        }
        public GetsPlatformMGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformMGOC>? dtos = await _PlatformActorContext.GetsAsync<PlatformMGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformMGOC>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformMGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformMGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformMGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
