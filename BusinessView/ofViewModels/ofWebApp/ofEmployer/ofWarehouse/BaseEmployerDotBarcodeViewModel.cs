using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerDotBarcodeViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerDotBarcode> _actorViewService;
        protected EmployerDotBarcode? _EmployerDotBarcode = new();
        public EmployerDotBarcode? EmployerDotBarcode
        {
            get => _EmployerDotBarcode;
            set
            {
                SetValue(ref _EmployerDotBarcode, value);
            }
        }
        public BaseEmployerDotBarcodeViewModel(IActorViewService<EmployerDotBarcode> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerDotBarcode = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerDotBarcodeViewModel : BaseEmployerDotBarcodeViewModel
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
        private EmployerDotBarcode? _postEmployerDotBarcode = new();
        public EmployerDotBarcode? PostEmployerDotBarcode
        {
            get => _postEmployerDotBarcode;
            set
            {
                SetValue(ref _postEmployerDotBarcode, value);
            }
        }
        public PostEmployerDotBarcodeViewModel(IActorViewService<EmployerDotBarcode> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerDotBarcode EmployerDotBarcode)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerDotBarcode);
            if (PostValue != null)
            {
                PostEmployerDotBarcode = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerDotBarcode = new();
            _postEmployerDotBarcode = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerDotBarcodeViewModel : BaseEmployerDotBarcodeViewModel
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
        private EmployerDotBarcode? _putEmployerDotBarcode = new();
        public EmployerDotBarcode? PutEmployerDotBarcode
        {
            get => _putEmployerDotBarcode;
            set
            {
                SetValue(ref _putEmployerDotBarcode, value);
            }
        }
        public PutEmployerDotBarcodeViewModel(IActorViewService<EmployerDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerDotBarcode EmployerDotBarcode)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerDotBarcode);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerDotBarcode = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerDotBarcode = new();
            _putEmployerDotBarcode = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerDotBarcodeViewModel : BaseEmployerDotBarcodeViewModel
    {
        public DeleteEmployerDotBarcodeViewModel(IActorViewService<EmployerDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerDotBarcode = new();
        }
    }
    public class GetsEmployerDotBarcodeViewModel : BaseEmployerDotBarcodeViewModel
    {
        private List<EmployerDotBarcode> _EmployerDotBarcodes = new();
        public List<EmployerDotBarcode> EmployerDotBarcodes
        {
            get=> _EmployerDotBarcodes;
            set
            {
                SetValue(ref _EmployerDotBarcodes, value);   
            }
        }
        public GetsEmployerDotBarcodeViewModel(IActorViewService<EmployerDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerDotBarcode>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerDotBarcodes.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerDotBarcodes.Remove(obj); OnPropertyChanged(); }
        }
    }
}
