using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerEWCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerEWCommodity> _actorViewService;
        protected EmployerEWCommodity? _EmployerEWCommodity = new();
        public EmployerEWCommodity? EmployerEWCommodity
        {
            get => _EmployerEWCommodity;
            set
            {
                SetValue(ref _EmployerEWCommodity, value);
            }
        }
        public BaseEmployerEWCommodityViewModel(IActorViewService<EmployerEWCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerEWCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
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
        private EmployerEWCommodity? _postEmployerEWCommodity = new();
        public EmployerEWCommodity? PostEmployerEWCommodity
        {
            get => _postEmployerEWCommodity;
            set
            {
                SetValue(ref _postEmployerEWCommodity, value);
            }
        }
        public PostEmployerEWCommodityViewModel(IActorViewService<EmployerEWCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerEWCommodity EmployerEWCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerEWCommodity);
            if (PostValue != null)
            {
                PostEmployerEWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEWCommodity = new();
            _postEmployerEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
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
        private EmployerEWCommodity? _putEmployerEWCommodity = new();
        public EmployerEWCommodity? PutEmployerEWCommodity
        {
            get => _putEmployerEWCommodity;
            set
            {
                SetValue(ref _putEmployerEWCommodity, value);
            }
        }
        public PutEmployerEWCommodityViewModel(IActorViewService<EmployerEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerEWCommodity EmployerEWCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerEWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEWCommodity = new();
            _putEmployerEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
    {
        public DeleteEmployerEWCommodityViewModel(IActorViewService<EmployerEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerEWCommodity = new();
        }
    }
    public class GetsEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
    {
        private List<EmployerEWCommodity> _EmployerEWCommoditys = new();
        public List<EmployerEWCommodity> EmployerEWCommoditys
        {
            get=> _EmployerEWCommoditys;
            set
            {
                SetValue(ref _EmployerEWCommoditys, value);   
            }
        }
        public GetsEmployerEWCommodityViewModel(IActorViewService<EmployerEWCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEWCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerEWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
