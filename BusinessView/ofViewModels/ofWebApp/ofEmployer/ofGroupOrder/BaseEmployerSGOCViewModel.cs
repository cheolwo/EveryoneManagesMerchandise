using BusinessView.ofGeneric;
using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerSGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerSGOC> _actorViewService;
        protected EmployerSGOC? _EmployerSGOC = new();
        public EmployerSGOC? EmployerSGOC
        {
            get => _EmployerSGOC;
            set
            {
                SetValue(ref _EmployerSGOC, value);
            }
        }
        public BaseEmployerSGOCViewModel(IActorViewService<EmployerSGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerSGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerSGOCViewModel : BaseEmployerSGOCViewModel
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
        private EmployerSGOC? _postEmployerSGOC = new();
        public EmployerSGOC? PostEmployerSGOC
        {
            get => _postEmployerSGOC;
            set
            {
                SetValue(ref _postEmployerSGOC, value);
            }
        }
        public PostEmployerSGOCViewModel(IActorViewService<EmployerSGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerSGOC EmployerSGOC)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerSGOC);
            if (PostValue != null)
            {
                PostEmployerSGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSGOC = new();
            _postEmployerSGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSGOCViewModel : BaseEmployerSGOCViewModel
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
        private EmployerSGOC? _putEmployerSGOC = new();
        public EmployerSGOC? PutEmployerSGOC
        {
            get => _putEmployerSGOC;
            set
            {
                SetValue(ref _putEmployerSGOC, value);
            }
        }
        public PutEmployerSGOCViewModel(IActorViewService<EmployerSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerSGOC EmployerSGOC)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerSGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSGOC = new();
            _putEmployerSGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSGOCViewModel : BaseEmployerSGOCViewModel
    {
        public DeleteEmployerSGOCViewModel(IActorViewService<EmployerSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerSGOC = new();
        }
    }
    public class GetsEmployerSGOCViewModel : BaseEmployerSGOCViewModel
    {
        private List<EmployerSGOC> _EmployerSGOCs = new();
        public List<EmployerSGOC> EmployerSGOCs
        {
            get=> _EmployerSGOCs;
            set
            {
                SetValue(ref _EmployerSGOCs, value);   
            }
        }
        public GetsEmployerSGOCViewModel(IActorViewService<EmployerSGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSGOC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerSGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
