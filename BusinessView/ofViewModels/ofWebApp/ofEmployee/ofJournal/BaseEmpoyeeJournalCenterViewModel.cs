using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJournalCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeJournalCenter> _actorViewService;
        protected EmployeeJournalCenter? _EmployeeJournalCenter = new();
        public EmployeeJournalCenter? EmployeeJournalCenter
        {
            get => _EmployeeJournalCenter;
            set
            {
                SetValue(ref _EmployeeJournalCenter, value);
            }
        }
        public BaseEmployeeJournalCenterViewModel(IActorViewService<EmployeeJournalCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeJournalCenter = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployeeJournalCenterViewModel(IActorViewService<EmployeeJournalCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeJournalCenter EmployeeJournalCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeJournalCenter);
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
        public PutEmployeeJournalCenterViewModel(IActorViewService<EmployeeJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeJournalCenter EmployeeJournalCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeJournalCenter);
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
        public DeleteEmployeeJournalCenterViewModel(IActorViewService<EmployeeJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployeeJournalCenterViewModel(IActorViewService<EmployeeJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeJournalCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeJournalCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeJournalCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
