using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerSTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerSTCommodity> _actorViewService;
        protected EmployerSTCommodity? _EmployerSTCommodity = new();
        public EmployerSTCommodity? EmployerSTCommodity
        {
            get => _EmployerSTCommodity;
            set
            {
                SetValue(ref _EmployerSTCommodity, value);
            }
        }
        public BaseEmployerSTCommodityViewModel(IActorViewService<EmployerSTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerSTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerSTCommodityViewModel : BaseEmployerSTCommodityViewModel
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
        private EmployerSTCommodity? _postEmployerSTCommodity = new();
        public EmployerSTCommodity? PostEmployerSTCommodity
        {
            get => _postEmployerSTCommodity;
            set
            {
                SetValue(ref _postEmployerSTCommodity, value);
            }
        }
        public PostEmployerSTCommodityViewModel(IActorViewService<EmployerSTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerSTCommodity EmployerSTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerSTCommodity);
            if (PostValue != null)
            {
                PostEmployerSTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSTCommodity = new();
            _postEmployerSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSTCommodityViewModel : BaseEmployerSTCommodityViewModel
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
        private EmployerSTCommodity? _putEmployerSTCommodity = new();
        public EmployerSTCommodity? PutEmployerSTCommodity
        {
            get => _putEmployerSTCommodity;
            set
            {
                SetValue(ref _putEmployerSTCommodity, value);
            }
        }
        public PutEmployerSTCommodityViewModel(IActorViewService<EmployerSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerSTCommodity EmployerSTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerSTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSTCommodity = new();
            _putEmployerSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSTCommodityViewModel : BaseEmployerSTCommodityViewModel
    {
        public DeleteEmployerSTCommodityViewModel(IActorViewService<EmployerSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerSTCommodity = new();
        }
    }
    public class GetsEmployerSTCommodityViewModel : BaseEmployerSTCommodityViewModel
    {
        private List<EmployerSTCommodity> _EmployerSTCommoditys = new();
        public List<EmployerSTCommodity> EmployerSTCommoditys
        {
            get=> _EmployerSTCommoditys;
            set
            {
                SetValue(ref _EmployerSTCommoditys, value);   
            }
        }
        public GetsEmployerSTCommodityViewModel(IActorViewService<EmployerSTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSTCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerSTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
