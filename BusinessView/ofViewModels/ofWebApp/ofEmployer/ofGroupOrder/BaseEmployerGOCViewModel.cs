using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerGOC> _actorViewService;
        protected EmployerGOC? _EmployerGOC = new();
        public EmployerGOC? EmployerGOC
        {
            get => _EmployerGOC;
            set
            {
                SetValue(ref _EmployerGOC, value);
            }
        }
        public BaseEmployerGOCViewModel(IActorViewService<EmployerGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerGOCViewModel : BaseEmployerGOCViewModel
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
        private EmployerGOC? _postEmployerGOC = new();
        public EmployerGOC? PostEmployerGOC
        {
            get => _postEmployerGOC;
            set
            {
                SetValue(ref _postEmployerGOC, value);
            }
        }
        public PostEmployerGOCViewModel(IActorViewService<EmployerGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerGOC EmployerGOC)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerGOC);
            if (PostValue != null)
            {
                PostEmployerGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerGOC = new();
            _postEmployerGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerGOCViewModel : BaseEmployerGOCViewModel
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
        private EmployerGOC? _putEmployerGOC = new();
        public EmployerGOC? PutEmployerGOC
        {
            get => _putEmployerGOC;
            set
            {
                SetValue(ref _putEmployerGOC, value);
            }
        }
        public PutEmployerGOCViewModel(IActorViewService<EmployerGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerGOC EmployerGOC)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerGOC = new();
            _putEmployerGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerGOCViewModel : BaseEmployerGOCViewModel
    {
        public DeleteEmployerGOCViewModel(IActorViewService<EmployerGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerGOC = new();
        }
    }
    public class GetsEmployerGOCViewModel : BaseEmployerGOCViewModel
    {
        private List<EmployerGOC> _EmployerGOCs = new();
        public List<EmployerGOC> EmployerGOCs
        {
            get=> _EmployerGOCs;
            set
            {
                SetValue(ref _EmployerGOCs, value);   
            }
        }
        public GetsEmployerGOCViewModel(IActorViewService<EmployerGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerGOC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
