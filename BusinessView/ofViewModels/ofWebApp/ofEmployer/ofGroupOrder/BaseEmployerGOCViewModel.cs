using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerGOC? _EmployerGOC = new();
        public EmployerGOC? EmployerGOC
        {
            get => _EmployerGOC;
            set
            {
                SetValue(ref _EmployerGOC, value);
            }
        }
        public BaseEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerGOC = await _EmployerActorContext.GetByIdAsync<EmployerGOC>(id);
        }
    }
    public class PostEmployerGOCViewModel : BaseEmployerGOCViewModel
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
        private EmployerGOC? _postEmployerGOC = new();
        public EmployerGOC? PostEmployerGOC
        {
            get => _postEmployerGOC;
            set
            {
                SetValue(ref _postEmployerGOC, value);
            }
        }
        public PostEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerGOC EmployerGOC)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerGOC>(EmployerGOC);
            if (PostValue != null)
            {
                PostEmployerGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerGOC = new();
            _postEmployerGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerGOCViewModel : BaseEmployerGOCViewModel
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
        private EmployerGOC? _putEmployerGOC = new();
        public EmployerGOC? PutEmployerGOC
        {
            get => _putEmployerGOC;
            set
            {
                SetValue(ref _putEmployerGOC, value);
            }
        }
        public PutEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerGOC EmployerGOC)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerGOC>(EmployerGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerGOC = new();
            _putEmployerGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerGOCViewModel : BaseEmployerGOCViewModel
    {
        public DeleteEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerGOC>(id);
        }
        public void Reset()
        {
            EmployerGOC = new();
        }
    }
    public class GetsEmployerGOCViewModel : BaseEmployerGOCViewModel
    {
        private List<EmployerGOC> _EmployerGOCs = new();
        public List<EmployerGOC> EmployerGOCs
        {
            get=> _EmployerGOCs;
            set
            {
                SetValue(ref _EmployerGOCs, value);   
            }
        }
        public GetsEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerGOC>? dtos = await _EmployerActorContext.GetsAsync<EmployerGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerGOC>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
