using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeOrderCenterViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeOrderCenter? _EmployeeOrderCenter = new();
        public EmployeeOrderCenter? EmployeeOrderCenter
        {
            get => _EmployeeOrderCenter;
            set
            {
                SetValue(ref _EmployeeOrderCenter, value);
            }
        }
        public BaseEmployeeOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeOrderCenter = await _EmployeeActorContext.GetByIdAsync<EmployeeOrderCenter>(id);
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
        public PostEmployeeOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeOrderCenter EmployeeOrderCenter)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeOrderCenter>(EmployeeOrderCenter);
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
        public PutEmployeeOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeOrderCenter EmployeeOrderCenter)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeOrderCenter>(EmployeeOrderCenter);
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
        public DeleteEmployeeOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeOrderCenter>(id);
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
        public GetsEmployeeOrderCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeOrderCenter>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeOrderCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeOrderCenter>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeOrderCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeOrderCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeOrderCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
