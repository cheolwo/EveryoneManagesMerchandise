using BusinessView.ofGeneric;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerMTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerMTCommodity> _actorViewService;
        protected EmployerMTCommodity? _EmployerMTCommodity = new();
        public EmployerMTCommodity? EmployerMTCommodity
        {
            get => _EmployerMTCommodity;
            set
            {
                SetValue(ref _EmployerMTCommodity, value);
            }
        }
        public BaseEmployerMTCommodityViewModel(IActorViewService<EmployerMTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerMTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
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
        private EmployerMTCommodity? _postEmployerMTCommodity = new();
        public EmployerMTCommodity? PostEmployerMTCommodity
        {
            get => _postEmployerMTCommodity;
            set
            {
                SetValue(ref _postEmployerMTCommodity, value);
            }
        }
        public PostEmployerMTCommodityViewModel(IActorViewService<EmployerMTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerMTCommodity EmployerMTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerMTCommodity);
            if (PostValue != null)
            {
                PostEmployerMTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMTCommodity = new();
            _postEmployerMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
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
        private EmployerMTCommodity? _putEmployerMTCommodity = new();
        public EmployerMTCommodity? PutEmployerMTCommodity
        {
            get => _putEmployerMTCommodity;
            set
            {
                SetValue(ref _putEmployerMTCommodity, value);
            }
        }
        public PutEmployerMTCommodityViewModel(IActorViewService<EmployerMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerMTCommodity EmployerMTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerMTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMTCommodity = new();
            _putEmployerMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
    {
        public DeleteEmployerMTCommodityViewModel(IActorViewService<EmployerMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerMTCommodity = new();
        }
    }
    public class GetsEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
    {
        private List<EmployerMTCommodity> _EmployerMTCommoditys = new();
        public List<EmployerMTCommodity> EmployerMTCommoditys
        {
            get=> _EmployerMTCommoditys;
            set
            {
                SetValue(ref _EmployerMTCommoditys, value);   
            }
        }
        public GetsEmployerMTCommodityViewModel(IActorViewService<EmployerMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMTCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerMTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
