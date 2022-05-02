using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformDotBarcodeViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformDotBarcode> _actorViewService;
        protected PlatformDotBarcode? _PlatformDotBarcode = new();
        public PlatformDotBarcode? PlatformDotBarcode
        {
            get => _PlatformDotBarcode;
            set
            {
                SetValue(ref _PlatformDotBarcode, value);
            }
        }
        public BasePlatformDotBarcodeViewModel(IActorViewService<PlatformDotBarcode> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformDotBarcode = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformDotBarcodeViewModel : BasePlatformDotBarcodeViewModel
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
        private PlatformDotBarcode? _postPlatformDotBarcode = new();
        public PlatformDotBarcode? PostPlatformDotBarcode
        {
            get => _postPlatformDotBarcode;
            set
            {
                SetValue(ref _postPlatformDotBarcode, value);
            }
        }
        public PostPlatformDotBarcodeViewModel(IActorViewService<PlatformDotBarcode> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformDotBarcode PlatformDotBarcode)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformDotBarcode);
            if (PostValue != null)
            {
                PostPlatformDotBarcode = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformDotBarcode = new();
            _postPlatformDotBarcode = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformDotBarcodeViewModel : BasePlatformDotBarcodeViewModel
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
        private PlatformDotBarcode? _putPlatformDotBarcode = new();
        public PlatformDotBarcode? PutPlatformDotBarcode
        {
            get => _putPlatformDotBarcode;
            set
            {
                SetValue(ref _putPlatformDotBarcode, value);
            }
        }
        public PutPlatformDotBarcodeViewModel(IActorViewService<PlatformDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformDotBarcode PlatformDotBarcode)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformDotBarcode);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformDotBarcode = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformDotBarcode = new();
            _putPlatformDotBarcode = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformDotBarcodeViewModel : BasePlatformDotBarcodeViewModel
    {
        public DeletePlatformDotBarcodeViewModel(IActorViewService<PlatformDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformDotBarcode = new();
        }
    }
    public class GetsPlatformDotBarcodeViewModel : BasePlatformDotBarcodeViewModel
    {
        private List<PlatformDotBarcode> _PlatformDotBarcodes = new();
        public List<PlatformDotBarcode> PlatformDotBarcodes
        {
            get=> _PlatformDotBarcodes;
            set
            {
                SetValue(ref _PlatformDotBarcodes, value);   
            }
        }
        public GetsPlatformDotBarcodeViewModel(IActorViewService<PlatformDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformDotBarcode>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformDotBarcodes.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformDotBarcodes.Remove(obj); OnPropertyChanged(); }
        }
    }
}
