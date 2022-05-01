using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMWCommodity> _actorViewService;
        protected EmployeeMWCommodity? _EmployeeMWCommodity = new();
        public EmployeeMWCommodity? EmployeeMWCommodity
        {
            get => _EmployeeMWCommodity;
            set
            {
                SetValue(ref _EmployeeMWCommodity, value);
            }
        }
        public BaseEmployeeMWCommodityViewModel(IActorViewService<EmployeeMWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeMWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
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
        private EmployeeMWCommodity? _postEmployeeMWCommodity = new();
        public EmployeeMWCommodity? PostEmployeeMWCommodity
        {
            get => _postEmployeeMWCommodity;
            set
            {
                SetValue(ref _postEmployeeMWCommodity, value);
            }
        }
        public PostEmployeeMWCommodityViewModel(IActorViewService<EmployeeMWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMWCommodity EmployeeMWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeMWCommodity);
            if (PostValue != null)
            {
                PostEmployeeMWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMWCommodity = new();
            _postEmployeeMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
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
        private EmployeeMWCommodity? _putEmployeeMWCommodity = new();
        public EmployeeMWCommodity? PutEmployeeMWCommodity
        {
            get => _putEmployeeMWCommodity;
            set
            {
                SetValue(ref _putEmployeeMWCommodity, value);
            }
        }
        public PutEmployeeMWCommodityViewModel(IActorViewService<EmployeeMWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMWCommodity EmployeeMWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeMWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMWCommodity = new();
            _putEmployeeMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
    {
        public DeleteEmployeeMWCommodityViewModel(IActorViewService<EmployeeMWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMWCommodity = new();
        }
    }
    public class GetsEmployeeMWCommodityViewModel : BaseEmployeeMWCommodityViewModel
    {
        private List<EmployeeMWCommodity> _EmployeeMWCommoditys = new();
        public List<EmployeeMWCommodity> EmployeeMWCommoditys
        {
            get=> _EmployeeMWCommoditys;
            set
            {
                SetValue(ref _EmployeeMWCommoditys, value);   
            }
        }
        public GetsEmployeeMWCommodityViewModel(IActorViewService<EmployeeMWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMWCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
