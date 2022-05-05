using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformGOCCViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformGOCC? _PlatformGOCC = new();
        public PlatformGOCC? PlatformGOCC
        {
            get => _PlatformGOCC;
            set
            {
                SetValue(ref _PlatformGOCC, value);
            }
        }
        public BasePlatformGOCCViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformGOCC = await _PlatformActorContext.GetByIdAsync<PlatformGOCC>(id);
        }
    }
    public class PostPlatformGOCCViewModel : BasePlatformGOCCViewModel
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
        private PlatformGOCC? _postPlatformGOCC = new();
        public PlatformGOCC? PostPlatformGOCC
        {
            get => _postPlatformGOCC;
            set
            {
                SetValue(ref _postPlatformGOCC, value);
            }
        }
        public PostPlatformGOCCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformGOCC PlatformGOCC)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformGOCC>(PlatformGOCC);
            if (PostValue != null)
            {
                PostPlatformGOCC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformGOCC = new();
            _postPlatformGOCC = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformGOCCViewModel : BasePlatformGOCCViewModel
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
        private PlatformGOCC? _putPlatformGOCC = new();
        public PlatformGOCC? PutPlatformGOCC
        {
            get => _putPlatformGOCC;
            set
            {
                SetValue(ref _putPlatformGOCC, value);
            }
        }
        public PutPlatformGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformGOCC PlatformGOCC)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformGOCC>(PlatformGOCC);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformGOCC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformGOCC = new();
            _putPlatformGOCC = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformGOCCViewModel : BasePlatformGOCCViewModel
    {
        public DeletePlatformGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformGOCC>(id);
        }
        public void Reset()
        {
            PlatformGOCC = new();
        }
    }
    public class GetsPlatformGOCCViewModel : BasePlatformGOCCViewModel
    {
        private List<PlatformGOCC> _PlatformGOCCs = new();
        public List<PlatformGOCC> PlatformGOCCs
        {
            get=> _PlatformGOCCs;
            set
            {
                SetValue(ref _PlatformGOCCs, value);   
            }
        }
        public GetsPlatformGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformGOCC>? dtos = await _PlatformActorContext.GetsAsync<PlatformGOCC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformGOCC>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformGOCC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformGOCCs.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformGOCCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
