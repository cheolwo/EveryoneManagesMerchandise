using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWarehouseViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerWarehouse? _EmployerWarehouse = new();
        public EmployerWarehouse? EmployerWarehouse
        {
            get => _EmployerWarehouse;
            set
            {
                SetValue(ref _EmployerWarehouse, value);
            }
        }
        public BaseEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerWarehouse = await _EmployerActorContext.GetByIdAsync<EmployerWarehouse>(id);
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
        public PostEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerWarehouse EmployerWarehouse)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerWarehouse>(EmployerWarehouse);
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
        public PutEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerWarehouse EmployerWarehouse)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerWarehouse>(EmployerWarehouse);
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
        public DeleteEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerWarehouse>(id);
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
        public GetsEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerWarehouse>? dtos = await _EmployerActorContext.GetsAsync<EmployerWarehouse>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerWarehouse>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerWarehouse>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerWarehouses.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerWarehouses.Remove(obj); OnPropertyChanged(); }
        }
    }
}
