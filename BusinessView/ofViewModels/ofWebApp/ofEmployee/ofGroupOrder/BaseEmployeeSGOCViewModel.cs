using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeSGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeSGOC> _actorViewService;
        protected EmployeeSGOC? _EmployeeSGOC = new();
        public EmployeeSGOC? EmployeeSGOC
        {
            get => _EmployeeSGOC;
            set
            {
                SetValue(ref _EmployeeSGOC, value);
            }
        }
        public BaseEmployeeSGOCViewModel(IActorViewService<EmployeeSGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeSGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
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
        private EmployeeSGOC? _postEmployeeSGOC = new();
        public EmployeeSGOC? PostEmployeeSGOC
        {
            get => _postEmployeeSGOC;
            set
            {
                SetValue(ref _postEmployeeSGOC, value);
            }
        }
        public PostEmployeeSGOCViewModel(IActorViewService<EmployeeSGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeSGOC EmployeeSGOC)
        {
            var PostEmployeeSGOC = await _actorViewService.PostAsync(EmployeeSGOC);
            if (PostEmployeeSGOC != null)
            {
                PostEmployeeSGOC = PostEmployeeSGOC;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSGOC = new();
            _postEmployeeSGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
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
        private EmployeeSGOC? _putEmployeeSGOC = new();
        public EmployeeSGOC? PutEmployeeSGOC
        {
            get => _putEmployeeSGOC;
            set
            {
                SetValue(ref _putEmployeeSGOC, value);
            }
        }
        public PutEmployeeSGOCViewModel(IActorViewService<EmployeeSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeSGOC EmployeeSGOC)
        {
            var PutEmployeeSGOC = await _actorViewService.PutAsync(EmployeeSGOC);
            if(PutEmployeeSGOC != null)
            {
                isPut = true;
                PutEmployeeSGOC = PutEmployeeSGOC;
            }
        }
        public void Reset()
        {
            isPut = false;
            _EmployeeSGOC = new();
            _putEmployeeSGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
    {
        public DeleteEmployeeSGOCViewModel(IActorViewService<EmployeeSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeSGOC = new();
        }
    }
    public class GetsEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
    {
        private List<EmployeeSGOC> _EmployeeSGOCs = new();
        public List<EmployeeSGOC> EmployeeSGOCs
        {
            get=> _EmployeeSGOCs;
            set
            {
                SetValue(ref _EmployeeSGOCs, value);   
            }
        }
        public GetsEmployeeSGOCViewModel(IActorViewService<EmployeeSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSGOC>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
