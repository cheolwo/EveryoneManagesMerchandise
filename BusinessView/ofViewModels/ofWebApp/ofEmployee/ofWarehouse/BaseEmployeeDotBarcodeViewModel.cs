using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployeeDotBarcodeViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeDotBarcode? _EmployeeDotBarcode = new();
        public EmployeeDotBarcode? EmployeeDotBarcode
        {
            get => _EmployeeDotBarcode;
            set
            {
                SetValue(ref _EmployeeDotBarcode, value);
            }
        }
        public BaseEmployeeDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeDotBarcode = await _EmployeeActorContext.GetByIdAsync<EmployeeDotBarcode>(id);
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
        public PostEmployeeDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeDotBarcode EmployeeDotBarcode)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeDotBarcode>(EmployeeDotBarcode);
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
        public PutEmployeeDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeDotBarcode EmployeeDotBarcode)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeDotBarcode>(EmployeeDotBarcode);
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
        public DeleteEmployeeDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeDotBarcode>(id);
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
        public GetsEmployeeDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeDotBarcode>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeDotBarcode>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeDotBarcode>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeDotBarcode>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeDotBarcodes.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeDotBarcodes.Remove(obj); OnPropertyChanged(); }
        }
    }
}
