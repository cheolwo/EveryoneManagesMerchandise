using BusinessView.ofGeneric;
using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerMGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerMGOC> _actorViewService;
        protected EmployerMGOC? _EmployerMGOC = new();
        public EmployerMGOC? EmployerMGOC
        {
            get => _EmployerMGOC;
            set
            {
                SetValue(ref _EmployerMGOC, value);
            }
        }
        public BaseEmployerMGOCViewModel(IActorViewService<EmployerMGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerMGOCViewModel : BaseEmployerMGOCViewModel
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
        private EmployerMGOC? _postEmployerMGOC = new();
        public EmployerMGOC? PostEmployerMGOC
        {
            get => _postEmployerMGOC;
            set
            {
                SetValue(ref _postEmployerMGOC, value);
            }
        }
        public PostEmployerMGOCViewModel(IActorViewService<EmployerMGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerMGOC EmployerMGOC)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerMGOC);
            if (PostValue != null)
            {
                PostEmployerMGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMGOC = new();
            _postEmployerMGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMGOCViewModel : BaseEmployerMGOCViewModel
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
        private EmployerMGOC? _putEmployerMGOC = new();
        public EmployerMGOC? PutEmployerMGOC
        {
            get => _putEmployerMGOC;
            set
            {
                SetValue(ref _putEmployerMGOC, value);
            }
        }
        public PutEmployerMGOCViewModel(IActorViewService<EmployerMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerMGOC EmployerMGOC)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerMGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMGOC = new();
            _putEmployerMGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMGOCViewModel : BaseEmployerMGOCViewModel
    {
        public DeleteEmployerMGOCViewModel(IActorViewService<EmployerMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerMGOC = new();
        }
    }
    public class GetsEmployerMGOCViewModel : BaseEmployerMGOCViewModel
    {
        private List<EmployerMGOC> _EmployerMGOCs = new();
        public List<EmployerMGOC> EmployerMGOCs
        {
            get=> _EmployerMGOCs;
            set
            {
                SetValue(ref _EmployerMGOCs, value);   
            }
        }
        public GetsEmployerMGOCViewModel(IActorViewService<EmployerMGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMGOC>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerMGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
