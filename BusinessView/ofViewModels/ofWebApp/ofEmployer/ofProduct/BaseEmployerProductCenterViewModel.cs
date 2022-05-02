using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerProductCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerProductCenter> _actorViewService;
        protected EmployerProductCenter? _EmployerProductCenter = new();
        public EmployerProductCenter? EmployerProductCenter
        {
            get => _EmployerProductCenter;
            set
            {
                SetValue(ref _EmployerProductCenter, value);
            }
        }
        public BaseEmployerProductCenterViewModel(IActorViewService<EmployerProductCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerProductCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
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
        private EmployerProductCenter? _postEmployerProductCenter = new();
        public EmployerProductCenter? PostEmployerProductCenter
        {
            get => _postEmployerProductCenter;
            set
            {
                SetValue(ref _postEmployerProductCenter, value);
            }
        }
        public PostEmployerProductCenterViewModel(IActorViewService<EmployerProductCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerProductCenter EmployerProductCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerProductCenter);
            if (PostValue != null)
            {
                PostEmployerProductCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerProductCenter = new();
            _postEmployerProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
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
        private EmployerProductCenter? _putEmployerProductCenter = new();
        public EmployerProductCenter? PutEmployerProductCenter
        {
            get => _putEmployerProductCenter;
            set
            {
                SetValue(ref _putEmployerProductCenter, value);
            }
        }
        public PutEmployerProductCenterViewModel(IActorViewService<EmployerProductCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerProductCenter EmployerProductCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerProductCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerProductCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerProductCenter = new();
            _putEmployerProductCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
    {
        public DeleteEmployerProductCenterViewModel(IActorViewService<EmployerProductCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerProductCenter = new();
        }
    }
    public class GetsEmployerProductCenterViewModel : BaseEmployerProductCenterViewModel
    {
        private List<EmployerProductCenter> _EmployerProductCenters = new();
        public List<EmployerProductCenter> EmployerProductCenters
        {
            get=> _EmployerProductCenters;
            set
            {
                SetValue(ref _EmployerProductCenters, value);   
            }
        }
        public GetsEmployerProductCenterViewModel(IActorViewService<EmployerProductCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerProductCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerProductCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerProductCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerProductCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
