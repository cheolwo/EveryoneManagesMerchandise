using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeSTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeSTCommodity> _actorViewService;
        protected EmployeeSTCommodity? _EmployeeSTCommodity = new();
        public EmployeeSTCommodity? EmployeeSTCommodity
        {
            get => _EmployeeSTCommodity;
            set
            {
                SetValue(ref _EmployeeSTCommodity, value);
            }
        }
        public BaseEmployeeSTCommodityViewModel(IActorViewService<EmployeeSTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeSTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
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
        private EmployeeSTCommodity? _postEmployeeSTCommodity = new();
        public EmployeeSTCommodity? PostEmployeeSTCommodity
        {
            get => _postEmployeeSTCommodity;
            set
            {
                SetValue(ref _postEmployeeSTCommodity, value);
            }
        }
        public PostEmployeeSTCommodityViewModel(IActorViewService<EmployeeSTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeSTCommodity EmployeeSTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeSTCommodity);
            if (PostValue != null)
            {
                PostEmployeeSTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSTCommodity = new();
            _postEmployeeSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
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
        private EmployeeSTCommodity? _putEmployeeSTCommodity = new();
        public EmployeeSTCommodity? PutEmployeeSTCommodity
        {
            get => _putEmployeeSTCommodity;
            set
            {
                SetValue(ref _putEmployeeSTCommodity, value);
            }
        }
        public PutEmployeeSTCommodityViewModel(IActorViewService<EmployeeSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeSTCommodity EmployeeSTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeSTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSTCommodity = new();
            _putEmployeeSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
    {
        public DeleteEmployeeSTCommodityViewModel(IActorViewService<EmployeeSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeSTCommodity = new();
        }
    }
    public class GetsEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
    {
        private List<EmployeeSTCommodity> _EmployeeSTCommoditys = new();
        public List<EmployeeSTCommodity> EmployeeSTCommoditys
        {
            get=> _EmployeeSTCommoditys;
            set
            {
                SetValue(ref _EmployeeSTCommoditys, value);   
            }
        }
        public GetsEmployeeSTCommodityViewModel(IActorViewService<EmployeeSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSTCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
