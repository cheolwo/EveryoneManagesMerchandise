using BusinessView.ofGeneric;
using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployerEGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerEGOC> _actorViewService;
        protected EmployerEGOC? _EmployerEGOC = new();
        public EmployerEGOC? EmployerEGOC
        {
            get => _EmployerEGOC;
            set
            {
                SetValue(ref _EmployerEGOC, value);
            }
        }
        public BaseEmployerEGOCViewModel(IActorViewService<EmployerEGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerEGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerEGOCViewModel : BaseEmployerEGOCViewModel
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
        private EmployerEGOC? _postEmployerEGOC = new();
        public EmployerEGOC? PostEmployerEGOC
        {
            get => _postEmployerEGOC;
            set
            {
                SetValue(ref _postEmployerEGOC, value);
            }
        }
        public PostEmployerEGOCViewModel(IActorViewService<EmployerEGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerEGOC EmployerEGOC)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerEGOC);
            if (PostValue != null)
            {
                PostEmployerEGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEGOC = new();
            _postEmployerEGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEGOCViewModel : BaseEmployerEGOCViewModel
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
        private EmployerEGOC? _putEmployerEGOC = new();
        public EmployerEGOC? PutEmployerEGOC
        {
            get => _putEmployerEGOC;
            set
            {
                SetValue(ref _putEmployerEGOC, value);
            }
        }
        public PutEmployerEGOCViewModel(IActorViewService<EmployerEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerEGOC EmployerEGOC)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerEGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEGOC = new();
            _putEmployerEGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEGOCViewModel : BaseEmployerEGOCViewModel
    {
        public DeleteEmployerEGOCViewModel(IActorViewService<EmployerEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerEGOC = new();
        }
    }
    public class GetsEmployerEGOCViewModel : BaseEmployerEGOCViewModel
    {
        private List<EmployerEGOC> _EmployerEGOCs = new();
        public List<EmployerEGOC> EmployerEGOCs
        {
            get=> _EmployerEGOCs;
            set
            {
                SetValue(ref _EmployerEGOCs, value);   
            }
        }
        public GetsEmployerEGOCViewModel(IActorViewService<EmployerEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEGOC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerEGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
