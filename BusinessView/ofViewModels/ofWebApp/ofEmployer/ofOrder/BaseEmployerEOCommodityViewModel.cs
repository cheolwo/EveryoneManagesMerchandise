using BusinessView.ofGeneric;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerEOCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerEOCommodity> _actorViewService;
        protected EmployerEOCommodity? _EmployerEOCommodity = new();
        public EmployerEOCommodity? EmployerEOCommodity
        {
            get => _EmployerEOCommodity;
            set
            {
                SetValue(ref _EmployerEOCommodity, value);
            }
        }
        public BaseEmployerEOCommodityViewModel(IActorViewService<EmployerEOCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerEOCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
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
        private EmployerEOCommodity? _postEmployerEOCommodity = new();
        public EmployerEOCommodity? PostEmployerEOCommodity
        {
            get => _postEmployerEOCommodity;
            set
            {
                SetValue(ref _postEmployerEOCommodity, value);
            }
        }
        public PostEmployerEOCommodityViewModel(IActorViewService<EmployerEOCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerEOCommodity EmployerEOCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerEOCommodity);
            if (PostValue != null)
            {
                PostEmployerEOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEOCommodity = new();
            _postEmployerEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
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
        private EmployerEOCommodity? _putEmployerEOCommodity = new();
        public EmployerEOCommodity? PutEmployerEOCommodity
        {
            get => _putEmployerEOCommodity;
            set
            {
                SetValue(ref _putEmployerEOCommodity, value);
            }
        }
        public PutEmployerEOCommodityViewModel(IActorViewService<EmployerEOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerEOCommodity EmployerEOCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerEOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEOCommodity = new();
            _putEmployerEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
    {
        public DeleteEmployerEOCommodityViewModel(IActorViewService<EmployerEOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerEOCommodity = new();
        }
    }
    public class GetsEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
    {
        private List<EmployerEOCommodity> _EmployerEOCommoditys = new();
        public List<EmployerEOCommodity> EmployerEOCommoditys
        {
            get=> _EmployerEOCommoditys;
            set
            {
                SetValue(ref _EmployerEOCommoditys, value);   
            }
        }
        public GetsEmployerEOCommodityViewModel(IActorViewService<EmployerEOCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEOCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerEOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
