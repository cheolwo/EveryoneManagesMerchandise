using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerMCommodity> _actorViewService;
        protected EmployerMCommodity? _EmployerMCommodity = new();
        public EmployerMCommodity? EmployerMCommodity
        {
            get => _EmployerMCommodity;
            set
            {
                SetValue(ref _EmployerMCommodity, value);
            }
        }
        public BaseEmployerMCommodityViewModel(IActorViewService<EmployerMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
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
        private EmployerMCommodity? _postEmployerMCommodity = new();
        public EmployerMCommodity? PostEmployerMCommodity
        {
            get => _postEmployerMCommodity;
            set
            {
                SetValue(ref _postEmployerMCommodity, value);
            }
        }
        public PostEmployerMCommodityViewModel(IActorViewService<EmployerMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerMCommodity EmployerMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerMCommodity);
            if (PostValue != null)
            {
                PostEmployerMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMCommodity = new();
            _postEmployerMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
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
        private EmployerMCommodity? _putEmployerMCommodity = new();
        public EmployerMCommodity? PutEmployerMCommodity
        {
            get => _putEmployerMCommodity;
            set
            {
                SetValue(ref _putEmployerMCommodity, value);
            }
        }
        public PutEmployerMCommodityViewModel(IActorViewService<EmployerMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerMCommodity EmployerMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMCommodity = new();
            _putEmployerMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
    {
        public DeleteEmployerMCommodityViewModel(IActorViewService<EmployerMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerMCommodity = new();
        }
    }
    public class GetsEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
    {
        private List<EmployerMCommodity> _EmployerMCommoditys = new();
        public List<EmployerMCommodity> EmployerMCommoditys
        {
            get=> _EmployerMCommoditys;
            set
            {
                SetValue(ref _EmployerMCommoditys, value);   
            }
        }
        public GetsEmployerMCommodityViewModel(IActorViewService<EmployerMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
