using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJCommodityViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeJCommodity? _EmployeeJCommodity = new();
        public EmployeeJCommodity? EmployeeJCommodity
        {
            get => _EmployeeJCommodity;
            set
            {
                SetValue(ref _EmployeeJCommodity, value);
            }
        }
        public BaseEmployeeJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeJCommodity = await _EmployeeActorContext.GetByIdAsync<EmployeeJCommodity>(id);
        }
    }
    public class PostEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
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
        private EmployeeJCommodity? _postEmployeeJCommodity = new();
        public EmployeeJCommodity? PostEmployeeJCommodity
        {
            get => _postEmployeeJCommodity;
            set
            {
                SetValue(ref _postEmployeeJCommodity, value);
            }
        }
        public PostEmployeeJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeJCommodity EmployeeJCommodity)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeJCommodity>(EmployeeJCommodity);
            if (PostValue != null)
            {
                PostEmployeeJCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeJCommodity = new();
            _postEmployeeJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
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
        private EmployeeJCommodity? _putEmployeeJCommodity = new();
        public EmployeeJCommodity? PutEmployeeJCommodity
        {
            get => _putEmployeeJCommodity;
            set
            {
                SetValue(ref _putEmployeeJCommodity, value);
            }
        }
        public PutEmployeeJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeJCommodity EmployeeJCommodity)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeJCommodity>(EmployeeJCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeJCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeJCommodity = new();
            _putEmployeeJCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
    {
        public DeleteEmployeeJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeJCommodity>(id);
        }
        public void Reset()
        {
            EmployeeJCommodity = new();
        }
    }
    public class GetsEmployeeJCommodityViewModel : BaseEmployeeJCommodityViewModel
    {
        private List<EmployeeJCommodity> _EmployeeJCommoditys = new();
        public List<EmployeeJCommodity> EmployeeJCommoditys
        {
            get=> _EmployeeJCommoditys;
            set
            {
                SetValue(ref _EmployeeJCommoditys, value);   
            }
        }
        public GetsEmployeeJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeJCommodity>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeJCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeJCommodity>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeJCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeJCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeJCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeJCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
