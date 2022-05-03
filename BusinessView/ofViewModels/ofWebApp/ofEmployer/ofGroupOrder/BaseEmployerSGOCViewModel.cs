using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerSGOCViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerSGOC? _EmployerSGOC = new();
        public EmployerSGOC? EmployerSGOC
        {
            get => _EmployerSGOC;
            set
            {
                SetValue(ref _EmployerSGOC, value);
            }
        }
        public BaseEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerSGOC = await _EmployerActorContext.GetByIdAsync<EmployerSGOC>(id);
        }
    }
    public class PostEmployerSGOCViewModel : BaseEmployerSGOCViewModel
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
        private EmployerSGOC? _postEmployerSGOC = new();
        public EmployerSGOC? PostEmployerSGOC
        {
            get => _postEmployerSGOC;
            set
            {
                SetValue(ref _postEmployerSGOC, value);
            }
        }
        public PostEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerSGOC EmployerSGOC)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerSGOC>(EmployerSGOC);
            if (PostValue != null)
            {
                PostEmployerSGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSGOC = new();
            _postEmployerSGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSGOCViewModel : BaseEmployerSGOCViewModel
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
        private EmployerSGOC? _putEmployerSGOC = new();
        public EmployerSGOC? PutEmployerSGOC
        {
            get => _putEmployerSGOC;
            set
            {
                SetValue(ref _putEmployerSGOC, value);
            }
        }
        public PutEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerSGOC EmployerSGOC)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerSGOC>(EmployerSGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSGOC = new();
            _putEmployerSGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSGOCViewModel : BaseEmployerSGOCViewModel
    {
        public DeleteEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerSGOC>(id);
        }
        public void Reset()
        {
            EmployerSGOC = new();
        }
    }
    public class GetsEmployerSGOCViewModel : BaseEmployerSGOCViewModel
    {
        private List<EmployerSGOC> _EmployerSGOCs = new();
        public List<EmployerSGOC> EmployerSGOCs
        {
            get=> _EmployerSGOCs;
            set
            {
                SetValue(ref _EmployerSGOCs, value);   
            }
        }
        public GetsEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSGOC>? dtos = await _EmployerActorContext.GetsAsync<EmployerSGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerSGOC>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerSGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerSGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
