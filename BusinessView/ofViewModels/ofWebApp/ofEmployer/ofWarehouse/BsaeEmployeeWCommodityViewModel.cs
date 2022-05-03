using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerWCommodity? _EmployerWCommodity = new();
        public EmployerWCommodity? EmployerWCommodity
        {
            get => _EmployerWCommodity;
            set
            {
                SetValue(ref _EmployerWCommodity, value);
            }
        }
        public BaseEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerWCommodity = await _EmployerActorContext.GetByIdAsync<EmployerWCommodity>(id);
        }
    }
    public class PostEmployerWCommodityViewModel : BaseEmployerWCommodityViewModel
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
        private EmployerWCommodity? _postEmployerWCommodity = new();
        public EmployerWCommodity? PostEmployerWCommodity
        {
            get => _postEmployerWCommodity;
            set
            {
                SetValue(ref _postEmployerWCommodity, value);
            }
        }
        public PostEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerWCommodity EmployerWCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerWCommodity>(EmployerWCommodity);
            if (PostValue != null)
            {
                PostEmployerWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerWCommodity = new();
            _postEmployerWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerWCommodityViewModel : BaseEmployerWCommodityViewModel
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
        private EmployerWCommodity? _putEmployerWCommodity = new();
        public EmployerWCommodity? PutEmployerWCommodity
        {
            get => _putEmployerWCommodity;
            set
            {
                SetValue(ref _putEmployerWCommodity, value);
            }
        }
        public PutEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerWCommodity EmployerWCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerWCommodity>(EmployerWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerWCommodity = new();
            _putEmployerWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerWCommodityViewModel : BaseEmployerWCommodityViewModel
    {
        public DeleteEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerWCommodity>(id);
        }
        public void Reset()
        {
            EmployerWCommodity = new();
        }
    }
    public class GetsEmployerWCommodityViewModel : BaseEmployerWCommodityViewModel
    {
        private List<EmployerWCommodity> _EmployerWCommoditys = new();
        public List<EmployerWCommodity> EmployerWCommoditys
        {
            get=> _EmployerWCommoditys;
            set
            {
                SetValue(ref _EmployerWCommoditys, value);   
            }
        }
        public GetsEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerWCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerWCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
