using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerTCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerTCommodity> _actorViewService;
        protected EmployerTCommodity? _EmployerTCommodity = new();
        public EmployerTCommodity? EmployerTCommodity
        {
            get => _EmployerTCommodity;
            set
            {
                SetValue(ref _EmployerTCommodity, value);
            }
        }
        public BaseEmployerTCommodityViewModel(IActorViewService<EmployerTCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerTCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerTCommodityViewModel : BaseEmployerTCommodityViewModel
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
        private EmployerTCommodity? _postEmployerTCommodity = new();
        public EmployerTCommodity? PostEmployerTCommodity
        {
            get => _postEmployerTCommodity;
            set
            {
                SetValue(ref _postEmployerTCommodity, value);
            }
        }
        public PostEmployerTCommodityViewModel(IActorViewService<EmployerTCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerTCommodity EmployerTCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerTCommodity);
            if (PostValue != null)
            {
                PostEmployerTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerTCommodity = new();
            _postEmployerTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerTCommodityViewModel : BaseEmployerTCommodityViewModel
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
        private EmployerTCommodity? _putEmployerTCommodity = new();
        public EmployerTCommodity? PutEmployerTCommodity
        {
            get => _putEmployerTCommodity;
            set
            {
                SetValue(ref _putEmployerTCommodity, value);
            }
        }
        public PutEmployerTCommodityViewModel(IActorViewService<EmployerTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerTCommodity EmployerTCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerTCommodity = new();
            _putEmployerTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerTCommodityViewModel : BaseEmployerTCommodityViewModel
    {
        public DeleteEmployerTCommodityViewModel(IActorViewService<EmployerTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerTCommodity = new();
        }
    }
    public class GetsEmployerTCommodityViewModel : BaseEmployerTCommodityViewModel
    {
        private List<EmployerTCommodity> _EmployerTCommoditys = new();
        public List<EmployerTCommodity> EmployerTCommoditys
        {
            get=> _EmployerTCommoditys;
            set
            {
                SetValue(ref _EmployerTCommoditys, value);   
            }
        }
        public GetsEmployerTCommodityViewModel(IActorViewService<EmployerTCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerTCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
