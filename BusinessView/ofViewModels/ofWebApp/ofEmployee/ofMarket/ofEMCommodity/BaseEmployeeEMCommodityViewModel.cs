using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeEMCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeEMCommodity? _EmployeeEMCommodity = new();
        public EmployeeEMCommodity? EmployeeEMCommodity
        {
            get => _EmployeeEMCommodity;
            set
            {
                SetValue(ref _EmployeeEMCommodity, value);
            }
        }
        public BaseEmployeeEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeEMCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeEMCommodity>(id);
        }
    }
    public class PostEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
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
        private EmployeeEMCommodity? _postEmployeeEMCommodity = new();
        public EmployeeEMCommodity? PostEmployeeEMCommodity
        {
            get => _postEmployeeEMCommodity;
            set
            {
                SetValue(ref _postEmployeeEMCommodity, value);
            }
        }
        public PostEmployeeEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeEMCommodity EmployeeEMCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeEMCommodity>(EmployeeEMCommodity);
            if (PostValue != null)
            {
                PostEmployeeEMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEMCommodity = new();
            _postEmployeeEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
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
        private EmployeeEMCommodity? _putEmployeeEMCommodity = new();
        public EmployeeEMCommodity? PutEmployeeEMCommodity
        {
            get => _putEmployeeEMCommodity;
            set
            {
                SetValue(ref _putEmployeeEMCommodity, value);
            }
        }
        public PutEmployeeEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeEMCommodity EmployeeEMCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeEMCommodity>(EmployeeEMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEMCommodity = new();
            _putEmployeeEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
    {
        public DeleteEmployeeEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeEMCommodity>(id);
        }
        public void Reset()
        {
            EmployeeEMCommodity = new();
        }
    }
    public class GetsEmployeeEMCommodityViewModel : BaseEmployeeEMCommodityViewModel
    {
        private List<EmployeeEMCommodity> _EmployeeEMCommoditys = new();
        public List<EmployeeEMCommodity> EmployeeEMCommoditys
        {
            get=> _EmployeeEMCommoditys;
            set
            {
                SetValue(ref _EmployeeEMCommoditys, value);   
            }
        }
        public GetsEmployeeEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEMCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeEMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeEMCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeEMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeEMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
