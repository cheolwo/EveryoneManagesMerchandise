using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeEWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeEWCommodity? _EmployeeEWCommodity = new();
        public EmployeeEWCommodity? EmployeeEWCommodity
        {
            get => _EmployeeEWCommodity;
            set
            {
                SetValue(ref _EmployeeEWCommodity, value);
            }
        }
        public BaseEmployeeEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeEWCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeEWCommodity>(id);
        }
    }
    public class PostEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
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
        private EmployeeEWCommodity? _postEmployeeEWCommodity = new();
        public EmployeeEWCommodity? PostEmployeeEWCommodity
        {
            get => _postEmployeeEWCommodity;
            set
            {
                SetValue(ref _postEmployeeEWCommodity, value);
            }
        }
        public PostEmployeeEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeEWCommodity EmployeeEWCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeEWCommodity>(EmployeeEWCommodity);
            if (PostValue != null)
            {
                PostEmployeeEWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEWCommodity = new();
            _postEmployeeEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
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
        private EmployeeEWCommodity? _putEmployeeEWCommodity = new();
        public EmployeeEWCommodity? PutEmployeeEWCommodity
        {
            get => _putEmployeeEWCommodity;
            set
            {
                SetValue(ref _putEmployeeEWCommodity, value);
            }
        }
        public PutEmployeeEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeEWCommodity EmployeeEWCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeEWCommodity>(EmployeeEWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEWCommodity = new();
            _putEmployeeEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
    {
        public DeleteEmployeeEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeEWCommodity>(id);
        }
        public void Reset()
        {
            EmployeeEWCommodity = new();
        }
    }
    public class GetsEmployeeEWCommodityViewModel : BaseEmployeeEWCommodityViewModel
    {
        private List<EmployeeEWCommodity> _EmployeeEWCommoditys = new();
        public List<EmployeeEWCommodity> EmployeeEWCommoditys
        {
            get=> _EmployeeEWCommoditys;
            set
            {
                SetValue(ref _EmployeeEWCommoditys, value);   
            }
        }
        public GetsEmployeeEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEWCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeEWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeEWCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeEWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeEWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
