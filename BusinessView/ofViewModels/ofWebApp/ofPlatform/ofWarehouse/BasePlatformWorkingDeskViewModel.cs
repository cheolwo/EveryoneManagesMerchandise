using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformWorkingDeskViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformWorkingDesk> _actorViewService;
        protected PlatformWorkingDesk? _PlatformWorkingDesk = new();
        public PlatformWorkingDesk? PlatformWorkingDesk
        {
            get => _PlatformWorkingDesk;
            set
            {
                SetValue(ref _PlatformWorkingDesk, value);
            }
        }
        public BasePlatformWorkingDeskViewModel(IActorViewService<PlatformWorkingDesk> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformWorkingDesk = await _actorViewService.GetByIdAsync(id);
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
        public PostPlatformWorkingDeskViewModel(IActorViewService<PlatformWorkingDesk> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformWorkingDesk PlatformWorkingDesk)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformWorkingDesk);
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
        public PutPlatformWorkingDeskViewModel(IActorViewService<PlatformWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformWorkingDesk PlatformWorkingDesk)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformWorkingDesk);
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
        public DeletePlatformWorkingDeskViewModel(IActorViewService<PlatformWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsPlatformWorkingDeskViewModel(IActorViewService<PlatformWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformWorkingDesk>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformWorkingDesks.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformWorkingDesks.Remove(obj); OnPropertyChanged(); }
        }
    }
}
