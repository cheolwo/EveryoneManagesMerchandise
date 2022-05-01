using BusinessView.ofGeneric;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerETCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerETCommodity> _actorViewService;
        protected EmployerETCommodity? _EmployerETCommodity = new();
        public EmployerETCommodity? EmployerETCommodity
        {
            get => _EmployerETCommodity;
            set
            {
                SetValue(ref _EmployerETCommodity, value);
            }
        }
        public BaseEmployerETCommodityViewModel(IActorViewService<EmployerETCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerETCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
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
        private EmployerETCommodity? _postEmployerETCommodity = new();
        public EmployerETCommodity? PostEmployerETCommodity
        {
            get => _postEmployerETCommodity;
            set
            {
                SetValue(ref _postEmployerETCommodity, value);
            }
        }
        public PostEmployerETCommodityViewModel(IActorViewService<EmployerETCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerETCommodity EmployerETCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerETCommodity);
            if (PostValue != null)
            {
                PostEmployerETCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerETCommodity = new();
            _postEmployerETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
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
        private EmployerETCommodity? _putEmployerETCommodity = new();
        public EmployerETCommodity? PutEmployerETCommodity
        {
            get => _putEmployerETCommodity;
            set
            {
                SetValue(ref _putEmployerETCommodity, value);
            }
        }
        public PutEmployerETCommodityViewModel(IActorViewService<EmployerETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerETCommodity EmployerETCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerETCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerETCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerETCommodity = new();
            _putEmployerETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
    {
        public DeleteEmployerETCommodityViewModel(IActorViewService<EmployerETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerETCommodity = new();
        }
    }
    public class GetsEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
    {
        private List<EmployerETCommodity> _EmployerETCommoditys = new();
        public List<EmployerETCommodity> EmployerETCommoditys
        {
            get=> _EmployerETCommoditys;
            set
            {
                SetValue(ref _EmployerETCommoditys, value);   
            }
        }
        public GetsEmployerETCommodityViewModel(IActorViewService<EmployerETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerETCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerETCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerETCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
