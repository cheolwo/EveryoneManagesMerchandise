using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeOCommodity> _actorViewService;
        protected EmployeeOCommodity? _EmployeeOCommodity = new();
        public EmployeeOCommodity? EmployeeOCommodity
        {
            get => _EmployeeOCommodity;
            set
            {
                SetValue(ref _EmployeeOCommodity, value);
            }
        }
        public BaseEmployeeOCommodityViewModel(IActorViewService<EmployeeOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
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
        private EmployeeOCommodity? _postEmployeeOCommodity = new();
        public EmployeeOCommodity? PostEmployeeOCommodity
        {
            get => _postEmployeeOCommodity;
            set
            {
                SetValue(ref _postEmployeeOCommodity, value);
            }
        }
        public PostEmployeeOCommodityViewModel(IActorViewService<EmployeeOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeOCommodity EmployeeOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeOCommodity);
            if (PostValue != null)
            {
                PostEmployeeOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeOCommodity = new();
            _postEmployeeOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
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
        private EmployeeOCommodity? _putEmployeeOCommodity = new();
        public EmployeeOCommodity? PutEmployeeOCommodity
        {
            get => _putEmployeeOCommodity;
            set
            {
                SetValue(ref _putEmployeeOCommodity, value);
            }
        }
        public PutEmployeeOCommodityViewModel(IActorViewService<EmployeeOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeOCommodity EmployeeOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeOCommodity = new();
            _putEmployeeOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
    {
        public DeleteEmployeeOCommodityViewModel(IActorViewService<EmployeeOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeOCommodity = new();
        }
    }
    public class GetsEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
    {
        private List<EmployeeOCommodity> _EmployeeOCommoditys = new();
        public List<EmployeeOCommodity> EmployeeOCommoditys
        {
            get=> _EmployeeOCommoditys;
            set
            {
                SetValue(ref _EmployeeOCommoditys, value);   
            }
        }
        public GetsEmployeeOCommodityViewModel(IActorViewService<EmployeeOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
