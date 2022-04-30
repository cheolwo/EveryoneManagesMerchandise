
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeGOCCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeGOCC> _actorViewService;
        protected EmployeeGOCC? _EmployeeGOCC = new();
        public EmployeeGOCC? EmployeeGOCC
        {
            get => _EmployeeGOCC;
            set
            {
                SetValue(ref _EmployeeGOCC, value);
            }
        }
        public BaseEmployeeGOCCViewModel(IActorViewService<EmployeeGOCC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeGOCC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
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
        private EmployeeGOCC? _postEmployeeGOCC = new();
        public EmployeeGOCC? PostEmployeeGOCC
        {
            get => _postEmployeeGOCC;
            set
            {
                SetValue(ref _postEmployeeGOCC, value);
            }
        }
        public PostEmployeeGOCCViewModel(IActorViewService<EmployeeGOCC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeGOCC EmployeeGOCC)
        {
            var PostEmployeeGOCC = await _actorViewService.PostAsync(EmployeeGOCC);
            if (PostEmployeeGOCC != null)
            {
                PostEmployeeGOCC = PostEmployeeGOCC;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeGOCC = new();
            _postEmployeeGOCC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
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
        private EmployeeGOCC? _putEmployeeGOCC = new();
        public EmployeeGOCC? PutEmployeeGOCC
        {
            get => _putEmployeeGOCC;
            set
            {
                SetValue(ref _putEmployeeGOCC, value);
            }
        }
        public PutEmployeeGOCCViewModel(IActorViewService<EmployeeGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeGOCC EmployeeGOCC)
        {
            var PutEmployeeGOCC = await _actorViewService.PutAsync(EmployeeGOCC);
            if(PutEmployeeGOCC != null)
            {
                isPut = true;
                PutEmployeeGOCC = PutEmployeeGOCC;
            }
        }
        public void Reset()
        {
            isPut = false;
            _EmployeeGOCC = new();
            _putEmployeeGOCC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
    {
        public DeleteEmployeeGOCCViewModel(IActorViewService<EmployeeGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeGOCC = new();
        }
    }
    public class GetsEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
    {
        private List<EmployeeGOCC> _EmployeeGOCCs = new();
        public List<EmployeeGOCC> EmployeeGOCCs
        {
            get=> _EmployeeGOCCs;
            set
            {
                SetValue(ref _EmployeeGOCCs, value);   
            }
        }
        public GetsEmployeeGOCCViewModel(IActorViewService<EmployeeGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeGOCC>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeGOCCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeGOCCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
