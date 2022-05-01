using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMMCommodity> _actorViewService;
        protected EmployeeMMCommodity? _EmployeeMMCommodity = new();
        public EmployeeMMCommodity? EmployeeMMCommodity
        {
            get => _EmployeeMMCommodity;
            set
            {
                SetValue(ref _EmployeeMMCommodity, value);
            }
        }
        public BaseEmployeeMMCommodityViewModel(IActorViewService<EmployeeMMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeMMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMMCommodityViewModel : BaseEmployeeMMCommodityViewModel
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
        private EmployeeMMCommodity? _postEmployeeMMCommodity = new();
        public EmployeeMMCommodity? PostEmployeeMMCommodity
        {
            get => _postEmployeeMMCommodity;
            set
            {
                SetValue(ref _postEmployeeMMCommodity, value);
            }
        }
        public PostEmployeeMMCommodityViewModel(IActorViewService<EmployeeMMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMMCommodity EmployeeMMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeMMCommodity);
            if (PostValue != null)
            {
                PostEmployeeMMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMMCommodity = new();
            _postEmployeeMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMMCommodityViewModel : BaseEmployeeMMCommodityViewModel
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
        private EmployeeMMCommodity? _putEmployeeMMCommodity = new();
        public EmployeeMMCommodity? PutEmployeeMMCommodity
        {
            get => _putEmployeeMMCommodity;
            set
            {
                SetValue(ref _putEmployeeMMCommodity, value);
            }
        }
        public PutEmployeeMMCommodityViewModel(IActorViewService<EmployeeMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMMCommodity EmployeeMMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeMMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMMCommodity = new();
            _putEmployeeMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMMCommodityViewModel : BaseEmployeeMMCommodityViewModel
    {
        public DeleteEmployeeMMCommodityViewModel(IActorViewService<EmployeeMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMMCommodity = new();
        }
    }
    public class GetsEmployeeMMCommodityViewModel : BaseEmployeeMMCommodityViewModel
    {
        private List<EmployeeMMCommodity> _EmployeeMMCommoditys = new();
        public List<EmployeeMMCommodity> EmployeeMMCommoditys
        {
            get=> _EmployeeMMCommoditys;
            set
            {
                SetValue(ref _EmployeeMMCommoditys, value);   
            }
        }
        public GetsEmployeeMMCommodityViewModel(IActorViewService<EmployeeMMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMMCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
