using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeSPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeSPCommodity> _actorViewService;
        protected EmployeeSPCommodity? _EmployeeSPCommodity = new();
        public EmployeeSPCommodity? EmployeeSPCommodity
        {
            get => _EmployeeSPCommodity;
            set
            {
                SetValue(ref _EmployeeSPCommodity, value);
            }
        }
        public BaseEmployeeSPCommodityViewModel(IActorViewService<EmployeeSPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeSPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
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
        private EmployeeSPCommodity? _postEmployeeSPCommodity = new();
        public EmployeeSPCommodity? PostEmployeeSPCommodity
        {
            get => _postEmployeeSPCommodity;
            set
            {
                SetValue(ref _postEmployeeSPCommodity, value);
            }
        }
        public PostEmployeeSPCommodityViewModel(IActorViewService<EmployeeSPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeSPCommodity EmployeeSPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeSPCommodity);
            if (PostValue != null)
            {
                PostEmployeeSPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSPCommodity = new();
            _postEmployeeSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
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
        private EmployeeSPCommodity? _putEmployeeSPCommodity = new();
        public EmployeeSPCommodity? PutEmployeeSPCommodity
        {
            get => _putEmployeeSPCommodity;
            set
            {
                SetValue(ref _putEmployeeSPCommodity, value);
            }
        }
        public PutEmployeeSPCommodityViewModel(IActorViewService<EmployeeSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeSPCommodity EmployeeSPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeSPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSPCommodity = new();
            _putEmployeeSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
    {
        public DeleteEmployeeSPCommodityViewModel(IActorViewService<EmployeeSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeSPCommodity = new();
        }
    }
    public class GetsEmployeeSPCommodityViewModel : BaseEmployeeSPCommodityViewModel
    {
        private List<EmployeeSPCommodity> _EmployeeSPCommoditys = new();
        public List<EmployeeSPCommodity> EmployeeSPCommoditys
        {
            get=> _EmployeeSPCommoditys;
            set
            {
                SetValue(ref _EmployeeSPCommoditys, value);   
            }
        }
        public GetsEmployeeSPCommodityViewModel(IActorViewService<EmployeeSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
