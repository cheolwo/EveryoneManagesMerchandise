using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeSMCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeSMCommodity> _actorViewService;
        protected EmployeeSMCommodity? _EmployeeSMCommodity = new();
        public EmployeeSMCommodity? EmployeeSMCommodity
        {
            get => _EmployeeSMCommodity;
            set
            {
                SetValue(ref _EmployeeSMCommodity, value);
            }
        }
        public BaseEmployeeSMCommodityViewModel(IActorViewService<EmployeeSMCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeSMCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeSMCommodityViewModel : BaseEmployeeSMCommodityViewModel
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
        private EmployeeSMCommodity? _postEmployeeSMCommodity = new();
        public EmployeeSMCommodity? PostEmployeeSMCommodity
        {
            get => _postEmployeeSMCommodity;
            set
            {
                SetValue(ref _postEmployeeSMCommodity, value);
            }
        }
        public PostEmployeeSMCommodityViewModel(IActorViewService<EmployeeSMCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeSMCommodity EmployeeSMCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeSMCommodity);
            if (PostValue != null)
            {
                PostEmployeeSMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSMCommodity = new();
            _postEmployeeSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSMCommodityViewModel : BaseEmployeeSMCommodityViewModel
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
        private EmployeeSMCommodity? _putEmployeeSMCommodity = new();
        public EmployeeSMCommodity? PutEmployeeSMCommodity
        {
            get => _putEmployeeSMCommodity;
            set
            {
                SetValue(ref _putEmployeeSMCommodity, value);
            }
        }
        public PutEmployeeSMCommodityViewModel(IActorViewService<EmployeeSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeSMCommodity EmployeeSMCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeSMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSMCommodity = new();
            _putEmployeeSMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSMCommodityViewModel : BaseEmployeeSMCommodityViewModel
    {
        public DeleteEmployeeSMCommodityViewModel(IActorViewService<EmployeeSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeSMCommodity = new();
        }
    }
    public class GetsEmployeeSMCommodityViewModel : BaseEmployeeSMCommodityViewModel
    {
        private List<EmployeeSMCommodity> _EmployeeSMCommoditys = new();
        public List<EmployeeSMCommodity> EmployeeSMCommoditys
        {
            get=> _EmployeeSMCommoditys;
            set
            {
                SetValue(ref _EmployeeSMCommoditys, value);   
            }
        }
        public GetsEmployeeSMCommodityViewModel(IActorViewService<EmployeeSMCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSMCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
