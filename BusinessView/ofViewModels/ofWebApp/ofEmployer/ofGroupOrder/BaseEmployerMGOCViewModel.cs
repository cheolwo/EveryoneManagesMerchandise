using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerMGOCViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMGOC? _EmployerMGOC = new();
        public EmployerMGOC? EmployerMGOC
        {
            get => _EmployerMGOC;
            set
            {
                SetValue(ref _EmployerMGOC, value);
            }
        }
        public BaseEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMGOC = await _EmployerActorContext.GetByIdAsync<EmployerMGOC>(id);
        }
    }
    public class PostEmployerMGOCViewModel : BaseEmployerMGOCViewModel
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
        private EmployerMGOC? _postEmployerMGOC = new();
        public EmployerMGOC? PostEmployerMGOC
        {
            get => _postEmployerMGOC;
            set
            {
                SetValue(ref _postEmployerMGOC, value);
            }
        }
        public PostEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMGOC EmployerMGOC)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMGOC>(EmployerMGOC);
            if (PostValue != null)
            {
                PostEmployerMGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMGOC = new();
            _postEmployerMGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMGOCViewModel : BaseEmployerMGOCViewModel
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
        private EmployerMGOC? _putEmployerMGOC = new();
        public EmployerMGOC? PutEmployerMGOC
        {
            get => _putEmployerMGOC;
            set
            {
                SetValue(ref _putEmployerMGOC, value);
            }
        }
        public PutEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMGOC EmployerMGOC)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMGOC>(EmployerMGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMGOC = new();
            _putEmployerMGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMGOCViewModel : BaseEmployerMGOCViewModel
    {
        public DeleteEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMGOC>(id);
        }
        public void Reset()
        {
            EmployerMGOC = new();
        }
    }
    public class GetsEmployerMGOCViewModel : BaseEmployerMGOCViewModel
    {
        private List<EmployerMGOC> _EmployerMGOCs = new();
        public List<EmployerMGOC> EmployerMGOCs
        {
            get=> _EmployerMGOCs;
            set
            {
                SetValue(ref _EmployerMGOCs, value);   
            }
        }
        public GetsEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMGOC>? dtos = await _EmployerActorContext.GetsAsync<EmployerMGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMGOC>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
