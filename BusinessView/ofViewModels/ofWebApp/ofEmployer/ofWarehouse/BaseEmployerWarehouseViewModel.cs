using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWarehouseViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerWarehouse> _actorViewService;
        protected EmployerWarehouse? _EmployerWarehouse = new();
        public EmployerWarehouse? EmployerWarehouse
        {
            get => _EmployerWarehouse;
            set
            {
                SetValue(ref _EmployerWarehouse, value);
            }
        }
        public BaseEmployerWarehouseViewModel(IActorViewService<EmployerWarehouse> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerWarehouse = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerWarehouseViewModel : BaseEmployerWarehouseViewModel
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
        private EmployerWarehouse? _postEmployerWarehouse = new();
        public EmployerWarehouse? PostEmployerWarehouse
        {
            get => _postEmployerWarehouse;
            set
            {
                SetValue(ref _postEmployerWarehouse, value);
            }
        }
        public PostEmployerWarehouseViewModel(IActorViewService<EmployerWarehouse> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerWarehouse EmployerWarehouse)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerWarehouse);
            if (PostValue != null)
            {
                PostEmployerWarehouse = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerWarehouse = new();
            _postEmployerWarehouse = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerWarehouseViewModel : BaseEmployerWarehouseViewModel
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
        private EmployerWarehouse? _putEmployerWarehouse = new();
        public EmployerWarehouse? PutEmployerWarehouse
        {
            get => _putEmployerWarehouse;
            set
            {
                SetValue(ref _putEmployerWarehouse, value);
            }
        }
        public PutEmployerWarehouseViewModel(IActorViewService<EmployerWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerWarehouse EmployerWarehouse)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerWarehouse);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerWarehouse = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerWarehouse = new();
            _putEmployerWarehouse = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerWarehouseViewModel : BaseEmployerWarehouseViewModel
    {
        public DeleteEmployerWarehouseViewModel(IActorViewService<EmployerWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerWarehouse = new();
        }
    }
    public class GetsEmployerWarehouseViewModel : BaseEmployerWarehouseViewModel
    {
        private List<EmployerWarehouse> _EmployerWarehouses = new();
        public List<EmployerWarehouse> EmployerWarehouses
        {
            get=> _EmployerWarehouses;
            set
            {
                SetValue(ref _EmployerWarehouses, value);   
            }
        }
        public GetsEmployerWarehouseViewModel(IActorViewService<EmployerWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerWarehouse>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerWarehouses.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerWarehouses.Remove(obj); OnPropertyChanged(); }
        }
    }
}
