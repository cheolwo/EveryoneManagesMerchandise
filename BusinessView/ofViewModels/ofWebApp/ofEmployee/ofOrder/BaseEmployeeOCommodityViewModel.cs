using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeOCommodity? _EmployeeOCommodity = new();
        public EmployeeOCommodity? EmployeeOCommodity
        {
            get => _EmployeeOCommodity;
            set
            {
                SetValue(ref _EmployeeOCommodity, value);
            }
        }
        public BaseEmployeeOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeOCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeOCommodity>(id);
        }
    }
    public class PostEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
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
        private EmployeeOCommodity? _postEmployeeOCommodity = new();
        public EmployeeOCommodity? PostEmployeeOCommodity
        {
            get => _postEmployeeOCommodity;
            set
            {
                SetValue(ref _postEmployeeOCommodity, value);
            }
        }
        public PostEmployeeOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeOCommodity EmployeeOCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeOCommodity>(EmployeeOCommodity);
            if (PostValue != null)
            {
                PostEmployeeOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeOCommodity = new();
            _postEmployeeOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
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
        private EmployeeOCommodity? _putEmployeeOCommodity = new();
        public EmployeeOCommodity? PutEmployeeOCommodity
        {
            get => _putEmployeeOCommodity;
            set
            {
                SetValue(ref _putEmployeeOCommodity, value);
            }
        }
        public PutEmployeeOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeOCommodity EmployeeOCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeOCommodity>(EmployeeOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeOCommodity = new();
            _putEmployeeOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
    {
        public DeleteEmployeeOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeOCommodity>(id);
        }
        public void Reset()
        {
            EmployeeOCommodity = new();
        }
    }
    public class GetsEmployeeOCommodityViewModel : BaseEmployeeOCommodityViewModel
    {
        private List<EmployeeOCommodity> _EmployeeOCommoditys = new();
        public List<EmployeeOCommodity> EmployeeOCommoditys
        {
            get=> _EmployeeOCommoditys;
            set
            {
                SetValue(ref _EmployeeOCommoditys, value);   
            }
        }
        public GetsEmployeeOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeOCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeOCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
