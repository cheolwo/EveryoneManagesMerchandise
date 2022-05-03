using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeSWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeSWCommodity> _actorViewService;
        protected EmployeeSWCommodity? _EmployeeSWCommodity = new();
        public EmployeeSWCommodity? EmployeeSWCommodity
        {
            get => _EmployeeSWCommodity;
            set
            {
                SetValue(ref _EmployeeSWCommodity, value);
            }
        }
        public BaseEmployeeSWCommodityViewModel(IActorViewService<EmployeeSWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeSWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
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
        private EmployeeSWCommodity? _postEmployeeSWCommodity = new();
        public EmployeeSWCommodity? PostEmployeeSWCommodity
        {
            get => _postEmployeeSWCommodity;
            set
            {
                SetValue(ref _postEmployeeSWCommodity, value);
            }
        }
        public PostEmployeeSWCommodityViewModel(IActorViewService<EmployeeSWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeSWCommodity EmployeeSWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeSWCommodity);
            if (PostValue != null)
            {
                PostEmployeeSWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSWCommodity = new();
            _postEmployeeSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
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
        private EmployeeSWCommodity? _putEmployeeSWCommodity = new();
        public EmployeeSWCommodity? PutEmployeeSWCommodity
        {
            get => _putEmployeeSWCommodity;
            set
            {
                SetValue(ref _putEmployeeSWCommodity, value);
            }
        }
        public PutEmployeeSWCommodityViewModel(IActorViewService<EmployeeSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeSWCommodity EmployeeSWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeSWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSWCommodity = new();
            _putEmployeeSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
    {
        public DeleteEmployeeSWCommodityViewModel(IActorViewService<EmployeeSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeSWCommodity = new();
        }
    }
    public class GetsEmployeeSWCommodityViewModel : BaseEmployeeSWCommodityViewModel
    {
        private List<EmployeeSWCommodity> _EmployeeSWCommoditys = new();
        public List<EmployeeSWCommodity> EmployeeSWCommoditys
        {
            get=> _EmployeeSWCommoditys;
            set
            {
                SetValue(ref _EmployeeSWCommoditys, value);   
            }
        }
        public GetsEmployeeSWCommodityViewModel(IActorViewService<EmployeeSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
