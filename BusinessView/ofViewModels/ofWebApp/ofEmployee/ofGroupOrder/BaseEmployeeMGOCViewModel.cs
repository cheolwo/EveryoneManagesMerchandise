using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMGOCViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeMGOC? _EmployeeMGOC = new();
        public EmployeeMGOC? EmployeeMGOC
        {
            get => _EmployeeMGOC;
            set
            {
                SetValue(ref _EmployeeMGOC, value);
            }
        }
        public BaseEmployeeMGOCViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeMGOC = await _EmployeeActorContext.GetByIdAsync<EmployeeMGOC>(id);
        }
    }
    public class PostEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
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
        private EmployeeMGOC? _postEmployeeMGOC = new();
        public EmployeeMGOC? PostEmployeeMGOC
        {
            get => _postEmployeeMGOC;
            set
            {
                SetValue(ref _postEmployeeMGOC, value);
            }
        }
        public PostEmployeeMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeMGOC EmployeeMGOC)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeMGOC);
            if (PostValue != null)
            {
                PostEmployeeMGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeMGOC = new();
            _postEmployeeMGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
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
        private EmployeeMGOC? _putEmployeeMGOC = new();
        public EmployeeMGOC? PutEmployeeMGOC
        {
            get => _putEmployeeMGOC;
            set
            {
                SetValue(ref _putEmployeeMGOC, value);
            }
        }
        public PutEmployeeMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeMGOC EmployeeMGOC)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeMGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeMGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeMGOC = new();
            _putEmployeeMGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
    {
        public DeleteEmployeeMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeMGOC>(id);
        }
        public void Reset()
        {
            EmployeeMGOC = new();
        }
    }
    public class GetsEmployeeMGOCViewModel : BaseEmployeeMGOCViewModel
    {
        private List<EmployeeMGOC> _EmployeeMGOCs = new();
        public List<EmployeeMGOC> EmployeeMGOCs
        {
            get=> _EmployeeMGOCs;
            set
            {
                SetValue(ref _EmployeeMGOCs, value);   
            }
        }
        public GetsEmployeeMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeMGOC>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeMGOC>();
            if(dtos != null)
            {
                if(_EmployeeMGOCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeMGOC>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeMGOC>(userid);
            if(dtos != null)
            {
                if(_EmployeeMGOCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeMGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeMGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
