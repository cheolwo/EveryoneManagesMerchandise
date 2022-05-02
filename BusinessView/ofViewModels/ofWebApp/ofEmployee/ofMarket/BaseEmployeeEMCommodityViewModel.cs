using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeEMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeEMCommodity> _actorViewService;
        protected EmployeeEMCommodity? _EmployeeEMCommodity = new();
        public EmployeeEMCommodity? EmployeeEMCommodity
        {
            get => _EmployeeEMCommodity;
            set
            {
                SetValue(ref _EmployeeEMCommodity, value);
            }
        }
        public BaseEmployeeEMCommodityViewModel(IActorViewService<EmployeeEMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeEMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
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
        private EmployeeEMCommodity? _postEmployeeEMCommodity = new();
        public EmployeeEMCommodity? PostEmployeeEMCommodity
        {
            get => _postEmployeeEMCommodity;
            set
            {
                SetValue(ref _postEmployeeEMCommodity, value);
            }
        }
        public PostEmployeeEMCommodityViewModel(IActorViewService<EmployeeEMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeEMCommodity EmployeeEMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeEMCommodity);
            if (PostValue != null)
            {
                PostEmployeeEMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEMCommodity = new();
            _postEmployeeEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
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
        private EmployeeEMCommodity? _putEmployeeEMCommodity = new();
        public EmployeeEMCommodity? PutEmployeeEMCommodity
        {
            get => _putEmployeeEMCommodity;
            set
            {
                SetValue(ref _putEmployeeEMCommodity, value);
            }
        }
        public PutEmployeeEMCommodityViewModel(IActorViewService<EmployeeEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeEMCommodity EmployeeEMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeEMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEMCommodity = new();
            _putEmployeeEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
    {
        public DeleteEmployeeEMCommodityViewModel(IActorViewService<EmployeeEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeEMCommodity = new();
        }
    }
    public class GetsEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
    {
        private List<EmployeeEMCommodity> _EmployeeEMCommoditys = new();
        public List<EmployeeEMCommodity> EmployeeEMCommoditys
        {
            get=> _EmployeeEMCommoditys;
            set
            {
                SetValue(ref _EmployeeEMCommoditys, value);   
            }
        }
        public GetsEmployeeEMCommodityViewModel(IActorViewService<EmployeeEMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeEMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
