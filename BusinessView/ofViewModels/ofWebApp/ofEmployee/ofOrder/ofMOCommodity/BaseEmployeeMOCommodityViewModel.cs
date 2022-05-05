using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeMOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMOCommodity? _EmployeeMOCommodity = new();
        public EmployeeMOCommodity? EmployeeMOCommodity
        {
            get => _EmployeeMOCommodity;
            set
            {
                SetValue(ref _EmployeeMOCommodity, value);
            }
        }
        public BaseEmployeeMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMOCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeMOCommodity>(id);
        }
    }
    public class PostEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
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
        private EmployeeMOCommodity? _postEmployeeMOCommodity = new();
        public EmployeeMOCommodity? PostEmployeeMOCommodity
        {
            get => _postEmployeeMOCommodity;
            set
            {
                SetValue(ref _postEmployeeMOCommodity, value);
            }
        }
        public PostEmployeeMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMOCommodity EmployeeMOCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeMOCommodity>(EmployeeMOCommodity);
            if (PostValue != null)
            {
                PostEmployeeMOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMOCommodity = new();
            _postEmployeeMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
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
        private EmployeeMOCommodity? _putEmployeeMOCommodity = new();
        public EmployeeMOCommodity? PutEmployeeMOCommodity
        {
            get => _putEmployeeMOCommodity;
            set
            {
                SetValue(ref _putEmployeeMOCommodity, value);
            }
        }
        public PutEmployeeMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMOCommodity EmployeeMOCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeMOCommodity>(EmployeeMOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMOCommodity = new();
            _putEmployeeMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
    {
        public DeleteEmployeeMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMOCommodity>(id);
        }
        public void Reset()
        {
            EmployeeMOCommodity = new();
        }
    }
    public class GetsEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
    {
        private List<EmployeeMOCommodity> _EmployeeMOCommoditys = new();
        public List<EmployeeMOCommodity> EmployeeMOCommoditys
        {
            get=> _EmployeeMOCommoditys;
            set
            {
                SetValue(ref _EmployeeMOCommoditys, value);   
            }
        }
        public GetsEmployeeMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMOCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMOCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeMOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
