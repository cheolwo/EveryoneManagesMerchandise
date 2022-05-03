using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct
{
    public class BasePlatformProductLandViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformProductLand? _PlatformProductLand = new();
        public PlatformProductLand? PlatformProductLand
        {
            get => _PlatformProductLand;
            set
            {
                SetValue(ref _PlatformProductLand, value);
            }
        }
        public BasePlatformProductLandViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformProductLand = await _PlatformActorContext.GetByIdAsync<PlatformProductLand>(id);
        }
    }
    public class PostPlatformProductLandViewModel : BasePlatformProductLandViewModel
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
        private PlatformProductLand? _postPlatformProductLand = new();
        public PlatformProductLand? PostPlatformProductLand
        {
            get => _postPlatformProductLand;
            set
            {
                SetValue(ref _postPlatformProductLand, value);
            }
        }
        public PostPlatformProductLandViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformProductLand PlatformProductLand)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformProductLand>(PlatformProductLand);
            if (PostValue != null)
            {
                PostPlatformProductLand = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformProductLand = new();
            _postPlatformProductLand = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformProductLandViewModel : BasePlatformProductLandViewModel
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
        private PlatformProductLand? _putPlatformProductLand = new();
        public PlatformProductLand? PutPlatformProductLand
        {
            get => _putPlatformProductLand;
            set
            {
                SetValue(ref _putPlatformProductLand, value);
            }
        }
        public PutPlatformProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformProductLand PlatformProductLand)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformProductLand>(PlatformProductLand);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformProductLand = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformProductLand = new();
            _putPlatformProductLand = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformProductLandViewModel : BasePlatformProductLandViewModel
    {
        public DeletePlatformProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformProductLand>(id);
        }
        public void Reset()
        {
            PlatformProductLand = new();
        }
    }
    public class GetsPlatformProductLandViewModel : BasePlatformProductLandViewModel
    {
        private List<PlatformProductLand> _PlatformProductLands = new();
        public List<PlatformProductLand> PlatformProductLands
        {
            get=> _PlatformProductLands;
            set
            {
                SetValue(ref _PlatformProductLands, value);   
            }
        }
        public GetsPlatformProductLandViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformProductLand>? dtos = await _PlatformActorContext.GetsAsync<PlatformProductLand>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformProductLand>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformProductLand>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformProductLands.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformProductLands.Remove(obj); OnPropertyChanged(); }
        }
    }
}
