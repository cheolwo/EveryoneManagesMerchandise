using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeGOCCViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeGOCC? _EmployeeGOCC = new();
        public EmployeeGOCC? EmployeeGOCC
        {
            get => _EmployeeGOCC;
            set
            {
                SetValue(ref _EmployeeGOCC, value);
            }
        }
        public BaseEmployeeGOCCViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeGOCC = await _EmployeeActorContext.GetByIdAsync<EmployeeGOCC>(id);
        }
    }
    public class PostEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
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
        private EmployeeGOCC? _postEmployeeGOCC = new();
        public EmployeeGOCC? PostEmployeeGOCC
        {
            get => _postEmployeeGOCC;
            set
            {
                SetValue(ref _postEmployeeGOCC, value);
            }
        }
        public PostEmployeeGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeGOCC EmployeeGOCC)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeGOCC);
            if (PostValue != null)
            {
                PostEmployeeGOCC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeGOCC = new();
            _postEmployeeGOCC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
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
        private EmployeeGOCC? _putEmployeeGOCC = new();
        public EmployeeGOCC? PutEmployeeGOCC
        {
            get => _putEmployeeGOCC;
            set
            {
                SetValue(ref _putEmployeeGOCC, value);
            }
        }
        public PutEmployeeGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeGOCC EmployeeGOCC)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeGOCC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeGOCC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeGOCC = new();
            _putEmployeeGOCC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
    {
        public DeleteEmployeeGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeGOCC>(id);
        }
        public void Reset()
        {
            EmployeeGOCC = new();
        }
    }
    public class GetsEmployeeGOCCViewModel : BaseEmployeeGOCCViewModel
    {
        private List<EmployeeGOCC> _EmployeeGOCCs = new();
        public List<EmployeeGOCC> EmployeeGOCCs
        {
            get=> _EmployeeGOCCs;
            set
            {
                SetValue(ref _EmployeeGOCCs, value);   
            }
        }
        public GetsEmployeeGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeGOCC>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeGOCC>();
            if(dtos != null)
            {
                if(_EmployeeGOCCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeGOCC>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeGOCC>(userid);
            if(dtos != null)
            {
                if(_EmployeeGOCCs.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeGOCCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeGOCCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
