using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProductCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeProductCenter> _actorViewService;
        protected EmployeeProductCenter? _EmployeeProductCenter = new();
        public EmployeeProductCenter? EmployeeProductCenter
        {
            get => _EmployeeProductCenter;
            set
            {
                SetValue(ref _EmployeeProductCenter, value);
            }
        }
        public BaseEmployeeProductCenterViewModel(IActorViewService<EmployeeProductCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeProductCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeProductCenterViewModel : BaseEmployeeProductCenterViewModel
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
        private EmployeeProductCenter? _postEmployeeProductCenter = new();
        public EmployeeProductCenter? PostEmployeeProductCenter
        {
            get => _postEmployeeProductCenter;
            set
            {
                SetValue(ref _postEmployeeProductCenter, value);
            }
        }
        public PostEmployeeProductCenterViewModel(IActorViewService<EmployeeProductCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeProductCenter EmployeeProductCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeProductCenter);
            if (PostValue != null)
            {
                PostEmployeeProductCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeProductCenter = new();
            _postEmployeeProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeProductCenterViewModel : BaseEmployeeProductCenterViewModel
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
        private EmployeeProductCenter? _putEmployeeProductCenter = new();
        public EmployeeProductCenter? PutEmployeeProductCenter
        {
            get => _putEmployeeProductCenter;
            set
            {
                SetValue(ref _putEmployeeProductCenter, value);
            }
        }
        public PutEmployeeProductCenterViewModel(IActorViewService<EmployeeProductCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeProductCenter EmployeeProductCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeProductCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeProductCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeProductCenter = new();
            _putEmployeeProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeProductCenterViewModel : BaseEmployeeProductCenterViewModel
    {
        public DeleteEmployeeProductCenterViewModel(IActorViewService<EmployeeProductCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeProductCenter = new();
        }
    }
    public class GetsEmployeeProductCenterViewModel : BaseEmployeeProductCenterViewModel
    {
        private List<EmployeeProductCenter> _EmployeeProductCenters = new();
        public List<EmployeeProductCenter> EmployeeProductCenters
        {
            get=> _EmployeeProductCenters;
            set
            {
                SetValue(ref _EmployeeProductCenters, value);   
            }
        }
        public GetsEmployeeProductCenterViewModel(IActorViewService<EmployeeProductCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeProductCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProductCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeProductCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeProductCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
