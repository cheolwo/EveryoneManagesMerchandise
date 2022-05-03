using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerETCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerETCommodity? _EmployerETCommodity = new();
        public EmployerETCommodity? EmployerETCommodity
        {
            get => _EmployerETCommodity;
            set
            {
                SetValue(ref _EmployerETCommodity, value);
            }
        }
        public BaseEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerETCommodity = await _EmployerActorContext.GetByIdAsync<EmployerETCommodity>(id);
        }
    }
    public class PostEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
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
        private EmployerETCommodity? _postEmployerETCommodity = new();
        public EmployerETCommodity? PostEmployerETCommodity
        {
            get => _postEmployerETCommodity;
            set
            {
                SetValue(ref _postEmployerETCommodity, value);
            }
        }
        public PostEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerETCommodity EmployerETCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerETCommodity>(EmployerETCommodity);
            if (PostValue != null)
            {
                PostEmployerETCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerETCommodity = new();
            _postEmployerETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
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
        private EmployerETCommodity? _putEmployerETCommodity = new();
        public EmployerETCommodity? PutEmployerETCommodity
        {
            get => _putEmployerETCommodity;
            set
            {
                SetValue(ref _putEmployerETCommodity, value);
            }
        }
        public PutEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerETCommodity EmployerETCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerETCommodity>(EmployerETCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerETCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerETCommodity = new();
            _putEmployerETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
    {
        public DeleteEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerETCommodity>(id);
        }
        public void Reset()
        {
            EmployerETCommodity = new();
        }
    }
    public class GetsEmployerETCommodityViewModel : BaseEmployerETCommodityViewModel
    {
        private List<EmployerETCommodity> _EmployerETCommoditys = new();
        public List<EmployerETCommodity> EmployerETCommoditys
        {
            get=> _EmployerETCommoditys;
            set
            {
                SetValue(ref _EmployerETCommoditys, value);   
            }
        }
        public GetsEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerETCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerETCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerETCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerETCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerETCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerETCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
