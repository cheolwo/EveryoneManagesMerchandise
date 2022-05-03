using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployeeMPCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMPCommodity? _EmployeeMPCommodity = new();
        public EmployeeMPCommodity? EmployeeMPCommodity
        {
            get => _EmployeeMPCommodity;
            set
            {
                SetValue(ref _EmployeeMPCommodity, value);
            }
        }
        public BaseEmployeeMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeMPCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeMPCommodity>(id);
        }
    }
    public class PostEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
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
        private EmployeeMPCommodity? _postEmployeeMPCommodity = new();
        public EmployeeMPCommodity? PostEmployeeMPCommodity
        {
            get => _postEmployeeMPCommodity;
            set
            {
                SetValue(ref _postEmployeeMPCommodity, value);
            }
        }
        public PostEmployeeMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMPCommodity EmployeeMPCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeMPCommodity>(EmployeeMPCommodity);
            if (PostValue != null)
            {
                PostEmployeeMPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMPCommodity = new();
            _postEmployeeMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
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
        private EmployeeMPCommodity? _putEmployeeMPCommodity = new();
        public EmployeeMPCommodity? PutEmployeeMPCommodity
        {
            get => _putEmployeeMPCommodity;
            set
            {
                SetValue(ref _putEmployeeMPCommodity, value);
            }
        }
        public PutEmployeeMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMPCommodity EmployeeMPCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeMPCommodity>(EmployeeMPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMPCommodity = new();
            _putEmployeeMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
    {
        public DeleteEmployeeMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMPCommodity>(id);
        }
        public void Reset()
        {
            EmployeeMPCommodity = new();
        }
    }
    public class GetsEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
    {
        private List<EmployeeMPCommodity> _EmployeeMPCommoditys = new();
        public List<EmployeeMPCommodity> EmployeeMPCommoditys
        {
            get=> _EmployeeMPCommoditys;
            set
            {
                SetValue(ref _EmployeeMPCommoditys, value);   
            }
        }
        public GetsEmployeeMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMPCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMPCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeMPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
