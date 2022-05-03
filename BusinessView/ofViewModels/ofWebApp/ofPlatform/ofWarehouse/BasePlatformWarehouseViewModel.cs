using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWarehouseViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformWarehouse> _actorViewService;
        protected PlatformWarehouse? _PlatformWarehouse = new();
        public PlatformWarehouse? PlatformWarehouse
        {
            get => _PlatformWarehouse;
            set
            {
                SetValue(ref _PlatformWarehouse, value);
            }
        }
        public BasePlatformWarehouseViewModel(IActorViewService<PlatformWarehouse> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformWarehouse = await _actorViewService.GetByIdAsync(id);
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
        public PostPlatformWarehouseViewModel(IActorViewService<PlatformWarehouse> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformWarehouse PlatformWarehouse)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformWarehouse);
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
        public PutPlatformWarehouseViewModel(IActorViewService<PlatformWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformWarehouse PlatformWarehouse)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformWarehouse);
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
        public DeletePlatformWarehouseViewModel(IActorViewService<PlatformWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsPlatformWarehouseViewModel(IActorViewService<PlatformWarehouse> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformWarehouse>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformWarehouses.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformWarehouses.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformWarehouses.Remove(obj); OnPropertyChanged(); }
        }
    }
}
