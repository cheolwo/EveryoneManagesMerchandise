using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJournalCenterViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeJournalCenter? _EmployeeJournalCenter = new();
        public EmployeeJournalCenter? EmployeeJournalCenter
        {
            get => _EmployeeJournalCenter;
            set
            {
                SetValue(ref _EmployeeJournalCenter, value);
            }
        }
        public BaseEmployeeJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeJournalCenter = await _EmployeeActorContext.GetByIdAsync<EmployeeJournalCenter>(id);
        }
    }
    public class PostEmployeeJournalCenterViewModel : BaseEmployeeJournalCenterViewModel
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
        private EmployeeJournalCenter? _postEmployeeJournalCenter = new();
        public EmployeeJournalCenter? PostEmployeeJournalCenter
        {
            get => _postEmployeeJournalCenter;
            set
            {
                SetValue(ref _postEmployeeJournalCenter, value);
            }
        }
        public PostEmployeeJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeJournalCenter EmployeeJournalCenter)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeJournalCenter>(EmployeeJournalCenter);
            if (PostValue != null)
            {
                PostEmployeeJournalCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeJournalCenter = new();
            _postEmployeeJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeJournalCenterViewModel : BaseEmployeeJournalCenterViewModel
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
        private EmployeeJournalCenter? _putEmployeeJournalCenter = new();
        public EmployeeJournalCenter? PutEmployeeJournalCenter
        {
            get => _putEmployeeJournalCenter;
            set
            {
                SetValue(ref _putEmployeeJournalCenter, value);
            }
        }
        public PutEmployeeJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeJournalCenter EmployeeJournalCenter)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeJournalCenter>(EmployeeJournalCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeJournalCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeJournalCenter = new();
            _putEmployeeJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeJournalCenterViewModel : BaseEmployeeJournalCenterViewModel
    {
        public DeleteEmployeeJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeJournalCenter>(id);
        }
        public void Reset()
        {
            EmployeeJournalCenter = new();
        }
    }
    public class GetsEmployeeJournalCenterViewModel : BaseEmployeeJournalCenterViewModel
    {
        private List<EmployeeJournalCenter> _EmployeeJournalCenters = new();
        public List<EmployeeJournalCenter> EmployeeJournalCenters
        {
            get=> _EmployeeJournalCenters;
            set
            {
                SetValue(ref _EmployeeJournalCenters, value);   
            }
        }
        public GetsEmployeeJournalCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeJournalCenter>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeJournalCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeJournalCenter>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeJournalCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeJournalCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeJournalCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
