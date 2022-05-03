using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMCommodity? _EmployerMCommodity = new();
        public EmployerMCommodity? EmployerMCommodity
        {
            get => _EmployerMCommodity;
            set
            {
                SetValue(ref _EmployerMCommodity, value);
            }
        }
        public BaseEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMCommodity = await _EmployerActorContext.GetByIdAsync<EmployerMCommodity>(id);
        }
    }
    public class PostEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
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
        private EmployerMCommodity? _postEmployerMCommodity = new();
        public EmployerMCommodity? PostEmployerMCommodity
        {
            get => _postEmployerMCommodity;
            set
            {
                SetValue(ref _postEmployerMCommodity, value);
            }
        }
        public PostEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMCommodity EmployerMCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMCommodity>(EmployerMCommodity);
            if (PostValue != null)
            {
                PostEmployerMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMCommodity = new();
            _postEmployerMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
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
        private EmployerMCommodity? _putEmployerMCommodity = new();
        public EmployerMCommodity? PutEmployerMCommodity
        {
            get => _putEmployerMCommodity;
            set
            {
                SetValue(ref _putEmployerMCommodity, value);
            }
        }
        public PutEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMCommodity EmployerMCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMCommodity>(EmployerMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMCommodity = new();
            _putEmployerMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
    {
        public DeleteEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMCommodity>(id);
        }
        public void Reset()
        {
            EmployerMCommodity = new();
        }
    }
    public class GetsEmployerMCommodityViewModel : BaseEmployerMCommodityViewModel
    {
        private List<EmployerMCommodity> _EmployerMCommoditys = new();
        public List<EmployerMCommodity> EmployerMCommoditys
        {
            get=> _EmployerMCommoditys;
            set
            {
                SetValue(ref _EmployerMCommoditys, value);   
            }
        }
        public GetsEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
