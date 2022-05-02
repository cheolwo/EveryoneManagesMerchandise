using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJournalCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerJournalCenter> _actorViewService;
        protected EmployerJournalCenter? _EmployerJournalCenter = new();
        public EmployerJournalCenter? EmployerJournalCenter
        {
            get => _EmployerJournalCenter;
            set
            {
                SetValue(ref _EmployerJournalCenter, value);
            }
        }
        public BaseEmployerJournalCenterViewModel(IActorViewService<EmployerJournalCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerJournalCenter = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployerJournalCenterViewModel(IActorViewService<EmployerJournalCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerJournalCenter EmployerJournalCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerJournalCenter);
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
        public PutEmployerJournalCenterViewModel(IActorViewService<EmployerJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerJournalCenter EmployerJournalCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerJournalCenter);
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
        public DeleteEmployerJournalCenterViewModel(IActorViewService<EmployerJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployerJournalCenterViewModel(IActorViewService<EmployerJournalCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerJournalCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerJournalCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerJournalCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
