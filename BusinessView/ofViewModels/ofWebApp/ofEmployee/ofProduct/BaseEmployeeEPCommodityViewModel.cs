using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeEPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeEPCommodity> _actorViewService;
        protected EmployeeEPCommodity? _EmployeeEPCommodity = new();
        public EmployeeEPCommodity? EmployeeEPCommodity
        {
            get => _EmployeeEPCommodity;
            set
            {
                SetValue(ref _EmployeeEPCommodity, value);
            }
        }
        public BaseEmployeeEPCommodityViewModel(IActorViewService<EmployeeEPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeEPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeEPCommodityViewModel : BaseEmployeeEPCommodityViewModel
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
        private EmployeeEPCommodity? _postEmployeeEPCommodity = new();
        public EmployeeEPCommodity? PostEmployeeEPCommodity
        {
            get => _postEmployeeEPCommodity;
            set
            {
                SetValue(ref _postEmployeeEPCommodity, value);
            }
        }
        public PostEmployeeEPCommodityViewModel(IActorViewService<EmployeeEPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeEPCommodity EmployeeEPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeEPCommodity);
            if (PostValue != null)
            {
                PostEmployeeEPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEPCommodity = new();
            _postEmployeeEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEPCommodityViewModel : BaseEmployeeEPCommodityViewModel
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
        private EmployeeEPCommodity? _putEmployeeEPCommodity = new();
        public EmployeeEPCommodity? PutEmployeeEPCommodity
        {
            get => _putEmployeeEPCommodity;
            set
            {
                SetValue(ref _putEmployeeEPCommodity, value);
            }
        }
        public PutEmployeeEPCommodityViewModel(IActorViewService<EmployeeEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeEPCommodity EmployeeEPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeEPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEPCommodity = new();
            _putEmployeeEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEPCommodityViewModel : BaseEmployeeEPCommodityViewModel
    {
        public DeleteEmployeeEPCommodityViewModel(IActorViewService<EmployeeEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeEPCommodity = new();
        }
    }
    public class GetsEmployeeEPCommodityViewModel : BaseEmployeeEPCommodityViewModel
    {
        private List<EmployeeEPCommodity> _EmployeeEPCommoditys = new();
        public List<EmployeeEPCommodity> EmployeeEPCommoditys
        {
            get=> _EmployeeEPCommoditys;
            set
            {
                SetValue(ref _EmployeeEPCommoditys, value);   
            }
        }
        public GetsEmployeeEPCommodityViewModel(IActorViewService<EmployeeEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeEPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
