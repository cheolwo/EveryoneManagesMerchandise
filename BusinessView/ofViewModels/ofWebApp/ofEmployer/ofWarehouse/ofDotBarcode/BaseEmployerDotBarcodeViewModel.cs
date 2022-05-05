using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerDotBarcodeViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerDotBarcode? _EmployerDotBarcode = new();
        public EmployerDotBarcode? EmployerDotBarcode
        {
            get => _EmployerDotBarcode;
            set
            {
                SetValue(ref _EmployerDotBarcode, value);
            }
        }
        public BaseEmployerDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerDotBarcode = await _EmployerActorContext.GetByIdAsync<EmployerDotBarcode>(id);
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
        public PostEmployerDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerDotBarcode EmployerDotBarcode)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerDotBarcode>(EmployerDotBarcode);
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
        public PutEmployerDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerDotBarcode EmployerDotBarcode)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerDotBarcode>(EmployerDotBarcode);
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
        public DeleteEmployerDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerDotBarcode>(id);
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
        public GetsEmployerDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerDotBarcode>? dtos = await _EmployerActorContext.GetsAsync<EmployerDotBarcode>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerDotBarcode>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerDotBarcode>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerDotBarcodes.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerDotBarcodes.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerDotBarcodes.Remove(obj); OnPropertyChanged(); }
        }
    }
}
