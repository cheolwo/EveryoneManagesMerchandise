using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeTCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeTCommodity? _EmployeeTCommodity = new();
        public EmployeeTCommodity? EmployeeTCommodity
        {
            get => _EmployeeTCommodity;
            set
            {
                SetValue(ref _EmployeeTCommodity, value);
            }
        }
        public BaseEmployeeTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeTCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeTCommodity>(id);
        }
    }
    public class PostEmployeeTCommodityViewModel : BaseEmployeeTCommodityViewModel
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
        private EmployeeTCommodity? _postEmployeeTCommodity = new();
        public EmployeeTCommodity? PostEmployeeTCommodity
        {
            get => _postEmployeeTCommodity;
            set
            {
                SetValue(ref _postEmployeeTCommodity, value);
            }
        }
        public PostEmployeeTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeTCommodity EmployeeTCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeTCommodity>(EmployeeTCommodity);
            if (PostValue != null)
            {
                PostEmployeeTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeTCommodity = new();
            _postEmployeeTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeTCommodityViewModel : BaseEmployeeTCommodityViewModel
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
        private EmployeeTCommodity? _putEmployeeTCommodity = new();
        public EmployeeTCommodity? PutEmployeeTCommodity
        {
            get => _putEmployeeTCommodity;
            set
            {
                SetValue(ref _putEmployeeTCommodity, value);
            }
        }
        public PutEmployeeTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeTCommodity EmployeeTCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeTCommodity>(EmployeeTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeTCommodity = new();
            _putEmployeeTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeTCommodityViewModel : BaseEmployeeTCommodityViewModel
    {
        public DeleteEmployeeTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeTCommodity>(id);
        }
        public void Reset()
        {
            EmployeeTCommodity = new();
        }
    }
    public class GetsEmployeeTCommodityViewModel : BaseEmployeeTCommodityViewModel
    {
        private List<EmployeeTCommodity> _EmployeeTCommoditys = new();
        public List<EmployeeTCommodity> EmployeeTCommoditys
        {
            get=> _EmployeeTCommoditys;
            set
            {
                SetValue(ref _EmployeeTCommoditys, value);   
            }
        }
        public GetsEmployeeTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeTCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeTCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
