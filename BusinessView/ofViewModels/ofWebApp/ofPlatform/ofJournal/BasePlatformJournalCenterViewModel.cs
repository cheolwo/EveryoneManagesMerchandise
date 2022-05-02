using BusinessView.ofDTO.ofJournalDTO.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformJournalCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformJournalCenter> _actorViewService;
        protected PlatformJournalCenter? _PlatformJournalCenter = new();
        public PlatformJournalCenter? PlatformJournalCenter
        {
            get => _PlatformJournalCenter;
            set
            {
                SetValue(ref _PlatformJournalCenter, value);
            }
        }
        public BasePlatformJournalCenterViewModel(IActorViewService<PlatformJournalCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformJournalCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
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
        private PlatformJournalCenter? _postPlatformJournalCenter = new();
        public PlatformJournalCenter? PostPlatformJournalCenter
        {
            get => _postPlatformJournalCenter;
            set
            {
                SetValue(ref _postPlatformJournalCenter, value);
            }
        }
        public PostPlatformJournalCenterViewModel(IActorViewService<PlatformJournalCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformJournalCenter PlatformJournalCenter)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformJournalCenter);
            if (PostValue != null)
            {
                PostPlatformJournalCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformJournalCenter = new();
            _postPlatformJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
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
        private PlatformJournalCenter? _putPlatformJournalCenter = new();
        public PlatformJournalCenter? PutPlatformJournalCenter
        {
            get => _putPlatformJournalCenter;
            set
            {
                SetValue(ref _putPlatformJournalCenter, value);
            }
        }
        public PutPlatformJournalCenterViewModel(IActorViewService<PlatformJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformJournalCenter PlatformJournalCenter)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformJournalCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformJournalCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformJournalCenter = new();
            _putPlatformJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
    {
        public DeletePlatformJournalCenterViewModel(IActorViewService<PlatformJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformJournalCenter = new();
        }
    }
    public class GetsPlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
    {
        private List<PlatformJournalCenter> _PlatformJournalCenters = new();
        public List<PlatformJournalCenter> PlatformJournalCenters
        {
            get=> _PlatformJournalCenters;
            set
            {
                SetValue(ref _PlatformJournalCenters, value);   
            }
        }
        public GetsPlatformJournalCenterViewModel(IActorViewService<PlatformJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformJournalCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformJournalCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformJournalCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
