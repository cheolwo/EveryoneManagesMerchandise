using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeSOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeSOCommodity> _actorViewService;
        protected EmployeeSOCommodity? _EmployeeSOCommodity = new();
        public EmployeeSOCommodity? EmployeeSOCommodity
        {
            get => _EmployeeSOCommodity;
            set
            {
                SetValue(ref _EmployeeSOCommodity, value);
            }
        }
        public BaseEmployeeSOCommodityViewModel(IActorViewService<EmployeeSOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeSOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
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
        private EmployeeSOCommodity? _postEmployeeSOCommodity = new();
        public EmployeeSOCommodity? PostEmployeeSOCommodity
        {
            get => _postEmployeeSOCommodity;
            set
            {
                SetValue(ref _postEmployeeSOCommodity, value);
            }
        }
        public PostEmployeeSOCommodityViewModel(IActorViewService<EmployeeSOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeSOCommodity EmployeeSOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeSOCommodity);
            if (PostValue != null)
            {
                PostEmployeeSOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSOCommodity = new();
            _postEmployeeSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
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
        private EmployeeSOCommodity? _putEmployeeSOCommodity = new();
        public EmployeeSOCommodity? PutEmployeeSOCommodity
        {
            get => _putEmployeeSOCommodity;
            set
            {
                SetValue(ref _putEmployeeSOCommodity, value);
            }
        }
        public PutEmployeeSOCommodityViewModel(IActorViewService<EmployeeSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeSOCommodity EmployeeSOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeSOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSOCommodity = new();
            _putEmployeeSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
    {
        public DeleteEmployeeSOCommodityViewModel(IActorViewService<EmployeeSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeSOCommodity = new();
        }
    }
    public class GetsEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
    {
        private List<EmployeeSOCommodity> _EmployeeSOCommoditys = new();
        public List<EmployeeSOCommodity> EmployeeSOCommoditys
        {
            get=> _EmployeeSOCommoditys;
            set
            {
                SetValue(ref _EmployeeSOCommoditys, value);   
            }
        }
        public GetsEmployeeSOCommodityViewModel(IActorViewService<EmployeeSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
