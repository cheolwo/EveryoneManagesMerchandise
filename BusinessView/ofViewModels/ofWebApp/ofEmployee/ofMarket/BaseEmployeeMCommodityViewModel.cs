using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeMCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMCommodity? _EmployeeMCommodity = new();
        public EmployeeMCommodity? EmployeeMCommodity
        {
            get => _EmployeeMCommodity;
            set
            {
                SetValue(ref _EmployeeMCommodity, value);
            }
        }
        public BaseEmployeeMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeMCommodity>(id);
        }
    }
    public class PostEmployeeMCommodityViewModel : BaseEmployeeMCommodityViewModel
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
        private EmployeeMCommodity? _postEmployeeMCommodity = new();
        public EmployeeMCommodity? PostEmployeeMCommodity
        {
            get => _postEmployeeMCommodity;
            set
            {
                SetValue(ref _postEmployeeMCommodity, value);
            }
        }
        public PostEmployeeMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMCommodity EmployeeMCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeMCommodity>(EmployeeMCommodity);
            if (PostValue != null)
            {
                PostEmployeeMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMCommodity = new();
            _postEmployeeMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMCommodityViewModel : BaseEmployeeMCommodityViewModel
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
        private EmployeeMCommodity? _putEmployeeMCommodity = new();
        public EmployeeMCommodity? PutEmployeeMCommodity
        {
            get => _putEmployeeMCommodity;
            set
            {
                SetValue(ref _putEmployeeMCommodity, value);
            }
        }
        public PutEmployeeMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMCommodity EmployeeMCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeMCommodity>(EmployeeMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMCommodity = new();
            _putEmployeeMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMCommodityViewModel : BaseEmployeeMCommodityViewModel
    {
        public DeleteEmployeeMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMCommodity>(id);
        }
        public void Reset()
        {
            EmployeeMCommodity = new();
        }
    }
    public class GetsEmployeeMCommodityViewModel : BaseEmployeeMCommodityViewModel
    {
        private List<EmployeeMCommodity> _EmployeeMCommoditys = new();
        public List<EmployeeMCommodity> EmployeeMCommoditys
        {
            get=> _EmployeeMCommoditys;
            set
            {
                SetValue(ref _EmployeeMCommoditys, value);   
            }
        }
        public GetsEmployeeMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
