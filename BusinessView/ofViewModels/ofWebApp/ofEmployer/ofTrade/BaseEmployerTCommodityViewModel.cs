using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerTCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerTCommodity? _EmployerTCommodity = new();
        public EmployerTCommodity? EmployerTCommodity
        {
            get => _EmployerTCommodity;
            set
            {
                SetValue(ref _EmployerTCommodity, value);
            }
        }
        public BaseEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerTCommodity = await _EmployerActorContext.GetByIdAsync<EmployerTCommodity>(id);
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
        public PostEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerTCommodity EmployerTCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerTCommodity>(EmployerTCommodity);
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
        public PutEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerTCommodity EmployerTCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerTCommodity>(EmployerTCommodity);
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
        public DeleteEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerTCommodity>(id);
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
        public GetsEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerTCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerTCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
