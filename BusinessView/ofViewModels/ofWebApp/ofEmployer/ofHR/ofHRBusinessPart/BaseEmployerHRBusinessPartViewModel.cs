using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRBusinessPartViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerHRBusinessPart? _EmployerHRBusinessPart = new();
        public EmployerHRBusinessPart? EmployerHRBusinessPart
        {
            get => _EmployerHRBusinessPart;
            set
            {
                SetValue(ref _EmployerHRBusinessPart, value);
            }
        }
        public BaseEmployerHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHRBusinessPart = await _EmployerActorContext.GetByIdAsync<EmployerHRBusinessPart>(id);
        }
    }
    public class PostEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
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
        private EmployerHRBusinessPart? _postEmployerHRBusinessPart = new();
        public EmployerHRBusinessPart? PostEmployerHRBusinessPart
        {
            get => _postEmployerHRBusinessPart;
            set
            {
                SetValue(ref _postEmployerHRBusinessPart, value);
            }
        }
        public PostEmployerHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerHRBusinessPart EmployerHRBusinessPart)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerHRBusinessPart>(EmployerHRBusinessPart);
            if (PostValue != null)
            {
                PostEmployerHRBusinessPart = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerHRBusinessPart = new();
            _postEmployerHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
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
        private EmployerHRBusinessPart? _putEmployerHRBusinessPart = new();
        public EmployerHRBusinessPart? PutEmployerHRBusinessPart
        {
            get => _putEmployerHRBusinessPart;
            set
            {
                SetValue(ref _putEmployerHRBusinessPart, value);
            }
        }
        public PutEmployerHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerHRBusinessPart EmployerHRBusinessPart)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerHRBusinessPart>(EmployerHRBusinessPart);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerHRBusinessPart = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerHRBusinessPart = new();
            _putEmployerHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
    {
        public DeleteEmployerHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerHRBusinessPart>(id);
        }
        public void Reset()
        {
            EmployerHRBusinessPart = new();
        }
    }
    public class GetsEmployerHRBusinessPartViewModel : BaseEmployerHRBusinessPartViewModel
    {
        private List<EmployerHRBusinessPart> _EmployerHRBusinessParts = new();
        public List<EmployerHRBusinessPart> EmployerHRBusinessParts
        {
            get=> _EmployerHRBusinessParts;
            set
            {
                SetValue(ref _EmployerHRBusinessParts, value);   
            }
        }
        public GetsEmployerHRBusinessPartViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHRBusinessPart>? dtos = await _EmployerActorContext.GetsAsync<EmployerHRBusinessPart>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerHRBusinessPart>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerHRBusinessPart>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerHRBusinessParts.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHRBusinessParts.Remove(obj); OnPropertyChanged(); }
        }
    }
}
