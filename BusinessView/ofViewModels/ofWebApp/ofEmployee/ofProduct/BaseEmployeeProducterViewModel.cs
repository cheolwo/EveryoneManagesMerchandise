using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeProducterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeProducter> _actorViewService;
        protected EmployeeProducter? _EmployeeProducter = new();
        public EmployeeProducter? EmployeeProducter
        {
            get => _EmployeeProducter;
            set
            {
                SetValue(ref _EmployeeProducter, value);
            }
        }
        public BaseEmployeeProducterViewModel(IActorViewService<EmployeeProducter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeProducter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeProducterViewModel : BaseEmployeeProducterViewModel
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
        private EmployeeProducter? _postEmployeeProducter = new();
        public EmployeeProducter? PostEmployeeProducter
        {
            get => _postEmployeeProducter;
            set
            {
                SetValue(ref _postEmployeeProducter, value);
            }
        }
        public PostEmployeeProducterViewModel(IActorViewService<EmployeeProducter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeProducter EmployeeProducter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeProducter);
            if (PostValue != null)
            {
                PostEmployeeProducter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeProducter = new();
            _postEmployeeProducter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeProducterViewModel : BaseEmployeeProducterViewModel
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
        private EmployeeProducter? _putEmployeeProducter = new();
        public EmployeeProducter? PutEmployeeProducter
        {
            get => _putEmployeeProducter;
            set
            {
                SetValue(ref _putEmployeeProducter, value);
            }
        }
        public PutEmployeeProducterViewModel(IActorViewService<EmployeeProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeProducter EmployeeProducter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeProducter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeProducter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeProducter = new();
            _putEmployeeProducter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeProducterViewModel : BaseEmployeeProducterViewModel
    {
        public DeleteEmployeeProducterViewModel(IActorViewService<EmployeeProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeProducter = new();
        }
    }
    public class GetsEmployeeProducterViewModel : BaseEmployeeProducterViewModel
    {
        private List<EmployeeProducter> _EmployeeProducters = new();
        public List<EmployeeProducter> EmployeeProducters
        {
            get=> _EmployeeProducters;
            set
            {
                SetValue(ref _EmployeeProducters, value);   
            }
        }
        public GetsEmployeeProducterViewModel(IActorViewService<EmployeeProducter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeProducter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeProducters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeProducters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
