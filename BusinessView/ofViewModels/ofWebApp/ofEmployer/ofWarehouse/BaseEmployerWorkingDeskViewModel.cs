using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWorkingDeskViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerWorkingDesk> _actorViewService;
        protected EmployerWorkingDesk? _EmployerWorkingDesk = new();
        public EmployerWorkingDesk? EmployerWorkingDesk
        {
            get => _EmployerWorkingDesk;
            set
            {
                SetValue(ref _EmployerWorkingDesk, value);
            }
        }
        public BaseEmployerWorkingDeskViewModel(IActorViewService<EmployerWorkingDesk> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerWorkingDesk = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
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
        private EmployerWorkingDesk? _postEmployerWorkingDesk = new();
        public EmployerWorkingDesk? PostEmployerWorkingDesk
        {
            get => _postEmployerWorkingDesk;
            set
            {
                SetValue(ref _postEmployerWorkingDesk, value);
            }
        }
        public PostEmployerWorkingDeskViewModel(IActorViewService<EmployerWorkingDesk> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerWorkingDesk EmployerWorkingDesk)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerWorkingDesk);
            if (PostValue != null)
            {
                PostEmployerWorkingDesk = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerWorkingDesk = new();
            _postEmployerWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
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
        private EmployerWorkingDesk? _putEmployerWorkingDesk = new();
        public EmployerWorkingDesk? PutEmployerWorkingDesk
        {
            get => _putEmployerWorkingDesk;
            set
            {
                SetValue(ref _putEmployerWorkingDesk, value);
            }
        }
        public PutEmployerWorkingDeskViewModel(IActorViewService<EmployerWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerWorkingDesk EmployerWorkingDesk)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerWorkingDesk);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerWorkingDesk = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerWorkingDesk = new();
            _putEmployerWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
    {
        public DeleteEmployerWorkingDeskViewModel(IActorViewService<EmployerWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerWorkingDesk = new();
        }
    }
    public class GetsEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
    {
        private List<EmployerWorkingDesk> _EmployerWorkingDesks = new();
        public List<EmployerWorkingDesk> EmployerWorkingDesks
        {
            get=> _EmployerWorkingDesks;
            set
            {
                SetValue(ref _EmployerWorkingDesks, value);   
            }
        }
        public GetsEmployerWorkingDeskViewModel(IActorViewService<EmployerWorkingDesk> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerWorkingDesk>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerWorkingDesks.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerWorkingDesks.Remove(obj); OnPropertyChanged(); }
        }
    }
}
