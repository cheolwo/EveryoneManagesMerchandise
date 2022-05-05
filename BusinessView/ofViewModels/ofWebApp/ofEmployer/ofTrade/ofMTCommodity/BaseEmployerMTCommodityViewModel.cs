using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerMTCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMTCommodity? _EmployerMTCommodity = new();
        public EmployerMTCommodity? EmployerMTCommodity
        {
            get => _EmployerMTCommodity;
            set
            {
                SetValue(ref _EmployerMTCommodity, value);
            }
        }
        public BaseEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMTCommodity = await _EmployerActorContext.GetByIdAsync<EmployerMTCommodity>(id);
        }
    }
    public class PostEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
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
        private EmployerMTCommodity? _postEmployerMTCommodity = new();
        public EmployerMTCommodity? PostEmployerMTCommodity
        {
            get => _postEmployerMTCommodity;
            set
            {
                SetValue(ref _postEmployerMTCommodity, value);
            }
        }
        public PostEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMTCommodity EmployerMTCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMTCommodity>(EmployerMTCommodity);
            if (PostValue != null)
            {
                PostEmployerMTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMTCommodity = new();
            _postEmployerMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
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
        private EmployerMTCommodity? _putEmployerMTCommodity = new();
        public EmployerMTCommodity? PutEmployerMTCommodity
        {
            get => _putEmployerMTCommodity;
            set
            {
                SetValue(ref _putEmployerMTCommodity, value);
            }
        }
        public PutEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMTCommodity EmployerMTCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMTCommodity>(EmployerMTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMTCommodity = new();
            _putEmployerMTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
    {
        public DeleteEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMTCommodity>(id);
        }
        public void Reset()
        {
            EmployerMTCommodity = new();
        }
    }
    public class GetsEmployerMTCommodityViewModel : BaseEmployerMTCommodityViewModel
    {
        private List<EmployerMTCommodity> _EmployerMTCommoditys = new();
        public List<EmployerMTCommodity> EmployerMTCommoditys
        {
            get=> _EmployerMTCommoditys;
            set
            {
                SetValue(ref _EmployerMTCommoditys, value);   
            }
        }
        public GetsEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMTCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerMTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMTCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
