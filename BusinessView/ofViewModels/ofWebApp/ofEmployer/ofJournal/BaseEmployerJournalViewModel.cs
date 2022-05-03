using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJournalViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerJournal? _EmployerJournal = new();
        public EmployerJournal? EmployerJournal
        {
            get => _EmployerJournal;
            set
            {
                SetValue(ref _EmployerJournal, value);
            }
        }
        public BaseEmployerJournalViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerJournal = await _EmployerActorContext.GetByIdAsync<EmployerJournal>(id);
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
        public PostEmployerJournalViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerJournal EmployerJournal)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerJournal>(EmployerJournal);
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
        public PutEmployerJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerJournal EmployerJournal)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerJournal>(EmployerJournal);
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
        public DeleteEmployerJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerJournal>(id);
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
        public GetsEmployerJournalViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerJournal>? dtos = await _EmployerActorContext.GetsAsync<EmployerJournal>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerJournal>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerJournal>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerJournals.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerJournals.Remove(obj); OnPropertyChanged(); }
        }
    }
}
