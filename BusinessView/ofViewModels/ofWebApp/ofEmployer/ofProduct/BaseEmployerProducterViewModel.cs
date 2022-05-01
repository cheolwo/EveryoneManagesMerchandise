using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerProducterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerProducter> _actorViewService;
        protected EmployerProducter? _EmployerProducter = new();
        public EmployerProducter? EmployerProducter
        {
            get => _EmployerProducter;
            set
            {
                SetValue(ref _EmployerProducter, value);
            }
        }
        public BaseEmployerProducterViewModel(IActorViewService<EmployerProducter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerProducter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerProducterViewModel : BaseEmployerProducterViewModel
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
        private EmployerProducter? _postEmployerProducter = new();
        public EmployerProducter? PostEmployerProducter
        {
            get => _postEmployerProducter;
            set
            {
                SetValue(ref _postEmployerProducter, value);
            }
        }
        public PostEmployerProducterViewModel(IActorViewService<EmployerProducter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerProducter EmployerProducter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerProducter);
            if (PostValue != null)
            {
                PostEmployerProducter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerProducter = new();
            _postEmployerProducter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerProducterViewModel : BaseEmployerProducterViewModel
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
        private EmployerProducter? _putEmployerProducter = new();
        public EmployerProducter? PutEmployerProducter
        {
            get => _putEmployerProducter;
            set
            {
                SetValue(ref _putEmployerProducter, value);
            }
        }
        public PutEmployerProducterViewModel(IActorViewService<EmployerProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerProducter EmployerProducter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerProducter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerProducter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerProducter = new();
            _putEmployerProducter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerProducterViewModel : BaseEmployerProducterViewModel
    {
        public DeleteEmployerProducterViewModel(IActorViewService<EmployerProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerProducter = new();
        }
    }
    public class GetsEmployerProducterViewModel : BaseEmployerProducterViewModel
    {
        private List<EmployerProducter> _EmployerProducters = new();
        public List<EmployerProducter> EmployerProducters
        {
            get=> _EmployerProducters;
            set
            {
                SetValue(ref _EmployerProducters, value);   
            }
        }
        public GetsEmployerProducterViewModel(IActorViewService<EmployerProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerProducter>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerProducters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerProducters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
