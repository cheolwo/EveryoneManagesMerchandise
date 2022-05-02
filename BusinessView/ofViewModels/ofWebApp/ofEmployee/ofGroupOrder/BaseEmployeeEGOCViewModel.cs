using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using BusinessView.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeEGOCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeEGOC> _actorViewService;
        protected EmployeeEGOC? _EmployeeEGOC = new();
        public EmployeeEGOC? EmployeeEGOC
        {
            get => _EmployeeEGOC;
            set
            {
                SetValue(ref _EmployeeEGOC, value);
            }
        }
        public BaseEmployeeEGOCViewModel(IActorViewService<EmployeeEGOC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeEGOC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeEGOCViewModel : BaseEmployeeEGOCViewModel
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
        private EmployeeEGOC? _postEmployeeEGOC = new();
        public EmployeeEGOC? PostEmployeeEGOC
        {
            get => _postEmployeeEGOC;
            set
            {
                SetValue(ref _postEmployeeEGOC, value);
            }
        }
        public PostEmployeeEGOCViewModel(IActorViewService<EmployeeEGOC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeEGOC EmployeeEGOC)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeEGOC);
            if (PostValue != null)
            {
                PostEmployeeEGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEGOC = new();
            _postEmployeeEGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEGOCViewModel : BaseEmployeeEGOCViewModel
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
        private EmployeeEGOC? _putEmployeeEGOC = new();
        public EmployeeEGOC? PutEmployeeEGOC
        {
            get => _putEmployeeEGOC;
            set
            {
                SetValue(ref _putEmployeeEGOC, value);
            }
        }
        public PutEmployeeEGOCViewModel(IActorViewService<EmployeeEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeEGOC EmployeeEGOC)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeEGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEGOC = new();
            _putEmployeeEGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEGOCViewModel : BaseEmployeeEGOCViewModel
    {
        public DeleteEmployeeEGOCViewModel(IActorViewService<EmployeeEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeEGOC = new();
        }
    }
    public class GetsEmployeeEGOCViewModel : BaseEmployeeEGOCViewModel
    {
        private List<EmployeeEGOC> _EmployeeEGOCs = new();
        public List<EmployeeEGOC> EmployeeEGOCs
        {
            get=> _EmployeeEGOCs;
            set
            {
                SetValue(ref _EmployeeEGOCs, value);   
            }
        }
        public GetsEmployeeEGOCViewModel(IActorViewService<EmployeeEGOC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEGOC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeEGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
