using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProducterViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerProducter? _EmployerProducter = new();
        public EmployerProducter? EmployerProducter
        {
            get => _EmployerProducter;
            set
            {
                SetValue(ref _EmployerProducter, value);
            }
        }
        public BaseEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerProducter = await _EmployerActorContext.GetByIdAsync<EmployerProducter>(id);
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
        public PostEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerProducter EmployerProducter)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerProducter>(EmployerProducter);
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
        public PutEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerProducter EmployerProducter)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerProducter>(EmployerProducter);
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
        public DeleteEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerProducter>(id);
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
        public GetsEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerProducter>? dtos = await _EmployerActorContext.GetsAsync<EmployerProducter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerProducter>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerProducter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProducters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerProducters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerProducters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
