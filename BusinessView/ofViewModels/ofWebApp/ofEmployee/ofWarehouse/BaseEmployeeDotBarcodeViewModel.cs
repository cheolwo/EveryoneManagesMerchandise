using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeDotBarcodeViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeDotBarcode> _actorViewService;
        protected EmployeeDotBarcode? _EmployeeDotBarcode = new();
        public EmployeeDotBarcode? EmployeeDotBarcode
        {
            get => _EmployeeDotBarcode;
            set
            {
                SetValue(ref _EmployeeDotBarcode, value);
            }
        }
        public BaseEmployeeDotBarcodeViewModel(IActorViewService<EmployeeDotBarcode> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeDotBarcode = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeDotBarcodeViewModel : BaseEmployeeDotBarcodeViewModel
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
        private EmployeeDotBarcode? _postEmployeeDotBarcode = new();
        public EmployeeDotBarcode? PostEmployeeDotBarcode
        {
            get => _postEmployeeDotBarcode;
            set
            {
                SetValue(ref _postEmployeeDotBarcode, value);
            }
        }
        public PostEmployeeDotBarcodeViewModel(IActorViewService<EmployeeDotBarcode> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeDotBarcode EmployeeDotBarcode)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeDotBarcode);
            if (PostValue != null)
            {
                PostEmployeeDotBarcode = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeDotBarcode = new();
            _postEmployeeDotBarcode = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeDotBarcodeViewModel : BaseEmployeeDotBarcodeViewModel
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
        private EmployeeDotBarcode? _putEmployeeDotBarcode = new();
        public EmployeeDotBarcode? PutEmployeeDotBarcode
        {
            get => _putEmployeeDotBarcode;
            set
            {
                SetValue(ref _putEmployeeDotBarcode, value);
            }
        }
        public PutEmployeeDotBarcodeViewModel(IActorViewService<EmployeeDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeDotBarcode EmployeeDotBarcode)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeDotBarcode);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeDotBarcode = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeDotBarcode = new();
            _putEmployeeDotBarcode = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeDotBarcodeViewModel : BaseEmployeeDotBarcodeViewModel
    {
        public DeleteEmployeeDotBarcodeViewModel(IActorViewService<EmployeeDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeDotBarcode = new();
        }
    }
    public class GetsEmployeeDotBarcodeViewModel : BaseEmployeeDotBarcodeViewModel
    {
        private List<EmployeeDotBarcode> _EmployeeDotBarcodes = new();
        public List<EmployeeDotBarcode> EmployeeDotBarcodes
        {
            get=> _EmployeeDotBarcodes;
            set
            {
                SetValue(ref _EmployeeDotBarcodes, value);   
            }
        }
        public GetsEmployeeDotBarcodeViewModel(IActorViewService<EmployeeDotBarcode> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeDotBarcode>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeDotBarcodes.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeDotBarcodes.Remove(obj); OnPropertyChanged(); }
        }
    }
}
