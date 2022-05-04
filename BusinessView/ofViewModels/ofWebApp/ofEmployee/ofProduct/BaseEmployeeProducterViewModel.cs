using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProducterViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeProducter? _EmployeeProducter = new();
        public EmployeeProducter? EmployeeProducter
        {
            get => _EmployeeProducter;
            set
            {
                SetValue(ref _EmployeeProducter, value);
            }
        }
        public BaseEmployeeProducterViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeProducter = await _EmployeeActorContext.GetByIdAsync<EmployeeProducter>(id);
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
        public PostEmployeeProducterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeProducter EmployeeProducter)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeProducter>(EmployeeProducter);
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
        public PutEmployeeProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeProducter EmployeeProducter)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeProducter>(EmployeeProducter);
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
        public DeleteEmployeeProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeProducter>(id);
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
        public GetsEmployeeProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeProducter>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeProducter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeProducter>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeProducter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeProducters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeProducters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
