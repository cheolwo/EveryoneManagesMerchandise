using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeTradeCenterViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeTradeCenter? _EmployeeTradeCenter = new();
        public EmployeeTradeCenter? EmployeeTradeCenter
        {
            get => _EmployeeTradeCenter;
            set
            {
                SetValue(ref _EmployeeTradeCenter, value);
            }
        }
        public BaseEmployeeTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeTradeCenter = await _EmployeeActorContext.GetByIdAsync<EmployeeTradeCenter>(id);
        }
    }
    public class PostEmployeeTradeCenterViewModel : BaseEmployeeTradeCenterViewModel
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
        private EmployeeTradeCenter? _postEmployeeTradeCenter = new();
        public EmployeeTradeCenter? PostEmployeeTradeCenter
        {
            get => _postEmployeeTradeCenter;
            set
            {
                SetValue(ref _postEmployeeTradeCenter, value);
            }
        }
        public PostEmployeeTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeTradeCenter EmployeeTradeCenter)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeTradeCenter>(EmployeeTradeCenter);
            if (PostValue != null)
            {
                PostEmployeeTradeCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeTradeCenter = new();
            _postEmployeeTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeTradeCenterViewModel : BaseEmployeeTradeCenterViewModel
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
        private EmployeeTradeCenter? _putEmployeeTradeCenter = new();
        public EmployeeTradeCenter? PutEmployeeTradeCenter
        {
            get => _putEmployeeTradeCenter;
            set
            {
                SetValue(ref _putEmployeeTradeCenter, value);
            }
        }
        public PutEmployeeTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeTradeCenter EmployeeTradeCenter)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeTradeCenter>(EmployeeTradeCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeTradeCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeTradeCenter = new();
            _putEmployeeTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeTradeCenterViewModel : BaseEmployeeTradeCenterViewModel
    {
        public DeleteEmployeeTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeTradeCenter>(id);
        }
        public void Reset()
        {
            EmployeeTradeCenter = new();
        }
    }
    public class GetsEmployeeTradeCenterViewModel : BaseEmployeeTradeCenterViewModel
    {
        private List<EmployeeTradeCenter> _EmployeeTradeCenters = new();
        public List<EmployeeTradeCenter> EmployeeTradeCenters
        {
            get=> _EmployeeTradeCenters;
            set
            {
                SetValue(ref _EmployeeTradeCenters, value);   
            }
        }
        public GetsEmployeeTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeTradeCenter>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeTradeCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeTradeCenter>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeTradeCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeTradeCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeTradeCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
