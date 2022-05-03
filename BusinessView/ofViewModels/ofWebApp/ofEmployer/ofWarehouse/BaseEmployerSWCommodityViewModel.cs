using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerSWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerSWCommodity> _actorViewService;
        protected EmployerSWCommodity? _EmployerSWCommodity = new();
        public EmployerSWCommodity? EmployerSWCommodity
        {
            get => _EmployerSWCommodity;
            set
            {
                SetValue(ref _EmployerSWCommodity, value);
            }
        }
        public BaseEmployerSWCommodityViewModel(IActorViewService<EmployerSWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerSWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
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
        private EmployerSWCommodity? _postEmployerSWCommodity = new();
        public EmployerSWCommodity? PostEmployerSWCommodity
        {
            get => _postEmployerSWCommodity;
            set
            {
                SetValue(ref _postEmployerSWCommodity, value);
            }
        }
        public PostEmployerSWCommodityViewModel(IActorViewService<EmployerSWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerSWCommodity EmployerSWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerSWCommodity);
            if (PostValue != null)
            {
                PostEmployerSWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSWCommodity = new();
            _postEmployerSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
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
        private EmployerSWCommodity? _putEmployerSWCommodity = new();
        public EmployerSWCommodity? PutEmployerSWCommodity
        {
            get => _putEmployerSWCommodity;
            set
            {
                SetValue(ref _putEmployerSWCommodity, value);
            }
        }
        public PutEmployerSWCommodityViewModel(IActorViewService<EmployerSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerSWCommodity EmployerSWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerSWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSWCommodity = new();
            _putEmployerSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
    {
        public DeleteEmployerSWCommodityViewModel(IActorViewService<EmployerSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerSWCommodity = new();
        }
    }
    public class GetsEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
    {
        private List<EmployerSWCommodity> _EmployerSWCommoditys = new();
        public List<EmployerSWCommodity> EmployerSWCommoditys
        {
            get=> _EmployerSWCommoditys;
            set
            {
                SetValue(ref _EmployerSWCommoditys, value);   
            }
        }
        public GetsEmployerSWCommodityViewModel(IActorViewService<EmployerSWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerSWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
