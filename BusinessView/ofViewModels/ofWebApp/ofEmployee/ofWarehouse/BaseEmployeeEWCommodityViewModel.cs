using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeEWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeEWCommodity> _actorViewService;
        protected EmployeeEWCommodity? _EmployeeEWCommodity = new();
        public EmployeeEWCommodity? EmployeeEWCommodity
        {
            get => _EmployeeEWCommodity;
            set
            {
                SetValue(ref _EmployeeEWCommodity, value);
            }
        }
        public BaseEmployeeEWCommodityViewModel(IActorViewService<EmployeeEWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeEWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
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
        private EmployeeEWCommodity? _postEmployeeEWCommodity = new();
        public EmployeeEWCommodity? PostEmployeeEWCommodity
        {
            get => _postEmployeeEWCommodity;
            set
            {
                SetValue(ref _postEmployeeEWCommodity, value);
            }
        }
        public PostEmployeeEWCommodityViewModel(IActorViewService<EmployeeEWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeEWCommodity EmployeeEWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeEWCommodity);
            if (PostValue != null)
            {
                PostEmployeeEWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEWCommodity = new();
            _postEmployeeEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
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
        private EmployeeEWCommodity? _putEmployeeEWCommodity = new();
        public EmployeeEWCommodity? PutEmployeeEWCommodity
        {
            get => _putEmployeeEWCommodity;
            set
            {
                SetValue(ref _putEmployeeEWCommodity, value);
            }
        }
        public PutEmployeeEWCommodityViewModel(IActorViewService<EmployeeEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeEWCommodity EmployeeEWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeEWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEWCommodity = new();
            _putEmployeeEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
    {
        public DeleteEmployeeEWCommodityViewModel(IActorViewService<EmployeeEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeEWCommodity = new();
        }
    }
    public class GetsEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
    {
        private List<EmployeeEWCommodity> _EmployeeEWCommoditys = new();
        public List<EmployeeEWCommodity> EmployeeEWCommoditys
        {
            get=> _EmployeeEWCommoditys;
            set
            {
                SetValue(ref _EmployeeEWCommoditys, value);   
            }
        }
        public GetsEmployeeEWCommodityViewModel(IActorViewService<EmployeeEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeEWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
