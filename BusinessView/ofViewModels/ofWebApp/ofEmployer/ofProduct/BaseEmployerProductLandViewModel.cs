using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerProductLandViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerProductLand> _actorViewService;
        protected EmployerProductLand? _EmployerProductLand = new();
        public EmployerProductLand? EmployerProductLand
        {
            get => _EmployerProductLand;
            set
            {
                SetValue(ref _EmployerProductLand, value);
            }
        }
        public BaseEmployerProductLandViewModel(IActorViewService<EmployerProductLand> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerProductLand = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployerProductLandViewModel(IActorViewService<EmployerProductLand> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerProductLand EmployerProductLand)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerProductLand);
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
        public PutEmployerProductLandViewModel(IActorViewService<EmployerProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerProductLand EmployerProductLand)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerProductLand);
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
        public DeleteEmployerProductLandViewModel(IActorViewService<EmployerProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployerProductLandViewModel(IActorViewService<EmployerProductLand> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerProductLand>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProductLands.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerProductLands.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerProductLands.Remove(obj); OnPropertyChanged(); }
        }
    }
}
