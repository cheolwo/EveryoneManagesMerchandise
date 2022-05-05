using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeePCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeePCommodity? _EmployeePCommodity = new();
        public EmployeePCommodity? EmployeePCommodity
        {
            get => _EmployeePCommodity;
            set
            {
                SetValue(ref _EmployeePCommodity, value);
            }
        }
        public BaseEmployeePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeePCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeePCommodity>(id);
        }
    }
    public class PostEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
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
        private EmployeePCommodity? _postEmployeePCommodity = new();
        public EmployeePCommodity? PostEmployeePCommodity
        {
            get => _postEmployeePCommodity;
            set
            {
                SetValue(ref _postEmployeePCommodity, value);
            }
        }
        public PostEmployeePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeePCommodity EmployeePCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeePCommodity>(EmployeePCommodity);
            if (PostValue != null)
            {
                PostEmployeePCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeePCommodity = new();
            _postEmployeePCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
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
        private EmployeePCommodity? _putEmployeePCommodity = new();
        public EmployeePCommodity? PutEmployeePCommodity
        {
            get => _putEmployeePCommodity;
            set
            {
                SetValue(ref _putEmployeePCommodity, value);
            }
        }
        public PutEmployeePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeePCommodity EmployeePCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeePCommodity>(EmployeePCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeePCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeePCommodity = new();
            _putEmployeePCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
    {
        public DeleteEmployeePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeePCommodity>(id);
        }
        public void Reset()
        {
            EmployeePCommodity = new();
        }
    }
    public class GetsEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
    {
        private List<EmployeePCommodity> _EmployeePCommoditys = new();
        public List<EmployeePCommodity> EmployeePCommoditys
        {
            get=> _EmployeePCommoditys;
            set
            {
                SetValue(ref _EmployeePCommoditys, value);   
            }
        }
        public GetsEmployeePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeePCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeePCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeePCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeePCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeePCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeePCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeePCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeePCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
