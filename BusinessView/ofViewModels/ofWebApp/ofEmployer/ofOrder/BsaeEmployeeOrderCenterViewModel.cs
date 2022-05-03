using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerOrderCenterViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerOrderCenter> _actorViewService;
        protected EmployerOrderCenter? _EmployerOrderCenter = new();
        public EmployerOrderCenter? EmployerOrderCenter
        {
            get => _EmployerOrderCenter;
            set
            {
                SetValue(ref _EmployerOrderCenter, value);
            }
        }
        public BaseEmployerOrderCenterViewModel(IActorViewService<EmployerOrderCenter> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerOrderCenter = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
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
        private EmployerOrderCenter? _postEmployerOrderCenter = new();
        public EmployerOrderCenter? PostEmployerOrderCenter
        {
            get => _postEmployerOrderCenter;
            set
            {
                SetValue(ref _postEmployerOrderCenter, value);
            }
        }
        public PostEmployerOrderCenterViewModel(IActorViewService<EmployerOrderCenter> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerOrderCenter EmployerOrderCenter)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerOrderCenter);
            if (PostValue != null)
            {
                PostEmployerOrderCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerOrderCenter = new();
            _postEmployerOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
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
        private EmployerOrderCenter? _putEmployerOrderCenter = new();
        public EmployerOrderCenter? PutEmployerOrderCenter
        {
            get => _putEmployerOrderCenter;
            set
            {
                SetValue(ref _putEmployerOrderCenter, value);
            }
        }
        public PutEmployerOrderCenterViewModel(IActorViewService<EmployerOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerOrderCenter EmployerOrderCenter)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerOrderCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerOrderCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerOrderCenter = new();
            _putEmployerOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
    {
        public DeleteEmployerOrderCenterViewModel(IActorViewService<EmployerOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerOrderCenter = new();
        }
    }
    public class GetsEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
    {
        private List<EmployerOrderCenter> _EmployerOrderCenters = new();
        public List<EmployerOrderCenter> EmployerOrderCenters
        {
            get=> _EmployerOrderCenters;
            set
            {
                SetValue(ref _EmployerOrderCenters, value);   
            }
        }
        public GetsEmployerOrderCenterViewModel(IActorViewService<EmployerOrderCenter> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerOrderCenter>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerOrderCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerOrderCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
