using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMGOC> _actorViewService;
        protected EmployeeMGOC? _EmployeeMGOC = new();
        public EmployeeMGOC? EmployeeMGOC
        {
            get => _EmployeeMGOC;
            set
            {
                SetValue(ref _EmployeeMGOC, value);
            }
        }
        public BaseEmployeeMGOCViewModel(IActorViewService<EmployeeMGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
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
        private EmployeeMGOC? _postEmployeeMGOC = new();
        public EmployeeMGOC? PostEmployeeMGOC
        {
            get => _postEmployeeMGOC;
            set
            {
                SetValue(ref _postEmployeeMGOC, value);
            }
        }
        public PostEmployeeMGOCViewModel(IActorViewService<EmployeeMGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMGOC EmployeeMGOC)
        {
            var PostEmployeeMGOC = await _actorViewService.PostAsync(EmployeeMGOC);
            if (PostEmployeeMGOC != null)
            {
                PostEmployeeMGOC = PostEmployeeMGOC;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMGOC = new();
            _postEmployeeMGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
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
        private EmployeeMGOC? _putEmployeeMGOC = new();
        public EmployeeMGOC? PutEmployeeMGOC
        {
            get => _putEmployeeMGOC;
            set
            {
                SetValue(ref _putEmployeeMGOC, value);
            }
        }
        public PutEmployeeMGOCViewModel(IActorViewService<EmployeeMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMGOC EmployeeMGOC)
        {
            var PutEmployeeMGOC = await _actorViewService.PutAsync(EmployeeMGOC);
            if(PutEmployeeMGOC != null)
            {
                isPut = true;
                PutEmployeeMGOC = PutEmployeeMGOC;
            }
        }
        public void Reset()
        {
            isPut = false;
            _EmployeeMGOC = new();
            _putEmployeeMGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
    {
        public DeleteEmployeeMGOCViewModel(IActorViewService<EmployeeMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMGOC = new();
        }
    }
    public class GetsEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
    {
        private List<EmployeeMGOC> _EmployeeMGOCs = new();
        public List<EmployeeMGOC> EmployeeMGOCs
        {
            get=> _EmployeeMGOCs;
            set
            {
                SetValue(ref _EmployeeMGOCs, value);   
            }
        }
        public GetsEmployeeMGOCViewModel(IActorViewService<EmployeeMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMGOC>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
