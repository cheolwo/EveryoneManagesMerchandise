using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProductLandViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerProductLand? _EmployerProductLand = new();
        public EmployerProductLand? EmployerProductLand
        {
            get => _EmployerProductLand;
            set
            {
                SetValue(ref _EmployerProductLand, value);
            }
        }
        public BaseEmployerProductLandViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerProductLand = await _EmployerActorContext.GetByIdAsync<EmployerProductLand>(id);
        }
    }
    public class PostEmployerProductLandViewModel : BaseEmployerProductLandViewModel
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
        private EmployerProductLand? _postEmployerProductLand = new();
        public EmployerProductLand? PostEmployerProductLand
        {
            get => _postEmployerProductLand;
            set
            {
                SetValue(ref _postEmployerProductLand, value);
            }
        }
        public PostEmployerProductLandViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerProductLand EmployerProductLand)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerProductLand>(EmployerProductLand);
            if (PostValue != null)
            {
                PostEmployerProductLand = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerProductLand = new();
            _postEmployerProductLand = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerProductLandViewModel : BaseEmployerProductLandViewModel
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
        private EmployerProductLand? _putEmployerProductLand = new();
        public EmployerProductLand? PutEmployerProductLand
        {
            get => _putEmployerProductLand;
            set
            {
                SetValue(ref _putEmployerProductLand, value);
            }
        }
        public PutEmployerProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerProductLand EmployerProductLand)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerProductLand>(EmployerProductLand);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerProductLand = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerProductLand = new();
            _putEmployerProductLand = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerProductLandViewModel : BaseEmployerProductLandViewModel
    {
        public DeleteEmployerProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerProductLand>(id);
        }
        public void Reset()
        {
            EmployerProductLand = new();
        }
    }
    public class GetsEmployerProductLandViewModel : BaseEmployerProductLandViewModel
    {
        private List<EmployerProductLand> _EmployerProductLands = new();
        public List<EmployerProductLand> EmployerProductLands
        {
            get=> _EmployerProductLands;
            set
            {
                SetValue(ref _EmployerProductLands, value);   
            }
        }
        public GetsEmployerProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerProductLand>? dtos = await _EmployerActorContext.GetsAsync<EmployerProductLand>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerProductLand>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerProductLand>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerProductLands.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerProductLands.Remove(obj); OnPropertyChanged(); }
        }
    }
}
