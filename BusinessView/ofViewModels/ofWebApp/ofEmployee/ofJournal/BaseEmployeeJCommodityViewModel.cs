using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeJCommodity> _actorViewService;
        protected EmployeeJCommodity? _EmployeeJCommodity = new();
        public EmployeeJCommodity? EmployeeJCommodity
        {
            get => _EmployeeJCommodity;
            set
            {
                SetValue(ref _EmployeeJCommodity, value);
            }
        }
        public BaseEmployeeJCommodityViewModel(IActorViewService<EmployeeJCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeJCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
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
        private EmployeeJCommodity? _postEmployeeJCommodity = new();
        public EmployeeJCommodity? PostEmployeeJCommodity
        {
            get => _postEmployeeJCommodity;
            set
            {
                SetValue(ref _postEmployeeJCommodity, value);
            }
        }
        public PostEmployeeJCommodityViewModel(IActorViewService<EmployeeJCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeJCommodity EmployeeJCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeJCommodity);
            if (PostValue != null)
            {
                PostEmployeeJCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeJCommodity = new();
            _postEmployeeJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
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
        private EmployeeJCommodity? _putEmployeeJCommodity = new();
        public EmployeeJCommodity? PutEmployeeJCommodity
        {
            get => _putEmployeeJCommodity;
            set
            {
                SetValue(ref _putEmployeeJCommodity, value);
            }
        }
        public PutEmployeeJCommodityViewModel(IActorViewService<EmployeeJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeJCommodity EmployeeJCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeJCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeJCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeJCommodity = new();
            _putEmployeeJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
    {
        public DeleteEmployeeJCommodityViewModel(IActorViewService<EmployeeJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeJCommodity = new();
        }
    }
    public class GetsEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
    {
        private List<EmployeeJCommodity> _EmployeeJCommoditys = new();
        public List<EmployeeJCommodity> EmployeeJCommoditys
        {
            get=> _EmployeeJCommoditys;
            set
            {
                SetValue(ref _EmployeeJCommoditys, value);   
            }
        }
        public GetsEmployeeJCommodityViewModel(IActorViewService<EmployeeJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeJCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeJCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeJCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
