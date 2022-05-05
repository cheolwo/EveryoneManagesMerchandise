using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformDotBarcodeViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformDotBarcode? _PlatformDotBarcode = new();
        public PlatformDotBarcode? PlatformDotBarcode
        {
            get => _PlatformDotBarcode;
            set
            {
                SetValue(ref _PlatformDotBarcode, value);
            }
        }
        public BasePlatformDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformDotBarcode = await _PlatformActorContext.GetByIdAsync<PlatformDotBarcode>(id);
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
        public PostPlatformDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformDotBarcode PlatformDotBarcode)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformDotBarcode>(PlatformDotBarcode);
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
        public PutPlatformDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformDotBarcode PlatformDotBarcode)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformDotBarcode>(PlatformDotBarcode);
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
        public DeletePlatformDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformDotBarcode>(id);
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
        public GetsPlatformDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformDotBarcode>? dtos = await _PlatformActorContext.GetsAsync<PlatformDotBarcode>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformDotBarcode>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformDotBarcode>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformDotBarcodes.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformDotBarcodes.Remove(obj); OnPropertyChanged(); }
        }
    }
}
