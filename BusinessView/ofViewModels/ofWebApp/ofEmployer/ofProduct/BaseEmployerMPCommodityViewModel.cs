using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerMPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerMPCommodity> _actorViewService;
        protected EmployerMPCommodity? _EmployerMPCommodity = new();
        public EmployerMPCommodity? EmployerMPCommodity
        {
            get => _EmployerMPCommodity;
            set
            {
                SetValue(ref _EmployerMPCommodity, value);
            }
        }
        public BaseEmployerMPCommodityViewModel(IActorViewService<EmployerMPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerMPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
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
        private EmployerMPCommodity? _postEmployerMPCommodity = new();
        public EmployerMPCommodity? PostEmployerMPCommodity
        {
            get => _postEmployerMPCommodity;
            set
            {
                SetValue(ref _postEmployerMPCommodity, value);
            }
        }
        public PostEmployerMPCommodityViewModel(IActorViewService<EmployerMPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerMPCommodity EmployerMPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerMPCommodity);
            if (PostValue != null)
            {
                PostEmployerMPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMPCommodity = new();
            _postEmployerMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
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
        private EmployerMPCommodity? _putEmployerMPCommodity = new();
        public EmployerMPCommodity? PutEmployerMPCommodity
        {
            get => _putEmployerMPCommodity;
            set
            {
                SetValue(ref _putEmployerMPCommodity, value);
            }
        }
        public PutEmployerMPCommodityViewModel(IActorViewService<EmployerMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerMPCommodity EmployerMPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerMPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMPCommodity = new();
            _putEmployerMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
    {
        public DeleteEmployerMPCommodityViewModel(IActorViewService<EmployerMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerMPCommodity = new();
        }
    }
    public class GetsEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
    {
        private List<EmployerMPCommodity> _EmployerMPCommoditys = new();
        public List<EmployerMPCommodity> EmployerMPCommoditys
        {
            get=> _EmployerMPCommoditys;
            set
            {
                SetValue(ref _EmployerMPCommoditys, value);   
            }
        }
        public GetsEmployerMPCommodityViewModel(IActorViewService<EmployerMPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerMPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
