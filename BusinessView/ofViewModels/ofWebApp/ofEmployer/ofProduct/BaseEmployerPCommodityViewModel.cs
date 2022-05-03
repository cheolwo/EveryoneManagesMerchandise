using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerPCommodity> _actorViewService;
        protected EmployerPCommodity? _EmployerPCommodity = new();
        public EmployerPCommodity? EmployerPCommodity
        {
            get => _EmployerPCommodity;
            set
            {
                SetValue(ref _EmployerPCommodity, value);
            }
        }
        public BaseEmployerPCommodityViewModel(IActorViewService<EmployerPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
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
        private EmployerPCommodity? _postEmployerPCommodity = new();
        public EmployerPCommodity? PostEmployerPCommodity
        {
            get => _postEmployerPCommodity;
            set
            {
                SetValue(ref _postEmployerPCommodity, value);
            }
        }
        public PostEmployerPCommodityViewModel(IActorViewService<EmployerPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerPCommodity EmployerPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerPCommodity);
            if (PostValue != null)
            {
                PostEmployerPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerPCommodity = new();
            _postEmployerPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
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
        private EmployerPCommodity? _putEmployerPCommodity = new();
        public EmployerPCommodity? PutEmployerPCommodity
        {
            get => _putEmployerPCommodity;
            set
            {
                SetValue(ref _putEmployerPCommodity, value);
            }
        }
        public PutEmployerPCommodityViewModel(IActorViewService<EmployerPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerPCommodity EmployerPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerPCommodity = new();
            _putEmployerPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
    {
        public DeleteEmployerPCommodityViewModel(IActorViewService<EmployerPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerPCommodity = new();
        }
    }
    public class GetsEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
    {
        private List<EmployerPCommodity> _EmployerPCommoditys = new();
        public List<EmployerPCommodity> EmployerPCommoditys
        {
            get=> _EmployerPCommoditys;
            set
            {
                SetValue(ref _EmployerPCommoditys, value);   
            }
        }
        public GetsEmployerPCommodityViewModel(IActorViewService<EmployerPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
