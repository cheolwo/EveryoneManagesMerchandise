using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeMWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMWCommodity? _EmployeeMWCommodity = new();
        public EmployeeMWCommodity? EmployeeMWCommodity
        {
            get => _EmployeeMWCommodity;
            set
            {
                SetValue(ref _EmployeeMWCommodity, value);
            }
        }
        public BaseEmployeeMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMWCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeMWCommodity>(id);
        }
    }
    public class PostEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
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
        private EmployeeMWCommodity? _postEmployeeMWCommodity = new();
        public EmployeeMWCommodity? PostEmployeeMWCommodity
        {
            get => _postEmployeeMWCommodity;
            set
            {
                SetValue(ref _postEmployeeMWCommodity, value);
            }
        }
        public PostEmployeeMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMWCommodity EmployeeMWCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeMWCommodity>(EmployeeMWCommodity);
            if (PostValue != null)
            {
                PostEmployeeMWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMWCommodity = new();
            _postEmployeeMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
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
        private EmployeeMWCommodity? _putEmployeeMWCommodity = new();
        public EmployeeMWCommodity? PutEmployeeMWCommodity
        {
            get => _putEmployeeMWCommodity;
            set
            {
                SetValue(ref _putEmployeeMWCommodity, value);
            }
        }
        public PutEmployeeMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMWCommodity EmployeeMWCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeMWCommodity>(EmployeeMWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMWCommodity = new();
            _putEmployeeMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
    {
        public DeleteEmployeeMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMWCommodity>(id);
        }
        public void Reset()
        {
            EmployeeMWCommodity = new();
        }
    }
    public class GetsEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
    {
        private List<EmployeeMWCommodity> _EmployeeMWCommoditys = new();
        public List<EmployeeMWCommodity> EmployeeMWCommoditys
        {
            get=> _EmployeeMWCommoditys;
            set
            {
                SetValue(ref _EmployeeMWCommoditys, value);   
            }
        }
        public GetsEmployeeMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMWCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMWCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeMWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
