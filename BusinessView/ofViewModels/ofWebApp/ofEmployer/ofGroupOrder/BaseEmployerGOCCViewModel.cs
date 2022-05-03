using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCCViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerGOCC? _EmployerGOCC = new();
        public EmployerGOCC? EmployerGOCC
        {
            get => _EmployerGOCC;
            set
            {
                SetValue(ref _EmployerGOCC, value);
            }
        }
        public BaseEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerGOCC = await _EmployerActorContext.GetByIdAsync<EmployerGOCC>(id);
        }
    }
    public class PostEmployerGOCCViewModel : BaseEmployerGOCCViewModel
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
        private EmployerGOCC? _postEmployerGOCC = new();
        public EmployerGOCC? PostEmployerGOCC
        {
            get => _postEmployerGOCC;
            set
            {
                SetValue(ref _postEmployerGOCC, value);
            }
        }
        public PostEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerGOCC EmployerGOCC)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerGOCC>(EmployerGOCC);
            if (PostValue != null)
            {
                PostEmployerGOCC = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerGOCC = new();
            _postEmployerGOCC = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerGOCCViewModel : BaseEmployerGOCCViewModel
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
        private EmployerGOCC? _putEmployerGOCC = new();
        public EmployerGOCC? PutEmployerGOCC
        {
            get => _putEmployerGOCC;
            set
            {
                SetValue(ref _putEmployerGOCC, value);
            }
        }
        public PutEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerGOCC EmployerGOCC)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerGOCC>(EmployerGOCC);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerGOCC = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerGOCC = new();
            _putEmployerGOCC = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerGOCCViewModel : BaseEmployerGOCCViewModel
    {
        public DeleteEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerGOCC>(id);
        }
        public void Reset()
        {
            EmployerGOCC = new();
        }
    }
    public class GetsEmployerGOCCViewModel : BaseEmployerGOCCViewModel
    {
        private List<EmployerGOCC> _EmployerGOCCs = new();
        public List<EmployerGOCC> EmployerGOCCs
        {
            get=> _EmployerGOCCs;
            set
            {
                SetValue(ref _EmployerGOCCs, value);   
            }
        }
        public GetsEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerGOCC>? dtos = await _EmployerActorContext.GetsAsync<EmployerGOCC>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerGOCC>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerGOCC>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerGOCCs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerGOCCs.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerGOCCs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
