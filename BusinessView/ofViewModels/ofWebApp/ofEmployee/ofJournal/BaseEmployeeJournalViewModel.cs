using BusinessView.ofDTO.ofJournalDTO.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJournalViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeJournal> _actorViewService;
        protected EmployeeJournal? _EmployeeJournal = new();
        public EmployeeJournal? EmployeeJournal
        {
            get => _EmployeeJournal;
            set
            {
                SetValue(ref _EmployeeJournal, value);
            }
        }
        public BaseEmployeeJournalViewModel(IActorViewService<EmployeeJournal> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeJournal = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeJournalViewModel : BaseEmployeeJournalViewModel
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
        private EmployeeJournal? _postEmployeeJournal = new();
        public EmployeeJournal? PostEmployeeJournal
        {
            get => _postEmployeeJournal;
            set
            {
                SetValue(ref _postEmployeeJournal, value);
            }
        }
        public PostEmployeeJournalViewModel(IActorViewService<EmployeeJournal> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeJournal EmployeeJournal)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeJournal);
            if (PostValue != null)
            {
                PostEmployeeJournal = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeJournal = new();
            _postEmployeeJournal = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeJournalViewModel : BaseEmployeeJournalViewModel
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
        private EmployeeJournal? _putEmployeeJournal = new();
        public EmployeeJournal? PutEmployeeJournal
        {
            get => _putEmployeeJournal;
            set
            {
                SetValue(ref _putEmployeeJournal, value);
            }
        }
        public PutEmployeeJournalViewModel(IActorViewService<EmployeeJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeJournal EmployeeJournal)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeJournal);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeJournal = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeJournal = new();
            _putEmployeeJournal = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeJournalViewModel : BaseEmployeeJournalViewModel
    {
        public DeleteEmployeeJournalViewModel(IActorViewService<EmployeeJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeJournal = new();
        }
    }
    public class GetsEmployeeJournalViewModel : BaseEmployeeJournalViewModel
    {
        private List<EmployeeJournal> _EmployeeJournals = new();
        public List<EmployeeJournal> EmployeeJournals
        {
            get=> _EmployeeJournals;
            set
            {
                SetValue(ref _EmployeeJournals, value);   
            }
        }
        public GetsEmployeeJournalViewModel(IActorViewService<EmployeeJournal> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeJournal>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeJournals.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeJournals.Remove(obj); OnPropertyChanged(); }
        }
    }
}
