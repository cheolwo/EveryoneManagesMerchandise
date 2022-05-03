using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerSTCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerSTCommodity? _EmployerSTCommodity = new();
        public EmployerSTCommodity? EmployerSTCommodity
        {
            get => _EmployerSTCommodity;
            set
            {
                SetValue(ref _EmployerSTCommodity, value);
            }
        }
        public BaseEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerSTCommodity = await _EmployerActorContext.GetByIdAsync<EmployerSTCommodity>(id);
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
        public PostEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerSTCommodity EmployerSTCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerSTCommodity>(EmployerSTCommodity);
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
        public PutEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerSTCommodity EmployerSTCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerSTCommodity>(EmployerSTCommodity);
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
        public DeleteEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerSTCommodity>(id);
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
        public GetsEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSTCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerSTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerSTCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerSTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerSTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
