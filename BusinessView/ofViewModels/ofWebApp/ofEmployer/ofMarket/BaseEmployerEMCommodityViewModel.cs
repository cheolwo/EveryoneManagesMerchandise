using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerEMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerEMCommodity> _actorViewService;
        protected EmployerEMCommodity? _EmployerEMCommodity = new();
        public EmployerEMCommodity? EmployerEMCommodity
        {
            get => _EmployerEMCommodity;
            set
            {
                SetValue(ref _EmployerEMCommodity, value);
            }
        }
        public BaseEmployerEMCommodityViewModel(IActorViewService<EmployerEMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerEMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
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
        private EmployerEMCommodity? _postEmployerEMCommodity = new();
        public EmployerEMCommodity? PostEmployerEMCommodity
        {
            get => _postEmployerEMCommodity;
            set
            {
                SetValue(ref _postEmployerEMCommodity, value);
            }
        }
        public PostEmployerEMCommodityViewModel(IActorViewService<EmployerEMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerEMCommodity EmployerEMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerEMCommodity);
            if (PostValue != null)
            {
                PostEmployerEMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEMCommodity = new();
            _postEmployerEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
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
        private EmployerEMCommodity? _putEmployerEMCommodity = new();
        public EmployerEMCommodity? PutEmployerEMCommodity
        {
            get => _putEmployerEMCommodity;
            set
            {
                SetValue(ref _putEmployerEMCommodity, value);
            }
        }
        public PutEmployerEMCommodityViewModel(IActorViewService<EmployerEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerEMCommodity EmployerEMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerEMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEMCommodity = new();
            _putEmployerEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
    {
        public DeleteEmployerEMCommodityViewModel(IActorViewService<EmployerEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerEMCommodity = new();
        }
    }
    public class GetsEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
    {
        private List<EmployerEMCommodity> _EmployerEMCommoditys = new();
        public List<EmployerEMCommodity> EmployerEMCommoditys
        {
            get=> _EmployerEMCommoditys;
            set
            {
                SetValue(ref _EmployerEMCommoditys, value);   
            }
        }
        public GetsEmployerEMCommodityViewModel(IActorViewService<EmployerEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEMCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerEMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
