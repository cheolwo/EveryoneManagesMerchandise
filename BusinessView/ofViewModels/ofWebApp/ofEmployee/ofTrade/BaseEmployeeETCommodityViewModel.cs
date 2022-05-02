using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeETCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeETCommodity> _actorViewService;
        protected EmployeeETCommodity? _EmployeeETCommodity = new();
        public EmployeeETCommodity? EmployeeETCommodity
        {
            get => _EmployeeETCommodity;
            set
            {
                SetValue(ref _EmployeeETCommodity, value);
            }
        }
        public BaseEmployeeETCommodityViewModel(IActorViewService<EmployeeETCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeETCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
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
        private EmployeeETCommodity? _postEmployeeETCommodity = new();
        public EmployeeETCommodity? PostEmployeeETCommodity
        {
            get => _postEmployeeETCommodity;
            set
            {
                SetValue(ref _postEmployeeETCommodity, value);
            }
        }
        public PostEmployeeETCommodityViewModel(IActorViewService<EmployeeETCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeETCommodity EmployeeETCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeETCommodity);
            if (PostValue != null)
            {
                PostEmployeeETCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeETCommodity = new();
            _postEmployeeETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
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
        private EmployeeETCommodity? _putEmployeeETCommodity = new();
        public EmployeeETCommodity? PutEmployeeETCommodity
        {
            get => _putEmployeeETCommodity;
            set
            {
                SetValue(ref _putEmployeeETCommodity, value);
            }
        }
        public PutEmployeeETCommodityViewModel(IActorViewService<EmployeeETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeETCommodity EmployeeETCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeETCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeETCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeETCommodity = new();
            _putEmployeeETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
    {
        public DeleteEmployeeETCommodityViewModel(IActorViewService<EmployeeETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeETCommodity = new();
        }
    }
    public class GetsEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
    {
        private List<EmployeeETCommodity> _EmployeeETCommoditys = new();
        public List<EmployeeETCommodity> EmployeeETCommoditys
        {
            get=> _EmployeeETCommoditys;
            set
            {
                SetValue(ref _EmployeeETCommoditys, value);   
            }
        }
        public GetsEmployeeETCommodityViewModel(IActorViewService<EmployeeETCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeETCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeETCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeETCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
