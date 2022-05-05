using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWorkingDeskViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformWorkingDesk? _PlatformWorkingDesk = new();
        public PlatformWorkingDesk? PlatformWorkingDesk
        {
            get => _PlatformWorkingDesk;
            set
            {
                SetValue(ref _PlatformWorkingDesk, value);
            }
        }
        public BasePlatformWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformWorkingDesk = await _PlatformActorContext.GetByIdAsync<PlatformWorkingDesk>(id);
        }
    }
    public class PostPlatformWorkingDeskViewModel : BasePlatformWorkingDeskViewModel
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
        private PlatformWorkingDesk? _postPlatformWorkingDesk = new();
        public PlatformWorkingDesk? PostPlatformWorkingDesk
        {
            get => _postPlatformWorkingDesk;
            set
            {
                SetValue(ref _postPlatformWorkingDesk, value);
            }
        }
        public PostPlatformWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformWorkingDesk PlatformWorkingDesk)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformWorkingDesk>(PlatformWorkingDesk);
            if (PostValue != null)
            {
                PostPlatformWorkingDesk = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformWorkingDesk = new();
            _postPlatformWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformWorkingDeskViewModel : BasePlatformWorkingDeskViewModel
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
        private PlatformWorkingDesk? _putPlatformWorkingDesk = new();
        public PlatformWorkingDesk? PutPlatformWorkingDesk
        {
            get => _putPlatformWorkingDesk;
            set
            {
                SetValue(ref _putPlatformWorkingDesk, value);
            }
        }
        public PutPlatformWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformWorkingDesk PlatformWorkingDesk)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformWorkingDesk>(PlatformWorkingDesk);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformWorkingDesk = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformWorkingDesk = new();
            _putPlatformWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformWorkingDeskViewModel : BasePlatformWorkingDeskViewModel
    {
        public DeletePlatformWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformWorkingDesk>(id);
        }
        public void Reset()
        {
            PlatformWorkingDesk = new();
        }
    }
    public class GetsPlatformWorkingDeskViewModel : BasePlatformWorkingDeskViewModel
    {
        private List<PlatformWorkingDesk> _PlatformWorkingDesks = new();
        public List<PlatformWorkingDesk> PlatformWorkingDesks
        {
            get=> _PlatformWorkingDesks;
            set
            {
                SetValue(ref _PlatformWorkingDesks, value);   
            }
        }
        public GetsPlatformWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformWorkingDesk>? dtos = await _PlatformActorContext.GetsAsync<PlatformWorkingDesk>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformWorkingDesk>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformWorkingDesk>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformWorkingDesks.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformWorkingDesks.Remove(obj); OnPropertyChanged(); }
        }
    }
}
