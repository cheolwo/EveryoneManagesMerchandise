using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerEGOCViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerEGOC? _EmployerEGOC = new();
        public EmployerEGOC? EmployerEGOC
        {
            get => _EmployerEGOC;
            set
            {
                SetValue(ref _EmployerEGOC, value);
            }
        }
        public BaseEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerEGOC = await _EmployerActorContext.GetByIdAsync<EmployerEGOC>(id);
        }
    }
    public class PostEmployerEGOCViewModel : BaseEmployerEGOCViewModel
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
        private EmployerEGOC? _postEmployerEGOC = new();
        public EmployerEGOC? PostEmployerEGOC
        {
            get => _postEmployerEGOC;
            set
            {
                SetValue(ref _postEmployerEGOC, value);
            }
        }
        public PostEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerEGOC EmployerEGOC)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerEGOC>(EmployerEGOC);
            if (PostValue != null)
            {
                PostEmployerEGOC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEGOC = new();
            _postEmployerEGOC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEGOCViewModel : BaseEmployerEGOCViewModel
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
        private EmployerEGOC? _putEmployerEGOC = new();
        public EmployerEGOC? PutEmployerEGOC
        {
            get => _putEmployerEGOC;
            set
            {
                SetValue(ref _putEmployerEGOC, value);
            }
        }
        public PutEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerEGOC EmployerEGOC)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerEGOC>(EmployerEGOC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEGOC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEGOC = new();
            _putEmployerEGOC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEGOCViewModel : BaseEmployerEGOCViewModel
    {
        public DeleteEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerEGOC>(id);
        }
        public void Reset()
        {
            EmployerEGOC = new();
        }
    }
    public class GetsEmployerEGOCViewModel : BaseEmployerEGOCViewModel
    {
        private List<EmployerEGOC> _EmployerEGOCs = new();
        public List<EmployerEGOC> EmployerEGOCs
        {
            get=> _EmployerEGOCs;
            set
            {
                SetValue(ref _EmployerEGOCs, value);   
            }
        }
        public GetsEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEGOC>? dtos = await _EmployerActorContext.GetsAsync<EmployerEGOC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerEGOC>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerEGOC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEGOCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerEGOCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEGOCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
