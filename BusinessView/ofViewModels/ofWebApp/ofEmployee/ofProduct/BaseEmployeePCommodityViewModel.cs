using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeePCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeePCommodity> _actorViewService;
        protected EmployeePCommodity? _EmployeePCommodity = new();
        public EmployeePCommodity? EmployeePCommodity
        {
            get => _EmployeePCommodity;
            set
            {
                SetValue(ref _EmployeePCommodity, value);
            }
        }
        public BaseEmployeePCommodityViewModel(IActorViewService<EmployeePCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeePCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
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
        private EmployeePCommodity? _postEmployeePCommodity = new();
        public EmployeePCommodity? PostEmployeePCommodity
        {
            get => _postEmployeePCommodity;
            set
            {
                SetValue(ref _postEmployeePCommodity, value);
            }
        }
        public PostEmployeePCommodityViewModel(IActorViewService<EmployeePCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeePCommodity EmployeePCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeePCommodity);
            if (PostValue != null)
            {
                PostEmployeePCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeePCommodity = new();
            _postEmployeePCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
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
        private EmployeePCommodity? _putEmployeePCommodity = new();
        public EmployeePCommodity? PutEmployeePCommodity
        {
            get => _putEmployeePCommodity;
            set
            {
                SetValue(ref _putEmployeePCommodity, value);
            }
        }
        public PutEmployeePCommodityViewModel(IActorViewService<EmployeePCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeePCommodity EmployeePCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeePCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeePCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeePCommodity = new();
            _putEmployeePCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
    {
        public DeleteEmployeePCommodityViewModel(IActorViewService<EmployeePCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeePCommodity = new();
        }
    }
    public class GetsEmployeePCommodityViewModel : BaseEmployeePCommodityViewModel
    {
        private List<EmployeePCommodity> _EmployeePCommoditys = new();
        public List<EmployeePCommodity> EmployeePCommoditys
        {
            get=> _EmployeePCommoditys;
            set
            {
                SetValue(ref _EmployeePCommoditys, value);   
            }
        }
        public GetsEmployeePCommodityViewModel(IActorViewService<EmployeePCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeePCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeePCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeePCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeePCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
