using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJournalCenterViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerJournalCenter? _EmployerJournalCenter = new();
        public EmployerJournalCenter? EmployerJournalCenter
        {
            get => _EmployerJournalCenter;
            set
            {
                SetValue(ref _EmployerJournalCenter, value);
            }
        }
        public BaseEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerJournalCenter = await _EmployerActorContext.GetByIdAsync<EmployerJournalCenter>(id);
        }
    }
    public class PostEmployerJournalCenterViewModel : BaseEmployerJournalCenterViewModel
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
        private EmployerJournalCenter? _postEmployerJournalCenter = new();
        public EmployerJournalCenter? PostEmployerJournalCenter
        {
            get => _postEmployerJournalCenter;
            set
            {
                SetValue(ref _postEmployerJournalCenter, value);
            }
        }
        public PostEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerJournalCenter EmployerJournalCenter)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerJournalCenter>(EmployerJournalCenter);
            if (PostValue != null)
            {
                PostEmployerJournalCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerJournalCenter = new();
            _postEmployerJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerJournalCenterViewModel : BaseEmployerJournalCenterViewModel
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
        private EmployerJournalCenter? _putEmployerJournalCenter = new();
        public EmployerJournalCenter? PutEmployerJournalCenter
        {
            get => _putEmployerJournalCenter;
            set
            {
                SetValue(ref _putEmployerJournalCenter, value);
            }
        }
        public PutEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerJournalCenter EmployerJournalCenter)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerJournalCenter>(EmployerJournalCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerJournalCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerJournalCenter = new();
            _putEmployerJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerJournalCenterViewModel : BaseEmployerJournalCenterViewModel
    {
        public DeleteEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerJournalCenter>(id);
        }
        public void Reset()
        {
            EmployerJournalCenter = new();
        }
    }
    public class GetsEmployerJournalCenterViewModel : BaseEmployerJournalCenterViewModel
    {
        private List<EmployerJournalCenter> _EmployerJournalCenters = new();
        public List<EmployerJournalCenter> EmployerJournalCenters
        {
            get=> _EmployerJournalCenters;
            set
            {
                SetValue(ref _EmployerJournalCenters, value);   
            }
        }
        public GetsEmployerJournalCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerJournalCenter>? dtos = await _EmployerActorContext.GetsAsync<EmployerJournalCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerJournalCenter>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerJournalCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerJournalCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerJournalCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
