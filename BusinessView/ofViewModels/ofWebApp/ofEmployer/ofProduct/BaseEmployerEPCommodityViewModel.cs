using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerEPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerEPCommodity> _actorViewService;
        protected EmployerEPCommodity? _EmployerEPCommodity = new();
        public EmployerEPCommodity? EmployerEPCommodity
        {
            get => _EmployerEPCommodity;
            set
            {
                SetValue(ref _EmployerEPCommodity, value);
            }
        }
        public BaseEmployerEPCommodityViewModel(IActorViewService<EmployerEPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerEPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
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
        private EmployerEPCommodity? _postEmployerEPCommodity = new();
        public EmployerEPCommodity? PostEmployerEPCommodity
        {
            get => _postEmployerEPCommodity;
            set
            {
                SetValue(ref _postEmployerEPCommodity, value);
            }
        }
        public PostEmployerEPCommodityViewModel(IActorViewService<EmployerEPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerEPCommodity EmployerEPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerEPCommodity);
            if (PostValue != null)
            {
                PostEmployerEPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEPCommodity = new();
            _postEmployerEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
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
        private EmployerEPCommodity? _putEmployerEPCommodity = new();
        public EmployerEPCommodity? PutEmployerEPCommodity
        {
            get => _putEmployerEPCommodity;
            set
            {
                SetValue(ref _putEmployerEPCommodity, value);
            }
        }
        public PutEmployerEPCommodityViewModel(IActorViewService<EmployerEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerEPCommodity EmployerEPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerEPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEPCommodity = new();
            _putEmployerEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
    {
        public DeleteEmployerEPCommodityViewModel(IActorViewService<EmployerEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerEPCommodity = new();
        }
    }
    public class GetsEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
    {
        private List<EmployerEPCommodity> _EmployerEPCommoditys = new();
        public List<EmployerEPCommodity> EmployerEPCommoditys
        {
            get=> _EmployerEPCommoditys;
            set
            {
                SetValue(ref _EmployerEPCommoditys, value);   
            }
        }
        public GetsEmployerEPCommodityViewModel(IActorViewService<EmployerEPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerEPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
