using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerOCommodity> _actorViewService;
        protected EmployerOCommodity? _EmployerOCommodity = new();
        public EmployerOCommodity? EmployerOCommodity
        {
            get => _EmployerOCommodity;
            set
            {
                SetValue(ref _EmployerOCommodity, value);
            }
        }
        public BaseEmployerOCommodityViewModel(IActorViewService<EmployerOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
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
        private EmployerOCommodity? _postEmployerOCommodity = new();
        public EmployerOCommodity? PostEmployerOCommodity
        {
            get => _postEmployerOCommodity;
            set
            {
                SetValue(ref _postEmployerOCommodity, value);
            }
        }
        public PostEmployerOCommodityViewModel(IActorViewService<EmployerOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerOCommodity EmployerOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerOCommodity);
            if (PostValue != null)
            {
                PostEmployerOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerOCommodity = new();
            _postEmployerOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
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
        private EmployerOCommodity? _putEmployerOCommodity = new();
        public EmployerOCommodity? PutEmployerOCommodity
        {
            get => _putEmployerOCommodity;
            set
            {
                SetValue(ref _putEmployerOCommodity, value);
            }
        }
        public PutEmployerOCommodityViewModel(IActorViewService<EmployerOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerOCommodity EmployerOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerOCommodity = new();
            _putEmployerOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
    {
        public DeleteEmployerOCommodityViewModel(IActorViewService<EmployerOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerOCommodity = new();
        }
    }
    public class GetsEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
    {
        private List<EmployerOCommodity> _EmployerOCommoditys = new();
        public List<EmployerOCommodity> EmployerOCommoditys
        {
            get=> _EmployerOCommoditys;
            set
            {
                SetValue(ref _EmployerOCommoditys, value);   
            }
        }
        public GetsEmployerOCommodityViewModel(IActorViewService<EmployerOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerOCommodity>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
