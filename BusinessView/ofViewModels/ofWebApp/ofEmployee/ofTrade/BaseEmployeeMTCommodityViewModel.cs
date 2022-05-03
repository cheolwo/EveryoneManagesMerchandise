using BusinessView.ofGeneric;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeMTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMTCommodity> _actorViewService;
        protected EmployeeMTCommodity? _EmployeeMTCommodity = new();
        public EmployeeMTCommodity? EmployeeMTCommodity
        {
            get => _EmployeeMTCommodity;
            set
            {
                SetValue(ref _EmployeeMTCommodity, value);
            }
        }
        public BaseEmployeeMTCommodityViewModel(IActorViewService<EmployeeMTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeMTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
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
        private EmployeeMTCommodity? _postEmployeeMTCommodity = new();
        public EmployeeMTCommodity? PostEmployeeMTCommodity
        {
            get => _postEmployeeMTCommodity;
            set
            {
                SetValue(ref _postEmployeeMTCommodity, value);
            }
        }
        public PostEmployeeMTCommodityViewModel(IActorViewService<EmployeeMTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMTCommodity EmployeeMTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeMTCommodity);
            if (PostValue != null)
            {
                PostEmployeeMTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMTCommodity = new();
            _postEmployeeMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
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
        private EmployeeMTCommodity? _putEmployeeMTCommodity = new();
        public EmployeeMTCommodity? PutEmployeeMTCommodity
        {
            get => _putEmployeeMTCommodity;
            set
            {
                SetValue(ref _putEmployeeMTCommodity, value);
            }
        }
        public PutEmployeeMTCommodityViewModel(IActorViewService<EmployeeMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMTCommodity EmployeeMTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeMTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMTCommodity = new();
            _putEmployeeMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
    {
        public DeleteEmployeeMTCommodityViewModel(IActorViewService<EmployeeMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMTCommodity = new();
        }
    }
    public class GetsEmployeeMTCommodityViewModel : BaseEmployeeMTCommodityViewModel
    {
        private List<EmployeeMTCommodity> _EmployeeMTCommoditys = new();
        public List<EmployeeMTCommodity> EmployeeMTCommoditys
        {
            get=> _EmployeeMTCommoditys;
            set
            {
                SetValue(ref _EmployeeMTCommoditys, value);   
            }
        }
        public GetsEmployeeMTCommodityViewModel(IActorViewService<EmployeeMTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMTCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
