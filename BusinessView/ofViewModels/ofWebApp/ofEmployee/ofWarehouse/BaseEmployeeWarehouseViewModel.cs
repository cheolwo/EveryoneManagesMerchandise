using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeWarehouseViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeWarehouse? _EmployeeWarehouse = new();
        public EmployeeWarehouse? EmployeeWarehouse
        {
            get => _EmployeeWarehouse;
            set
            {
                SetValue(ref _EmployeeWarehouse, value);
            }
        }
        public BaseEmployeeWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeWarehouse = await _EmployeeActorContext.GetByIdAsync<EmployeeWarehouse>(id);
        }
    }
    public class PostEmployeeWarehouseViewModel : BaseEmployeeWarehouseViewModel
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
        private EmployeeWarehouse? _postEmployeeWarehouse = new();
        public EmployeeWarehouse? PostEmployeeWarehouse
        {
            get => _postEmployeeWarehouse;
            set
            {
                SetValue(ref _postEmployeeWarehouse, value);
            }
        }
        public PostEmployeeWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeWarehouse EmployeeWarehouse)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeWarehouse>(EmployeeWarehouse);
            if (PostValue != null)
            {
                PostEmployeeWarehouse = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeWarehouse = new();
            _postEmployeeWarehouse = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeWarehouseViewModel : BaseEmployeeWarehouseViewModel
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
        private EmployeeWarehouse? _putEmployeeWarehouse = new();
        public EmployeeWarehouse? PutEmployeeWarehouse
        {
            get => _putEmployeeWarehouse;
            set
            {
                SetValue(ref _putEmployeeWarehouse, value);
            }
        }
        public PutEmployeeWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeWarehouse EmployeeWarehouse)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeWarehouse>(EmployeeWarehouse);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeWarehouse = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeWarehouse = new();
            _putEmployeeWarehouse = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeWarehouseViewModel : BaseEmployeeWarehouseViewModel
    {
        public DeleteEmployeeWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeWarehouse>(id);
        }
        public void Reset()
        {
            EmployeeWarehouse = new();
        }
    }
    public class GetsEmployeeWarehouseViewModel : BaseEmployeeWarehouseViewModel
    {
        private List<EmployeeWarehouse> _EmployeeWarehouses = new();
        public List<EmployeeWarehouse> EmployeeWarehouses
        {
            get=> _EmployeeWarehouses;
            set
            {
                SetValue(ref _EmployeeWarehouses, value);   
            }
        }
        public GetsEmployeeWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeWarehouse>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeWarehouse>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeWarehouse>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeWarehouse>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeWarehouses.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeWarehouses.Remove(obj); OnPropertyChanged(); }
        }
    }
}
