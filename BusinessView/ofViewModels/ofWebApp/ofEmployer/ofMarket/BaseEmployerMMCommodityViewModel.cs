using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerMMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerMMCommodity> _actorViewService;
        protected EmployerMMCommodity? _EmployerMMCommodity = new();
        public EmployerMMCommodity? EmployerMMCommodity
        {
            get => _EmployerMMCommodity;
            set
            {
                SetValue(ref _EmployerMMCommodity, value);
            }
        }
        public BaseEmployerMMCommodityViewModel(IActorViewService<EmployerMMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerMMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
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
        private EmployerMMCommodity? _postEmployerMMCommodity = new();
        public EmployerMMCommodity? PostEmployerMMCommodity
        {
            get => _postEmployerMMCommodity;
            set
            {
                SetValue(ref _postEmployerMMCommodity, value);
            }
        }
        public PostEmployerMMCommodityViewModel(IActorViewService<EmployerMMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerMMCommodity EmployerMMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerMMCommodity);
            if (PostValue != null)
            {
                PostEmployerMMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMMCommodity = new();
            _postEmployerMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
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
        private EmployerMMCommodity? _putEmployerMMCommodity = new();
        public EmployerMMCommodity? PutEmployerMMCommodity
        {
            get => _putEmployerMMCommodity;
            set
            {
                SetValue(ref _putEmployerMMCommodity, value);
            }
        }
        public PutEmployerMMCommodityViewModel(IActorViewService<EmployerMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerMMCommodity EmployerMMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerMMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMMCommodity = new();
            _putEmployerMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
    {
        public DeleteEmployerMMCommodityViewModel(IActorViewService<EmployerMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerMMCommodity = new();
        }
    }
    public class GetsEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
    {
        private List<EmployerMMCommodity> _EmployerMMCommoditys = new();
        public List<EmployerMMCommodity> EmployerMMCommoditys
        {
            get=> _EmployerMMCommoditys;
            set
            {
                SetValue(ref _EmployerMMCommoditys, value);   
            }
        }
        public GetsEmployerMMCommodityViewModel(IActorViewService<EmployerMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMMCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerMMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
