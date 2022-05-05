using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeGOCViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeGOC? _EmployeeGOC = new();
        public EmployeeGOC? EmployeeGOC
        {
            get => _EmployeeGOC;
            set
            {
                SetValue(ref _EmployeeGOC, value);
            }
        }
        public BaseEmployeeGOCViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeGOC = await _EmployeeActorContext.GetByIdAsync<EmployeeGOC>(id);
        }
    }
    public class PostEmployeeGOCViewModel : BaseEmployeeGOCViewModel
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
        private EmployeeGOC? _postEmployeeGOC = new();
        public EmployeeGOC? PostEmployeeGOC
        {
            get => _postEmployeeGOC;
            set
            {
                SetValue(ref _postEmployeeGOC, value);
            }
        }
        public PostEmployeeGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeGOC EmployeeGOC)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeGOC);
            if (PostValue != null)
            {
                PostEmployeeGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeGOC = new();
            _postEmployeeGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeGOCViewModel : BaseEmployeeGOCViewModel
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
        private EmployeeGOC? _putEmployeeGOC = new();
        public EmployeeGOC? PutEmployeeGOC
        {
            get => _putEmployeeGOC;
            set
            {
                SetValue(ref _putEmployeeGOC, value);
            }
        }
        public PutEmployeeGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeGOC EmployeeGOC)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeGOC = new();
            _putEmployeeGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeGOCViewModel : BaseEmployeeGOCViewModel
    {
        public DeleteEmployeeGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeGOC>(id);
        }
        public void Reset()
        {
            EmployeeGOC = new();
        }
    }
    public class GetsEmployeeGOCViewModel : BaseEmployeeGOCViewModel
    {
        private List<EmployeeGOC> _EmployeeGOCs = new();
        public List<EmployeeGOC> EmployeeGOCs
        {
            get=> _EmployeeGOCs;
            set
            {
                SetValue(ref _EmployeeGOCs, value);   
            }
        }
        public GetsEmployeeGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeGOC>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeGOC>();
            if(dtos != null)
            {
                if(_EmployeeGOCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeGOC>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeGOC>(userid);
            if(dtos != null)
            {
                if(_EmployeeGOCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
