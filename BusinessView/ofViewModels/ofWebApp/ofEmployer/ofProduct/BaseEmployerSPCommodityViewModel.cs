using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerSPCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerSPCommodity> _actorViewService;
        protected EmployerSPCommodity? _EmployerSPCommodity = new();
        public EmployerSPCommodity? EmployerSPCommodity
        {
            get => _EmployerSPCommodity;
            set
            {
                SetValue(ref _EmployerSPCommodity, value);
            }
        }
        public BaseEmployerSPCommodityViewModel(IActorViewService<EmployerSPCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerSPCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
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
        private EmployerSPCommodity? _postEmployerSPCommodity = new();
        public EmployerSPCommodity? PostEmployerSPCommodity
        {
            get => _postEmployerSPCommodity;
            set
            {
                SetValue(ref _postEmployerSPCommodity, value);
            }
        }
        public PostEmployerSPCommodityViewModel(IActorViewService<EmployerSPCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerSPCommodity EmployerSPCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerSPCommodity);
            if (PostValue != null)
            {
                PostEmployerSPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSPCommodity = new();
            _postEmployerSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
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
        private EmployerSPCommodity? _putEmployerSPCommodity = new();
        public EmployerSPCommodity? PutEmployerSPCommodity
        {
            get => _putEmployerSPCommodity;
            set
            {
                SetValue(ref _putEmployerSPCommodity, value);
            }
        }
        public PutEmployerSPCommodityViewModel(IActorViewService<EmployerSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerSPCommodity EmployerSPCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerSPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSPCommodity = new();
            _putEmployerSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
    {
        public DeleteEmployerSPCommodityViewModel(IActorViewService<EmployerSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerSPCommodity = new();
        }
    }
    public class GetsEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
    {
        private List<EmployerSPCommodity> _EmployerSPCommoditys = new();
        public List<EmployerSPCommodity> EmployerSPCommoditys
        {
            get=> _EmployerSPCommoditys;
            set
            {
                SetValue(ref _EmployerSPCommoditys, value);   
            }
        }
        public GetsEmployerSPCommodityViewModel(IActorViewService<EmployerSPCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSPCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerSPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
