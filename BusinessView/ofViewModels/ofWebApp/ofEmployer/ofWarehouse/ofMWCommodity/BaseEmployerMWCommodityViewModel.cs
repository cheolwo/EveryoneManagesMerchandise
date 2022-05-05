using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerMWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMWCommodity? _EmployerMWCommodity = new();
        public EmployerMWCommodity? EmployerMWCommodity
        {
            get => _EmployerMWCommodity;
            set
            {
                SetValue(ref _EmployerMWCommodity, value);
            }
        }
        public BaseEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMWCommodity = await _EmployerActorContext.GetByIdAsync<EmployerMWCommodity>(id);
        }
    }
    public class PostEmployerMWCommodityViewModel : BaseEmployerMWCommodityViewModel
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
        private EmployerMWCommodity? _postEmployerMWCommodity = new();
        public EmployerMWCommodity? PostEmployerMWCommodity
        {
            get => _postEmployerMWCommodity;
            set
            {
                SetValue(ref _postEmployerMWCommodity, value);
            }
        }
        public PostEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMWCommodity EmployerMWCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMWCommodity>(EmployerMWCommodity);
            if (PostValue != null)
            {
                PostEmployerMWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMWCommodity = new();
            _postEmployerMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMWCommodityViewModel : BaseEmployerMWCommodityViewModel
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
        private EmployerMWCommodity? _putEmployerMWCommodity = new();
        public EmployerMWCommodity? PutEmployerMWCommodity
        {
            get => _putEmployerMWCommodity;
            set
            {
                SetValue(ref _putEmployerMWCommodity, value);
            }
        }
        public PutEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMWCommodity EmployerMWCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMWCommodity>(EmployerMWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMWCommodity = new();
            _putEmployerMWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMWCommodityViewModel : BaseEmployerMWCommodityViewModel
    {
        public DeleteEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMWCommodity>(id);
        }
        public void Reset()
        {
            EmployerMWCommodity = new();
        }
    }
    public class GetsEmployerMWCommodityViewModel : BaseEmployerMWCommodityViewModel
    {
        private List<EmployerMWCommodity> _EmployerMWCommoditys = new();
        public List<EmployerMWCommodity> EmployerMWCommoditys
        {
            get=> _EmployerMWCommoditys;
            set
            {
                SetValue(ref _EmployerMWCommoditys, value);   
            }
        }
        public GetsEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMWCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerMWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMWCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
