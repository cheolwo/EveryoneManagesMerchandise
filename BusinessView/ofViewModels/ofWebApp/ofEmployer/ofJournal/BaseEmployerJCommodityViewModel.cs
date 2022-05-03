using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJCommodityViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerJCommodity> _actorViewService;
        protected EmployerJCommodity? _EmployerJCommodity = new();
        public EmployerJCommodity? EmployerJCommodity
        {
            get => _EmployerJCommodity;
            set
            {
                SetValue(ref _EmployerJCommodity, value);
            }
        }
        public BaseEmployerJCommodityViewModel(IActorViewService<EmployerJCommodity> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerJCommodity = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerJCommodityViewModel : BaseEmployerJCommodityViewModel
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
        private EmployerJCommodity? _postEmployerJCommodity = new();
        public EmployerJCommodity? PostEmployerJCommodity
        {
            get => _postEmployerJCommodity;
            set
            {
                SetValue(ref _postEmployerJCommodity, value);
            }
        }
        public PostEmployerJCommodityViewModel(IActorViewService<EmployerJCommodity> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerJCommodity EmployerJCommodity)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerJCommodity);
            if (PostValue != null)
            {
                PostEmployerJCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerJCommodity = new();
            _postEmployerJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerJCommodityViewModel : BaseEmployerJCommodityViewModel
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
        private EmployerJCommodity? _putEmployerJCommodity = new();
        public EmployerJCommodity? PutEmployerJCommodity
        {
            get => _putEmployerJCommodity;
            set
            {
                SetValue(ref _putEmployerJCommodity, value);
            }
        }
        public PutEmployerJCommodityViewModel(IActorViewService<EmployerJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerJCommodity EmployerJCommodity)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerJCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerJCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerJCommodity = new();
            _putEmployerJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerJCommodityViewModel : BaseEmployerJCommodityViewModel
    {
        public DeleteEmployerJCommodityViewModel(IActorViewService<EmployerJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerJCommodity = new();
        }
    }
    public class GetsEmployerJCommodityViewModel : BaseEmployerJCommodityViewModel
    {
        private List<EmployerJCommodity> _EmployerJCommoditys = new();
        public List<EmployerJCommodity> EmployerJCommoditys
        {
            get=> _EmployerJCommoditys;
            set
            {
                SetValue(ref _EmployerJCommoditys, value);   
            }
        }
        public GetsEmployerJCommodityViewModel(IActorViewService<EmployerJCommodity> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerJCommodity>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerJCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerJCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
