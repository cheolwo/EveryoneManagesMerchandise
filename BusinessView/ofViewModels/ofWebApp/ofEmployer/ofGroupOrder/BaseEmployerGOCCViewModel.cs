using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCCViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerGOCC> _actorViewService;
        protected EmployerGOCC? _EmployerGOCC = new();
        public EmployerGOCC? EmployerGOCC
        {
            get => _EmployerGOCC;
            set
            {
                SetValue(ref _EmployerGOCC, value);
            }
        }
        public BaseEmployerGOCCViewModel(IActorViewService<EmployerGOCC> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerGOCC = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerGOCCViewModel : BaseEmployerGOCCViewModel
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
        private EmployerGOCC? _postEmployerGOCC = new();
        public EmployerGOCC? PostEmployerGOCC
        {
            get => _postEmployerGOCC;
            set
            {
                SetValue(ref _postEmployerGOCC, value);
            }
        }
        public PostEmployerGOCCViewModel(IActorViewService<EmployerGOCC> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerGOCC EmployerGOCC)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerGOCC);
            if (PostValue != null)
            {
                PostEmployerGOCC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerGOCC = new();
            _postEmployerGOCC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerGOCCViewModel : BaseEmployerGOCCViewModel
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
        private EmployerGOCC? _putEmployerGOCC = new();
        public EmployerGOCC? PutEmployerGOCC
        {
            get => _putEmployerGOCC;
            set
            {
                SetValue(ref _putEmployerGOCC, value);
            }
        }
        public PutEmployerGOCCViewModel(IActorViewService<EmployerGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerGOCC EmployerGOCC)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerGOCC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerGOCC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerGOCC = new();
            _putEmployerGOCC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerGOCCViewModel : BaseEmployerGOCCViewModel
    {
        public DeleteEmployerGOCCViewModel(IActorViewService<EmployerGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerGOCC = new();
        }
    }
    public class GetsEmployerGOCCViewModel : BaseEmployerGOCCViewModel
    {
        private List<EmployerGOCC> _EmployerGOCCs = new();
        public List<EmployerGOCC> EmployerGOCCs
        {
            get=> _EmployerGOCCs;
            set
            {
                SetValue(ref _EmployerGOCCs, value);   
            }
        }
        public GetsEmployerGOCCViewModel(IActorViewService<EmployerGOCC> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerGOCC>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerGOCCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerGOCCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
