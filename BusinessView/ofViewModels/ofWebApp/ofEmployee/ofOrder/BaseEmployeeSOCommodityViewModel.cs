using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployeeSOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeSOCommodity? _EmployeeSOCommodity = new();
        public EmployeeSOCommodity? EmployeeSOCommodity
        {
            get => _EmployeeSOCommodity;
            set
            {
                SetValue(ref _EmployeeSOCommodity, value);
            }
        }
        public BaseEmployeeSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeSOCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeSOCommodity>(id);
        }
    }
    public class PostEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
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
        private EmployeeSOCommodity? _postEmployeeSOCommodity = new();
        public EmployeeSOCommodity? PostEmployeeSOCommodity
        {
            get => _postEmployeeSOCommodity;
            set
            {
                SetValue(ref _postEmployeeSOCommodity, value);
            }
        }
        public PostEmployeeSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeSOCommodity EmployeeSOCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeSOCommodity>(EmployeeSOCommodity);
            if (PostValue != null)
            {
                PostEmployeeSOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSOCommodity = new();
            _postEmployeeSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
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
        private EmployeeSOCommodity? _putEmployeeSOCommodity = new();
        public EmployeeSOCommodity? PutEmployeeSOCommodity
        {
            get => _putEmployeeSOCommodity;
            set
            {
                SetValue(ref _putEmployeeSOCommodity, value);
            }
        }
        public PutEmployeeSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeSOCommodity EmployeeSOCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeSOCommodity>(EmployeeSOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSOCommodity = new();
            _putEmployeeSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
    {
        public DeleteEmployeeSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeSOCommodity>(id);
        }
        public void Reset()
        {
            EmployeeSOCommodity = new();
        }
    }
    public class GetsEmployeeSOCommodityViewModel : BaseEmployeeSOCommodityViewModel
    {
        private List<EmployeeSOCommodity> _EmployeeSOCommoditys = new();
        public List<EmployeeSOCommodity> EmployeeSOCommoditys
        {
            get=> _EmployeeSOCommoditys;
            set
            {
                SetValue(ref _EmployeeSOCommoditys, value);   
            }
        }
        public GetsEmployeeSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSOCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeSOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeSOCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeSOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeSOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
