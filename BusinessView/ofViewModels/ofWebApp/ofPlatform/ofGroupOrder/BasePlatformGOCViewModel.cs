using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformGOCViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformGOC? _PlatformGOC = new();
        public PlatformGOC? PlatformGOC
        {
            get => _PlatformGOC;
            set
            {
                SetValue(ref _PlatformGOC, value);
            }
        }
        public BasePlatformGOCViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformGOC = await _PlatformActorContext.GetByIdAsync<PlatformGOC>(id);
        }
    }
    public class PostPlatformGOCViewModel : BasePlatformGOCViewModel
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
        private PlatformGOC? _postPlatformGOC = new();
        public PlatformGOC? PostPlatformGOC
        {
            get => _postPlatformGOC;
            set
            {
                SetValue(ref _postPlatformGOC, value);
            }
        }
        public PostPlatformGOCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformGOC PlatformGOC)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformGOC>(PlatformGOC);
            if (PostValue != null)
            {
                PostPlatformGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformGOC = new();
            _postPlatformGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformGOCViewModel : BasePlatformGOCViewModel
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
        private PlatformGOC? _putPlatformGOC = new();
        public PlatformGOC? PutPlatformGOC
        {
            get => _putPlatformGOC;
            set
            {
                SetValue(ref _putPlatformGOC, value);
            }
        }
        public PutPlatformGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformGOC PlatformGOC)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformGOC>(PlatformGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformGOC = new();
            _putPlatformGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformGOCViewModel : BasePlatformGOCViewModel
    {
        public DeletePlatformGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformGOC>(id);
        }
        public void Reset()
        {
            PlatformGOC = new();
        }
    }
    public class GetsPlatformGOCViewModel : BasePlatformGOCViewModel
    {
        private List<PlatformGOC> _PlatformGOCs = new();
        public List<PlatformGOC> PlatformGOCs
        {
            get=> _PlatformGOCs;
            set
            {
                SetValue(ref _PlatformGOCs, value);   
            }
        }
        public GetsPlatformGOCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformGOC>? dtos = await _PlatformActorContext.GetsAsync<PlatformGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformGOC>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
