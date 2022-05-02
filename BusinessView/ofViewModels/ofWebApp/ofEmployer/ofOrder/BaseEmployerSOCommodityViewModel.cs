using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerSOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerSOCommodity> _actorViewService;
        protected EmployerSOCommodity? _EmployerSOCommodity = new();
        public EmployerSOCommodity? EmployerSOCommodity
        {
            get => _EmployerSOCommodity;
            set
            {
                SetValue(ref _EmployerSOCommodity, value);
            }
        }
        public BaseEmployerSOCommodityViewModel(IActorViewService<EmployerSOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerSOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
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
        private EmployerSOCommodity? _postEmployerSOCommodity = new();
        public EmployerSOCommodity? PostEmployerSOCommodity
        {
            get => _postEmployerSOCommodity;
            set
            {
                SetValue(ref _postEmployerSOCommodity, value);
            }
        }
        public PostEmployerSOCommodityViewModel(IActorViewService<EmployerSOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerSOCommodity EmployerSOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerSOCommodity);
            if (PostValue != null)
            {
                PostEmployerSOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSOCommodity = new();
            _postEmployerSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
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
        private EmployerSOCommodity? _putEmployerSOCommodity = new();
        public EmployerSOCommodity? PutEmployerSOCommodity
        {
            get => _putEmployerSOCommodity;
            set
            {
                SetValue(ref _putEmployerSOCommodity, value);
            }
        }
        public PutEmployerSOCommodityViewModel(IActorViewService<EmployerSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerSOCommodity EmployerSOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerSOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSOCommodity = new();
            _putEmployerSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
    {
        public DeleteEmployerSOCommodityViewModel(IActorViewService<EmployerSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerSOCommodity = new();
        }
    }
    public class GetsEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
    {
        private List<EmployerSOCommodity> _EmployerSOCommoditys = new();
        public List<EmployerSOCommodity> EmployerSOCommoditys
        {
            get=> _EmployerSOCommoditys;
            set
            {
                SetValue(ref _EmployerSOCommoditys, value);   
            }
        }
        public GetsEmployerSOCommodityViewModel(IActorViewService<EmployerSOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerSOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
