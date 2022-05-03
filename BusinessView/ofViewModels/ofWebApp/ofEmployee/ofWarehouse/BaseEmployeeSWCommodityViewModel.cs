using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployeeSWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeSWCommodity? _EmployeeSWCommodity = new();
        public EmployeeSWCommodity? EmployeeSWCommodity
        {
            get => _EmployeeSWCommodity;
            set
            {
                SetValue(ref _EmployeeSWCommodity, value);
            }
        }
        public BaseEmployeeSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeSWCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeSWCommodity>(id);
        }
    }
    public class PostEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
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
        private EmployeeSWCommodity? _postEmployeeSWCommodity = new();
        public EmployeeSWCommodity? PostEmployeeSWCommodity
        {
            get => _postEmployeeSWCommodity;
            set
            {
                SetValue(ref _postEmployeeSWCommodity, value);
            }
        }
        public PostEmployeeSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeSWCommodity EmployeeSWCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeSWCommodity>(EmployeeSWCommodity);
            if (PostValue != null)
            {
                PostEmployeeSWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSWCommodity = new();
            _postEmployeeSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
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
        private EmployeeSWCommodity? _putEmployeeSWCommodity = new();
        public EmployeeSWCommodity? PutEmployeeSWCommodity
        {
            get => _putEmployeeSWCommodity;
            set
            {
                SetValue(ref _putEmployeeSWCommodity, value);
            }
        }
        public PutEmployeeSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeSWCommodity EmployeeSWCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeSWCommodity>(EmployeeSWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSWCommodity = new();
            _putEmployeeSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
    {
        public DeleteEmployeeSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeSWCommodity>(id);
        }
        public void Reset()
        {
            EmployeeSWCommodity = new();
        }
    }
    public class GetsEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
    {
        private List<EmployeeSWCommodity> _EmployeeSWCommoditys = new();
        public List<EmployeeSWCommodity> EmployeeSWCommoditys
        {
            get=> _EmployeeSWCommoditys;
            set
            {
                SetValue(ref _EmployeeSWCommoditys, value);   
            }
        }
        public GetsEmployeeSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSWCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeSWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeSWCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeSWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeSWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
