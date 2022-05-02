using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerJournalViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerJournal> _actorViewService;
        protected EmployerJournal? _EmployerJournal = new();
        public EmployerJournal? EmployerJournal
        {
            get => _EmployerJournal;
            set
            {
                SetValue(ref _EmployerJournal, value);
            }
        }
        public BaseEmployerJournalViewModel(IActorViewService<EmployerJournal> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerJournal = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerJournalViewModel : BaseEmployerJournalViewModel
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
        private EmployerJournal? _postEmployerJournal = new();
        public EmployerJournal? PostEmployerJournal
        {
            get => _postEmployerJournal;
            set
            {
                SetValue(ref _postEmployerJournal, value);
            }
        }
        public PostEmployerJournalViewModel(IActorViewService<EmployerJournal> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerJournal EmployerJournal)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerJournal);
            if (PostValue != null)
            {
                PostEmployerJournal = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerJournal = new();
            _postEmployerJournal = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerJournalViewModel : BaseEmployerJournalViewModel
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
        private EmployerJournal? _putEmployerJournal = new();
        public EmployerJournal? PutEmployerJournal
        {
            get => _putEmployerJournal;
            set
            {
                SetValue(ref _putEmployerJournal, value);
            }
        }
        public PutEmployerJournalViewModel(IActorViewService<EmployerJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerJournal EmployerJournal)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerJournal);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerJournal = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerJournal = new();
            _putEmployerJournal = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerJournalViewModel : BaseEmployerJournalViewModel
    {
        public DeleteEmployerJournalViewModel(IActorViewService<EmployerJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerJournal = new();
        }
    }
    public class GetsEmployerJournalViewModel : BaseEmployerJournalViewModel
    {
        private List<EmployerJournal> _EmployerJournals = new();
        public List<EmployerJournal> EmployerJournals
        {
            get=> _EmployerJournals;
            set
            {
                SetValue(ref _EmployerJournals, value);   
            }
        }
        public GetsEmployerJournalViewModel(IActorViewService<EmployerJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerJournal>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerJournals.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerJournals.Remove(obj); OnPropertyChanged(); }
        }
    }
}
