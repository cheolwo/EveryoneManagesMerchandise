using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeSPCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeSPCommodity? _EmployeeSPCommodity = new();
        public EmployeeSPCommodity? EmployeeSPCommodity
        {
            get => _EmployeeSPCommodity;
            set
            {
                SetValue(ref _EmployeeSPCommodity, value);
            }
        }
        public BaseEmployeeSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeSPCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeSPCommodity>(id);
        }
    }
    public class PostEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
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
        private EmployeeSPCommodity? _postEmployeeSPCommodity = new();
        public EmployeeSPCommodity? PostEmployeeSPCommodity
        {
            get => _postEmployeeSPCommodity;
            set
            {
                SetValue(ref _postEmployeeSPCommodity, value);
            }
        }
        public PostEmployeeSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeSPCommodity EmployeeSPCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeSPCommodity>(EmployeeSPCommodity);
            if (PostValue != null)
            {
                PostEmployeeSPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSPCommodity = new();
            _postEmployeeSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
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
        private EmployeeSPCommodity? _putEmployeeSPCommodity = new();
        public EmployeeSPCommodity? PutEmployeeSPCommodity
        {
            get => _putEmployeeSPCommodity;
            set
            {
                SetValue(ref _putEmployeeSPCommodity, value);
            }
        }
        public PutEmployeeSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeSPCommodity EmployeeSPCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeSPCommodity>(EmployeeSPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSPCommodity = new();
            _putEmployeeSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
    {
        public DeleteEmployeeSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeSPCommodity>(id);
        }
        public void Reset()
        {
            EmployeeSPCommodity = new();
        }
    }
    public class GetsEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
    {
        private List<EmployeeSPCommodity> _EmployeeSPCommoditys = new();
        public List<EmployeeSPCommodity> EmployeeSPCommoditys
        {
            get=> _EmployeeSPCommoditys;
            set
            {
                SetValue(ref _EmployeeSPCommoditys, value);   
            }
        }
        public GetsEmployeeSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSPCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeSPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeSPCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeSPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeSPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
