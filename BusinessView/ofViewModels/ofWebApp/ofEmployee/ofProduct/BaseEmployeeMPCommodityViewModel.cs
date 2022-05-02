using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMPCommodity> _actorViewService;
        protected EmployeeMPCommodity? _EmployeeMPCommodity = new();
        public EmployeeMPCommodity? EmployeeMPCommodity
        {
            get => _EmployeeMPCommodity;
            set
            {
                SetValue(ref _EmployeeMPCommodity, value);
            }
        }
        public BaseEmployeeMPCommodityViewModel(IActorViewService<EmployeeMPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeMPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
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
        private EmployeeMPCommodity? _postEmployeeMPCommodity = new();
        public EmployeeMPCommodity? PostEmployeeMPCommodity
        {
            get => _postEmployeeMPCommodity;
            set
            {
                SetValue(ref _postEmployeeMPCommodity, value);
            }
        }
        public PostEmployeeMPCommodityViewModel(IActorViewService<EmployeeMPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMPCommodity EmployeeMPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeMPCommodity);
            if (PostValue != null)
            {
                PostEmployeeMPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMPCommodity = new();
            _postEmployeeMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
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
        private EmployeeMPCommodity? _putEmployeeMPCommodity = new();
        public EmployeeMPCommodity? PutEmployeeMPCommodity
        {
            get => _putEmployeeMPCommodity;
            set
            {
                SetValue(ref _putEmployeeMPCommodity, value);
            }
        }
        public PutEmployeeMPCommodityViewModel(IActorViewService<EmployeeMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMPCommodity EmployeeMPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeMPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMPCommodity = new();
            _putEmployeeMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
    {
        public DeleteEmployeeMPCommodityViewModel(IActorViewService<EmployeeMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMPCommodity = new();
        }
    }
    public class GetsEmployeeMPCommodityViewModel : BaseEmployeeMPCommodityViewModel
    {
        private List<EmployeeMPCommodity> _EmployeeMPCommoditys = new();
        public List<EmployeeMPCommodity> EmployeeMPCommoditys
        {
            get=> _EmployeeMPCommoditys;
            set
            {
                SetValue(ref _EmployeeMPCommoditys, value);   
            }
        }
        public GetsEmployeeMPCommodityViewModel(IActorViewService<EmployeeMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
