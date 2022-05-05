using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMMCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMMCommodity? _EmployerMMCommodity = new();
        public EmployerMMCommodity? EmployerMMCommodity
        {
            get => _EmployerMMCommodity;
            set
            {
                SetValue(ref _EmployerMMCommodity, value);
            }
        }
        public BaseEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMMCommodity = await _EmployerActorContext.GetByIdAsync<EmployerMMCommodity>(id);
        }
    }
    public class PostEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
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
        private EmployerMMCommodity? _postEmployerMMCommodity = new();
        public EmployerMMCommodity? PostEmployerMMCommodity
        {
            get => _postEmployerMMCommodity;
            set
            {
                SetValue(ref _postEmployerMMCommodity, value);
            }
        }
        public PostEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMMCommodity EmployerMMCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMMCommodity>(EmployerMMCommodity);
            if (PostValue != null)
            {
                PostEmployerMMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMMCommodity = new();
            _postEmployerMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
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
        private EmployerMMCommodity? _putEmployerMMCommodity = new();
        public EmployerMMCommodity? PutEmployerMMCommodity
        {
            get => _putEmployerMMCommodity;
            set
            {
                SetValue(ref _putEmployerMMCommodity, value);
            }
        }
        public PutEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMMCommodity EmployerMMCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMMCommodity>(EmployerMMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMMCommodity = new();
            _putEmployerMMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
    {
        public DeleteEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMMCommodity>(id);
        }
        public void Reset()
        {
            EmployerMMCommodity = new();
        }
    }
    public class GetsEmployerMMCommodityViewModel : BaseEmployerMMCommodityViewModel
    {
        private List<EmployerMMCommodity> _EmployerMMCommoditys = new();
        public List<EmployerMMCommodity> EmployerMMCommoditys
        {
            get=> _EmployerMMCommoditys;
            set
            {
                SetValue(ref _EmployerMMCommoditys, value);   
            }
        }
        public GetsEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMMCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerMMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMMCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
