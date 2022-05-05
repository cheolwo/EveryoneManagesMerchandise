using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProductLandViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeProductLand? _EmployeeProductLand = new();
        public EmployeeProductLand? EmployeeProductLand
        {
            get => _EmployeeProductLand;
            set
            {
                SetValue(ref _EmployeeProductLand, value);
            }
        }
        public BaseEmployeeProductLandViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeProductLand = await _EmployeeActorContext.GetByIdAsync<EmployeeProductLand>(id);
        }
    }
    public class PostEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
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
        private EmployeeProductLand? _postEmployeeProductLand = new();
        public EmployeeProductLand? PostEmployeeProductLand
        {
            get => _postEmployeeProductLand;
            set
            {
                SetValue(ref _postEmployeeProductLand, value);
            }
        }
        public PostEmployeeProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeProductLand EmployeeProductLand)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeProductLand>(EmployeeProductLand);
            if (PostValue != null)
            {
                PostEmployeeProductLand = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeProductLand = new();
            _postEmployeeProductLand = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
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
        private EmployeeProductLand? _putEmployeeProductLand = new();
        public EmployeeProductLand? PutEmployeeProductLand
        {
            get => _putEmployeeProductLand;
            set
            {
                SetValue(ref _putEmployeeProductLand, value);
            }
        }
        public PutEmployeeProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeProductLand EmployeeProductLand)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeProductLand>(EmployeeProductLand);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeProductLand = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeProductLand = new();
            _putEmployeeProductLand = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
    {
        public DeleteEmployeeProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeProductLand>(id);
        }
        public void Reset()
        {
            EmployeeProductLand = new();
        }
    }
    public class GetsEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
    {
        private List<EmployeeProductLand> _EmployeeProductLands = new();
        public List<EmployeeProductLand> EmployeeProductLands
        {
            get=> _EmployeeProductLands;
            set
            {
                SetValue(ref _EmployeeProductLands, value);   
            }
        }
        public GetsEmployeeProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeProductLand>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeProductLand>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeProductLand>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeProductLand>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeProductLands.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeProductLands.Remove(obj); OnPropertyChanged(); }
        }
    }
}
