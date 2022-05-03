using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWarehouseViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformWarehouse? _PlatformWarehouse = new();
        public PlatformWarehouse? PlatformWarehouse
        {
            get => _PlatformWarehouse;
            set
            {
                SetValue(ref _PlatformWarehouse, value);
            }
        }
        public BasePlatformWarehouseViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformWarehouse = await _PlatformActorContext.GetByIdAsync<PlatformWarehouse>(id);
        }
    }
    public class PostPlatformWarehouseViewModel : BasePlatformWarehouseViewModel
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
        private PlatformWarehouse? _postPlatformWarehouse = new();
        public PlatformWarehouse? PostPlatformWarehouse
        {
            get => _postPlatformWarehouse;
            set
            {
                SetValue(ref _postPlatformWarehouse, value);
            }
        }
        public PostPlatformWarehouseViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformWarehouse PlatformWarehouse)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformWarehouse>(PlatformWarehouse);
            if (PostValue != null)
            {
                PostPlatformWarehouse = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformWarehouse = new();
            _postPlatformWarehouse = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformWarehouseViewModel : BasePlatformWarehouseViewModel
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
        private PlatformWarehouse? _putPlatformWarehouse = new();
        public PlatformWarehouse? PutPlatformWarehouse
        {
            get => _putPlatformWarehouse;
            set
            {
                SetValue(ref _putPlatformWarehouse, value);
            }
        }
        public PutPlatformWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformWarehouse PlatformWarehouse)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformWarehouse>(PlatformWarehouse);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformWarehouse = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformWarehouse = new();
            _putPlatformWarehouse = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformWarehouseViewModel : BasePlatformWarehouseViewModel
    {
        public DeletePlatformWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformWarehouse>(id);
        }
        public void Reset()
        {
            PlatformWarehouse = new();
        }
    }
    public class GetsPlatformWarehouseViewModel : BasePlatformWarehouseViewModel
    {
        private List<PlatformWarehouse> _PlatformWarehouses = new();
        public List<PlatformWarehouse> PlatformWarehouses
        {
            get=> _PlatformWarehouses;
            set
            {
                SetValue(ref _PlatformWarehouses, value);   
            }
        }
        public GetsPlatformWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformWarehouse>? dtos = await _PlatformActorContext.GetsAsync<PlatformWarehouse>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformWarehouse>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformWarehouse>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformWarehouses.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformWarehouses.Remove(obj); OnPropertyChanged(); }
        }
    }
}
