using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeWCommodity> _actorViewService;
        protected EmployeeWCommodity? _EmployeeWCommodity = new();
        public EmployeeWCommodity? EmployeeWCommodity
        {
            get => _EmployeeWCommodity;
            set
            {
                SetValue(ref _EmployeeWCommodity, value);
            }
        }
        public BaseEmployeeWCommodityViewModel(IActorViewService<EmployeeWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeWCommodityViewModel : BaseEmployeeWCommodityViewModel
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
        private EmployeeWCommodity? _postEmployeeWCommodity = new();
        public EmployeeWCommodity? PostEmployeeWCommodity
        {
            get => _postEmployeeWCommodity;
            set
            {
                SetValue(ref _postEmployeeWCommodity, value);
            }
        }
        public PostEmployeeWCommodityViewModel(IActorViewService<EmployeeWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeWCommodity EmployeeWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeWCommodity);
            if (PostValue != null)
            {
                PostEmployeeWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeWCommodity = new();
            _postEmployeeWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeWCommodityViewModel : BaseEmployeeWCommodityViewModel
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
        private EmployeeWCommodity? _putEmployeeWCommodity = new();
        public EmployeeWCommodity? PutEmployeeWCommodity
        {
            get => _putEmployeeWCommodity;
            set
            {
                SetValue(ref _putEmployeeWCommodity, value);
            }
        }
        public PutEmployeeWCommodityViewModel(IActorViewService<EmployeeWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeWCommodity EmployeeWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeWCommodity = new();
            _putEmployeeWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeWCommodityViewModel : BaseEmployeeWCommodityViewModel
    {
        public DeleteEmployeeWCommodityViewModel(IActorViewService<EmployeeWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeWCommodity = new();
        }
    }
    public class GetsEmployeeWCommodityViewModel : BaseEmployeeWCommodityViewModel
    {
        private List<EmployeeWCommodity> _EmployeeWCommoditys = new();
        public List<EmployeeWCommodity> EmployeeWCommoditys
        {
            get=> _EmployeeWCommoditys;
            set
            {
                SetValue(ref _EmployeeWCommoditys, value);   
            }
        }
        public GetsEmployeeWCommodityViewModel(IActorViewService<EmployeeWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
