using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProductCenterViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerProductCenter? _EmployerProductCenter = new();
        public EmployerProductCenter? EmployerProductCenter
        {
            get => _EmployerProductCenter;
            set
            {
                SetValue(ref _EmployerProductCenter, value);
            }
        }
        public BaseEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerProductCenter = await _EmployerActorContext.GetByIdAsync<EmployerProductCenter>(id);
        }
    }
    public class PostEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
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
        private EmployerProductCenter? _postEmployerProductCenter = new();
        public EmployerProductCenter? PostEmployerProductCenter
        {
            get => _postEmployerProductCenter;
            set
            {
                SetValue(ref _postEmployerProductCenter, value);
            }
        }
        public PostEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerProductCenter EmployerProductCenter)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerProductCenter>(EmployerProductCenter);
            if (PostValue != null)
            {
                PostEmployerProductCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerProductCenter = new();
            _postEmployerProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
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
        private EmployerProductCenter? _putEmployerProductCenter = new();
        public EmployerProductCenter? PutEmployerProductCenter
        {
            get => _putEmployerProductCenter;
            set
            {
                SetValue(ref _putEmployerProductCenter, value);
            }
        }
        public PutEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerProductCenter EmployerProductCenter)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerProductCenter>(EmployerProductCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerProductCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerProductCenter = new();
            _putEmployerProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
    {
        public DeleteEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerProductCenter>(id);
        }
        public void Reset()
        {
            EmployerProductCenter = new();
        }
    }
    public class GetsEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
    {
        private List<EmployerProductCenter> _EmployerProductCenters = new();
        public List<EmployerProductCenter> EmployerProductCenters
        {
            get=> _EmployerProductCenters;
            set
            {
                SetValue(ref _EmployerProductCenters, value);   
            }
        }
        public GetsEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerProductCenter>? dtos = await _EmployerActorContext.GetsAsync<EmployerProductCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProductCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerProductCenter>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerProductCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProductCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerProductCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerProductCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
