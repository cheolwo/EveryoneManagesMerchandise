using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeWarehouseViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeWarehouse> _actorViewService;
        protected EmployeeWarehouse? _EmployeeWarehouse = new();
        public EmployeeWarehouse? EmployeeWarehouse
        {
            get => _EmployeeWarehouse;
            set
            {
                SetValue(ref _EmployeeWarehouse, value);
            }
        }
        public BaseEmployeeWarehouseViewModel(IActorViewService<EmployeeWarehouse> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeWarehouse = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployeeWarehouseViewModel(IActorViewService<EmployeeWarehouse> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeWarehouse EmployeeWarehouse)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeWarehouse);
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
        public PutEmployeeWarehouseViewModel(IActorViewService<EmployeeWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeWarehouse EmployeeWarehouse)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeWarehouse);
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
        public DeleteEmployeeWarehouseViewModel(IActorViewService<EmployeeWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployeeWarehouseViewModel(IActorViewService<EmployeeWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeWarehouse>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeWarehouses.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeWarehouses.Remove(obj); OnPropertyChanged(); }
        }
    }
}
