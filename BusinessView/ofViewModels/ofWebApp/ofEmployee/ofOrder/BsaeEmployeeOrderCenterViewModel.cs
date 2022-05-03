using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeOrderCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeOrderCenter> _actorViewService;
        protected EmployeeOrderCenter? _EmployeeOrderCenter = new();
        public EmployeeOrderCenter? EmployeeOrderCenter
        {
            get => _EmployeeOrderCenter;
            set
            {
                SetValue(ref _EmployeeOrderCenter, value);
            }
        }
        public BaseEmployeeOrderCenterViewModel(IActorViewService<EmployeeOrderCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeOrderCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeOrderCenterViewModel : BaseEmployeeOrderCenterViewModel
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
        private EmployeeOrderCenter? _postEmployeeOrderCenter = new();
        public EmployeeOrderCenter? PostEmployeeOrderCenter
        {
            get => _postEmployeeOrderCenter;
            set
            {
                SetValue(ref _postEmployeeOrderCenter, value);
            }
        }
        public PostEmployeeOrderCenterViewModel(IActorViewService<EmployeeOrderCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeOrderCenter EmployeeOrderCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeOrderCenter);
            if (PostValue != null)
            {
                PostEmployeeOrderCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeOrderCenter = new();
            _postEmployeeOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeOrderCenterViewModel : BaseEmployeeOrderCenterViewModel
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
        private EmployeeOrderCenter? _putEmployeeOrderCenter = new();
        public EmployeeOrderCenter? PutEmployeeOrderCenter
        {
            get => _putEmployeeOrderCenter;
            set
            {
                SetValue(ref _putEmployeeOrderCenter, value);
            }
        }
        public PutEmployeeOrderCenterViewModel(IActorViewService<EmployeeOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeOrderCenter EmployeeOrderCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeOrderCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeOrderCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeOrderCenter = new();
            _putEmployeeOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeOrderCenterViewModel : BaseEmployeeOrderCenterViewModel
    {
        public DeleteEmployeeOrderCenterViewModel(IActorViewService<EmployeeOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeOrderCenter = new();
        }
    }
    public class GetsEmployeeOrderCenterViewModel : BaseEmployeeOrderCenterViewModel
    {
        private List<EmployeeOrderCenter> _EmployeeOrderCenters = new();
        public List<EmployeeOrderCenter> EmployeeOrderCenters
        {
            get=> _EmployeeOrderCenters;
            set
            {
                SetValue(ref _EmployeeOrderCenters, value);   
            }
        }
        public GetsEmployeeOrderCenterViewModel(IActorViewService<EmployeeOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeOrderCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeOrderCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeOrderCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
