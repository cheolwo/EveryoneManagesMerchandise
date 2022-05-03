using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeSGOCViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeSGOC? _EmployeeSGOC = new();
        public EmployeeSGOC? EmployeeSGOC
        {
            get => _EmployeeSGOC;
            set
            {
                SetValue(ref _EmployeeSGOC, value);
            }
        }
        public BaseEmployeeSGOCViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeSGOC = await _EmployeeActorContext.GetByIdAsync<EmployeeSGOC>(id);
        }
    }
    public class PostEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
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
        private EmployeeSGOC? _postEmployeeSGOC = new();
        public EmployeeSGOC? PostEmployeeSGOC
        {
            get => _postEmployeeSGOC;
            set
            {
                SetValue(ref _postEmployeeSGOC, value);
            }
        }
        public PostEmployeeSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeSGOC EmployeeSGOC)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeSGOC);
            if (PostValue != null)
            {
                PostEmployeeSGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeSGOC = new();
            _postEmployeeSGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
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
        private EmployeeSGOC? _putEmployeeSGOC = new();
        public EmployeeSGOC? PutEmployeeSGOC
        {
            get => _putEmployeeSGOC;
            set
            {
                SetValue(ref _putEmployeeSGOC, value);
            }
        }
        public PutEmployeeSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeSGOC EmployeeSGOC)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeSGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeSGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeSGOC = new();
            _putEmployeeSGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
    {
        public DeleteEmployeeSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeSGOC>(id);
        }
        public void Reset()
        {
            EmployeeSGOC = new();
        }
    }
    public class GetsEmployeeSGOCViewModel : BaseEmployeeSGOCViewModel
    {
        private List<EmployeeSGOC> _EmployeeSGOCs = new();
        public List<EmployeeSGOC> EmployeeSGOCs
        {
            get=> _EmployeeSGOCs;
            set
            {
                SetValue(ref _EmployeeSGOCs, value);   
            }
        }
        public GetsEmployeeSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeSGOC>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeSGOC>();
            if(dtos != null)
            {
                if(_EmployeeSGOCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeSGOC>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeSGOC>(userid);
            if(dtos != null)
            {
                if(_EmployeeSGOCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeSGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeSGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
