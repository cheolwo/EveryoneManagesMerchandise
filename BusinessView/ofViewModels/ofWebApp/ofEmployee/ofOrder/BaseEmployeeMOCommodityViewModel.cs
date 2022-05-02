using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeMOCommodity> _actorViewService;
        protected EmployeeMOCommodity? _EmployeeMOCommodity = new();
        public EmployeeMOCommodity? EmployeeMOCommodity
        {
            get => _EmployeeMOCommodity;
            set
            {
                SetValue(ref _EmployeeMOCommodity, value);
            }
        }
        public BaseEmployeeMOCommodityViewModel(IActorViewService<EmployeeMOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeMOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
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
        private EmployeeMOCommodity? _postEmployeeMOCommodity = new();
        public EmployeeMOCommodity? PostEmployeeMOCommodity
        {
            get => _postEmployeeMOCommodity;
            set
            {
                SetValue(ref _postEmployeeMOCommodity, value);
            }
        }
        public PostEmployeeMOCommodityViewModel(IActorViewService<EmployeeMOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeMOCommodity EmployeeMOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeMOCommodity);
            if (PostValue != null)
            {
                PostEmployeeMOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMOCommodity = new();
            _postEmployeeMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
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
        private EmployeeMOCommodity? _putEmployeeMOCommodity = new();
        public EmployeeMOCommodity? PutEmployeeMOCommodity
        {
            get => _putEmployeeMOCommodity;
            set
            {
                SetValue(ref _putEmployeeMOCommodity, value);
            }
        }
        public PutEmployeeMOCommodityViewModel(IActorViewService<EmployeeMOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeMOCommodity EmployeeMOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeMOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMOCommodity = new();
            _putEmployeeMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
    {
        public DeleteEmployeeMOCommodityViewModel(IActorViewService<EmployeeMOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeMOCommodity = new();
        }
    }
    public class GetsEmployeeMOCommodityViewModel : BaseEmployeeMOCommodityViewModel
    {
        private List<EmployeeMOCommodity> _EmployeeMOCommoditys = new();
        public List<EmployeeMOCommodity> EmployeeMOCommoditys
        {
            get=> _EmployeeMOCommoditys;
            set
            {
                SetValue(ref _EmployeeMOCommoditys, value);   
            }
        }
        public GetsEmployeeMOCommodityViewModel(IActorViewService<EmployeeMOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
