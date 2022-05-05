using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeEOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeEOCommodity? _EmployeeEOCommodity = new();
        public EmployeeEOCommodity? EmployeeEOCommodity
        {
            get => _EmployeeEOCommodity;
            set
            {
                SetValue(ref _EmployeeEOCommodity, value);
            }
        }
        public BaseEmployeeEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeEOCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeEOCommodity>(id);
        }
    }
    public class PostEmployeeEOCommodityViewModel : BaseEmployeeEOCommodityViewModel
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
        private EmployeeEOCommodity? _postEmployeeEOCommodity = new();
        public EmployeeEOCommodity? PostEmployeeEOCommodity
        {
            get => _postEmployeeEOCommodity;
            set
            {
                SetValue(ref _postEmployeeEOCommodity, value);
            }
        }
        public PostEmployeeEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeEOCommodity EmployeeEOCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeEOCommodity>(EmployeeEOCommodity);
            if (PostValue != null)
            {
                PostEmployeeEOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeEOCommodity = new();
            _postEmployeeEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeEOCommodityViewModel : BaseEmployeeEOCommodityViewModel
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
        private EmployeeEOCommodity? _putEmployeeEOCommodity = new();
        public EmployeeEOCommodity? PutEmployeeEOCommodity
        {
            get => _putEmployeeEOCommodity;
            set
            {
                SetValue(ref _putEmployeeEOCommodity, value);
            }
        }
        public PutEmployeeEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeEOCommodity EmployeeEOCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeEOCommodity>(EmployeeEOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeEOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeEOCommodity = new();
            _putEmployeeEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeEOCommodityViewModel : BaseEmployeeEOCommodityViewModel
    {
        public DeleteEmployeeEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeEOCommodity>(id);
        }
        public void Reset()
        {
            EmployeeEOCommodity = new();
        }
    }
    public class GetsEmployeeEOCommodityViewModel : BaseEmployeeEOCommodityViewModel
    {
        private List<EmployeeEOCommodity> _EmployeeEOCommoditys = new();
        public List<EmployeeEOCommodity> EmployeeEOCommoditys
        {
            get=> _EmployeeEOCommoditys;
            set
            {
                SetValue(ref _EmployeeEOCommoditys, value);   
            }
        }
        public GetsEmployeeEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeEOCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeEOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeEOCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeEOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeEOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeEOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
