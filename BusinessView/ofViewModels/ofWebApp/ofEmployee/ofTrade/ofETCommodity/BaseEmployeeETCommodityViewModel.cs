using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeETCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeETCommodity? _EmployeeETCommodity = new();
        public EmployeeETCommodity? EmployeeETCommodity
        {
            get => _EmployeeETCommodity;
            set
            {
                SetValue(ref _EmployeeETCommodity, value);
            }
        }
        public BaseEmployeeETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeETCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeETCommodity>(id);
        }
    }
    public class PostEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
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
        private EmployeeETCommodity? _postEmployeeETCommodity = new();
        public EmployeeETCommodity? PostEmployeeETCommodity
        {
            get => _postEmployeeETCommodity;
            set
            {
                SetValue(ref _postEmployeeETCommodity, value);
            }
        }
        public PostEmployeeETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeETCommodity EmployeeETCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeETCommodity>(EmployeeETCommodity);
            if (PostValue != null)
            {
                PostEmployeeETCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeETCommodity = new();
            _postEmployeeETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
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
        private EmployeeETCommodity? _putEmployeeETCommodity = new();
        public EmployeeETCommodity? PutEmployeeETCommodity
        {
            get => _putEmployeeETCommodity;
            set
            {
                SetValue(ref _putEmployeeETCommodity, value);
            }
        }
        public PutEmployeeETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeETCommodity EmployeeETCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeETCommodity>(EmployeeETCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeETCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeETCommodity = new();
            _putEmployeeETCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
    {
        public DeleteEmployeeETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeETCommodity>(id);
        }
        public void Reset()
        {
            EmployeeETCommodity = new();
        }
    }
    public class GetsEmployeeETCommodityViewModel : BaseEmployeeETCommodityViewModel
    {
        private List<EmployeeETCommodity> _EmployeeETCommoditys = new();
        public List<EmployeeETCommodity> EmployeeETCommoditys
        {
            get=> _EmployeeETCommoditys;
            set
            {
                SetValue(ref _EmployeeETCommoditys, value);   
            }
        }
        public GetsEmployeeETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeETCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeETCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeETCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeETCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeETCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeETCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeETCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
