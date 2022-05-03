using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJournalViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformJournal> _actorViewService;
        protected PlatformJournal? _PlatformJournal = new();
        public PlatformJournal? PlatformJournal
        {
            get => _PlatformJournal;
            set
            {
                SetValue(ref _PlatformJournal, value);
            }
        }
        public BasePlatformJournalViewModel(IActorViewService<PlatformJournal> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformJournal = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformJournalViewModel : BasePlatformJournalViewModel
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
        private PlatformJournal? _postPlatformJournal = new();
        public PlatformJournal? PostPlatformJournal
        {
            get => _postPlatformJournal;
            set
            {
                SetValue(ref _postPlatformJournal, value);
            }
        }
        public PostPlatformJournalViewModel(IActorViewService<PlatformJournal> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformJournal PlatformJournal)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformJournal);
            if (PostValue != null)
            {
                PostPlatformJournal = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformJournal = new();
            _postPlatformJournal = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformJournalViewModel : BasePlatformJournalViewModel
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
        private PlatformJournal? _putPlatformJournal = new();
        public PlatformJournal? PutPlatformJournal
        {
            get => _putPlatformJournal;
            set
            {
                SetValue(ref _putPlatformJournal, value);
            }
        }
        public PutPlatformJournalViewModel(IActorViewService<PlatformJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformJournal PlatformJournal)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformJournal);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformJournal = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformJournal = new();
            _putPlatformJournal = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformJournalViewModel : BasePlatformJournalViewModel
    {
        public DeletePlatformJournalViewModel(IActorViewService<PlatformJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformJournal = new();
        }
    }
    public class GetsPlatformJournalViewModel : BasePlatformJournalViewModel
    {
        private List<PlatformJournal> _PlatformJournals = new();
        public List<PlatformJournal> PlatformJournals
        {
            get=> _PlatformJournals;
            set
            {
                SetValue(ref _PlatformJournals, value);   
            }
        }
        public GetsPlatformJournalViewModel(IActorViewService<PlatformJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformJournal>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformJournals.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformJournals.Remove(obj); OnPropertyChanged(); }
        }
    }
}
