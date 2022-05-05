using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeSTCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeSTCommodity? _EmployeeSTCommodity = new();
        public EmployeeSTCommodity? EmployeeSTCommodity
        {
            get => _EmployeeSTCommodity;
            set
            {
                SetValue(ref _EmployeeSTCommodity, value);
            }
        }
        public BaseEmployeeSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeSTCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeSTCommodity>(id);
        }
    }
    public class PostEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
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
        private EmployeeSTCommodity? _postEmployeeSTCommodity = new();
        public EmployeeSTCommodity? PostEmployeeSTCommodity
        {
            get => _postEmployeeSTCommodity;
            set
            {
                SetValue(ref _postEmployeeSTCommodity, value);
            }
        }
        public PostEmployeeSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeSTCommodity EmployeeSTCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeSTCommodity>(EmployeeSTCommodity);
            if (PostValue != null)
            {
                PostEmployeeSTCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSTCommodity = new();
            _postEmployeeSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
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
        private EmployeeSTCommodity? _putEmployeeSTCommodity = new();
        public EmployeeSTCommodity? PutEmployeeSTCommodity
        {
            get => _putEmployeeSTCommodity;
            set
            {
                SetValue(ref _putEmployeeSTCommodity, value);
            }
        }
        public PutEmployeeSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeSTCommodity EmployeeSTCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeSTCommodity>(EmployeeSTCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSTCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSTCommodity = new();
            _putEmployeeSTCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
    {
        public DeleteEmployeeSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeSTCommodity>(id);
        }
        public void Reset()
        {
            EmployeeSTCommodity = new();
        }
    }
    public class GetsEmployeeSTCommodityViewModel : BaseEmployeeSTCommodityViewModel
    {
        private List<EmployeeSTCommodity> _EmployeeSTCommoditys = new();
        public List<EmployeeSTCommodity> EmployeeSTCommoditys
        {
            get=> _EmployeeSTCommoditys;
            set
            {
                SetValue(ref _EmployeeSTCommoditys, value);   
            }
        }
        public GetsEmployeeSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSTCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeSTCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeSTCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeSTCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSTCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeSTCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSTCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
