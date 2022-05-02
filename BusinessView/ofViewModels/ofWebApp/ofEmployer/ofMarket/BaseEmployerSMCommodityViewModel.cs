using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerSMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerSMCommodity> _actorViewService;
        protected EmployerSMCommodity? _EmployerSMCommodity = new();
        public EmployerSMCommodity? EmployerSMCommodity
        {
            get => _EmployerSMCommodity;
            set
            {
                SetValue(ref _EmployerSMCommodity, value);
            }
        }
        public BaseEmployerSMCommodityViewModel(IActorViewService<EmployerSMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerSMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerSMCommodityViewModel : BaseEmployerSMCommodityViewModel
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
        private EmployerSMCommodity? _postEmployerSMCommodity = new();
        public EmployerSMCommodity? PostEmployerSMCommodity
        {
            get => _postEmployerSMCommodity;
            set
            {
                SetValue(ref _postEmployerSMCommodity, value);
            }
        }
        public PostEmployerSMCommodityViewModel(IActorViewService<EmployerSMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerSMCommodity EmployerSMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerSMCommodity);
            if (PostValue != null)
            {
                PostEmployerSMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSMCommodity = new();
            _postEmployerSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSMCommodityViewModel : BaseEmployerSMCommodityViewModel
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
        private EmployerSMCommodity? _putEmployerSMCommodity = new();
        public EmployerSMCommodity? PutEmployerSMCommodity
        {
            get => _putEmployerSMCommodity;
            set
            {
                SetValue(ref _putEmployerSMCommodity, value);
            }
        }
        public PutEmployerSMCommodityViewModel(IActorViewService<EmployerSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerSMCommodity EmployerSMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerSMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSMCommodity = new();
            _putEmployerSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSMCommodityViewModel : BaseEmployerSMCommodityViewModel
    {
        public DeleteEmployerSMCommodityViewModel(IActorViewService<EmployerSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerSMCommodity = new();
        }
    }
    public class GetsEmployerSMCommodityViewModel : BaseEmployerSMCommodityViewModel
    {
        private List<EmployerSMCommodity> _EmployerSMCommoditys = new();
        public List<EmployerSMCommodity> EmployerSMCommoditys
        {
            get=> _EmployerSMCommoditys;
            set
            {
                SetValue(ref _EmployerSMCommoditys, value);   
            }
        }
        public GetsEmployerSMCommodityViewModel(IActorViewService<EmployerSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerSMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
