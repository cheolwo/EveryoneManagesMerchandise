using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProductLandViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeProductLand> _actorViewService;
        protected EmployeeProductLand? _EmployeeProductLand = new();
        public EmployeeProductLand? EmployeeProductLand
        {
            get => _EmployeeProductLand;
            set
            {
                SetValue(ref _EmployeeProductLand, value);
            }
        }
        public BaseEmployeeProductLandViewModel(IActorViewService<EmployeeProductLand> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeProductLand = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
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
        private EmployeeProductLand? _postEmployeeProductLand = new();
        public EmployeeProductLand? PostEmployeeProductLand
        {
            get => _postEmployeeProductLand;
            set
            {
                SetValue(ref _postEmployeeProductLand, value);
            }
        }
        public PostEmployeeProductLandViewModel(IActorViewService<EmployeeProductLand> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeProductLand EmployeeProductLand)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeProductLand);
            if (PostValue != null)
            {
                PostEmployeeProductLand = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeProductLand = new();
            _postEmployeeProductLand = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
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
        private EmployeeProductLand? _putEmployeeProductLand = new();
        public EmployeeProductLand? PutEmployeeProductLand
        {
            get => _putEmployeeProductLand;
            set
            {
                SetValue(ref _putEmployeeProductLand, value);
            }
        }
        public PutEmployeeProductLandViewModel(IActorViewService<EmployeeProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeProductLand EmployeeProductLand)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeProductLand);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeProductLand = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeProductLand = new();
            _putEmployeeProductLand = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
    {
        public DeleteEmployeeProductLandViewModel(IActorViewService<EmployeeProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeProductLand = new();
        }
    }
    public class GetsEmployeeProductLandViewModel : BaseEmployeeProductLandViewModel
    {
        private List<EmployeeProductLand> _EmployeeProductLands = new();
        public List<EmployeeProductLand> EmployeeProductLands
        {
            get=> _EmployeeProductLands;
            set
            {
                SetValue(ref _EmployeeProductLands, value);   
            }
        }
        public GetsEmployeeProductLandViewModel(IActorViewService<EmployeeProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeProductLand>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeProductLands.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeProductLands.Remove(obj); OnPropertyChanged(); }
        }
    }
}
