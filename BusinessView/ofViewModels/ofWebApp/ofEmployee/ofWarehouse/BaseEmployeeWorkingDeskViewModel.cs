using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeWorkingDeskViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeWorkingDesk> _actorViewService;
        protected EmployeeWorkingDesk? _EmployeeWorkingDesk = new();
        public EmployeeWorkingDesk? EmployeeWorkingDesk
        {
            get => _EmployeeWorkingDesk;
            set
            {
                SetValue(ref _EmployeeWorkingDesk, value);
            }
        }
        public BaseEmployeeWorkingDeskViewModel(IActorViewService<EmployeeWorkingDesk> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeWorkingDesk = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
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
        private EmployeeWorkingDesk? _postEmployeeWorkingDesk = new();
        public EmployeeWorkingDesk? PostEmployeeWorkingDesk
        {
            get => _postEmployeeWorkingDesk;
            set
            {
                SetValue(ref _postEmployeeWorkingDesk, value);
            }
        }
        public PostEmployeeWorkingDeskViewModel(IActorViewService<EmployeeWorkingDesk> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeWorkingDesk EmployeeWorkingDesk)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeWorkingDesk);
            if (PostValue != null)
            {
                PostEmployeeWorkingDesk = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeWorkingDesk = new();
            _postEmployeeWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
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
        private EmployeeWorkingDesk? _putEmployeeWorkingDesk = new();
        public EmployeeWorkingDesk? PutEmployeeWorkingDesk
        {
            get => _putEmployeeWorkingDesk;
            set
            {
                SetValue(ref _putEmployeeWorkingDesk, value);
            }
        }
        public PutEmployeeWorkingDeskViewModel(IActorViewService<EmployeeWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeWorkingDesk EmployeeWorkingDesk)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeWorkingDesk);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeWorkingDesk = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeWorkingDesk = new();
            _putEmployeeWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
    {
        public DeleteEmployeeWorkingDeskViewModel(IActorViewService<EmployeeWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeWorkingDesk = new();
        }
    }
    public class GetsEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
    {
        private List<EmployeeWorkingDesk> _EmployeeWorkingDesks = new();
        public List<EmployeeWorkingDesk> EmployeeWorkingDesks
        {
            get=> _EmployeeWorkingDesks;
            set
            {
                SetValue(ref _EmployeeWorkingDesks, value);   
            }
        }
        public GetsEmployeeWorkingDeskViewModel(IActorViewService<EmployeeWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeWorkingDesk>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeWorkingDesks.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeWorkingDesks.Remove(obj); OnPropertyChanged(); }
        }
    }
}
