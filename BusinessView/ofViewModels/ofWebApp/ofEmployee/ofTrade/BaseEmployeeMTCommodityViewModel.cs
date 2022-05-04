using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeMTCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMTCommodity? _EmployeeMTCommodity = new();
        public EmployeeMTCommodity? EmployeeMTCommodity
        {
            get => _EmployeeMTCommodity;
            set
            {
                SetValue(ref _EmployeeMTCommodity, value);
            }
        }
        public BaseEmployeeMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMTCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeMTCommodity>(id);
        }
    }
    public class PostEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
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
        private EmployeeMTCommodity? _postEmployeeMTCommodity = new();
        public EmployeeMTCommodity? PostEmployeeMTCommodity
        {
            get => _postEmployeeMTCommodity;
            set
            {
                SetValue(ref _postEmployeeMTCommodity, value);
            }
        }
        public PostEmployeeMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMTCommodity EmployeeMTCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeMTCommodity>(EmployeeMTCommodity);
            if (PostValue != null)
            {
                PostEmployeeMTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMTCommodity = new();
            _postEmployeeMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
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
        private EmployeeMTCommodity? _putEmployeeMTCommodity = new();
        public EmployeeMTCommodity? PutEmployeeMTCommodity
        {
            get => _putEmployeeMTCommodity;
            set
            {
                SetValue(ref _putEmployeeMTCommodity, value);
            }
        }
        public PutEmployeeMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMTCommodity EmployeeMTCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeMTCommodity>(EmployeeMTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMTCommodity = new();
            _putEmployeeMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
    {
        public DeleteEmployeeMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMTCommodity>(id);
        }
        public void Reset()
        {
            EmployeeMTCommodity = new();
        }
    }
    public class GetsEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
    {
        private List<EmployeeMTCommodity> _EmployeeMTCommoditys = new();
        public List<EmployeeMTCommodity> EmployeeMTCommoditys
        {
            get=> _EmployeeMTCommoditys;
            set
            {
                SetValue(ref _EmployeeMTCommoditys, value);   
            }
        }
        public GetsEmployeeMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMTCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMTCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeMTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
