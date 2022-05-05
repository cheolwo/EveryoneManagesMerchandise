using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHRBusinessPartViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeHRBusinessPart? _EmployeeHRBusinessPart = new();
        public EmployeeHRBusinessPart? EmployeeHRBusinessPart
        {
            get => _EmployeeHRBusinessPart;
            set
            {
                SetValue(ref _EmployeeHRBusinessPart, value);
            }
        }
        public BaseEmployeeHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeHRBusinessPart = await _EmployeeActorContext.GetByIdAsync<EmployeeHRBusinessPart>(id);
        }
    }
    public class PostEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
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
        private EmployeeHRBusinessPart? _postEmployeeHRBusinessPart = new();
        public EmployeeHRBusinessPart? PostEmployeeHRBusinessPart
        {
            get => _postEmployeeHRBusinessPart;
            set
            {
                SetValue(ref _postEmployeeHRBusinessPart, value);
            }
        }
        public PostEmployeeHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeHRBusinessPart EmployeeHRBusinessPart)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeHRBusinessPart);
            if (PostValue != null)
            {
                PostEmployeeHRBusinessPart = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeHRBusinessPart = new();
            _postEmployeeHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
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
        private EmployeeHRBusinessPart? _putEmployeeHRBusinessPart = new();
        public EmployeeHRBusinessPart? PutEmployeeHRBusinessPart
        {
            get => _putEmployeeHRBusinessPart;
            set
            {
                SetValue(ref _putEmployeeHRBusinessPart, value);
            }
        }
        public PutEmployeeHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeHRBusinessPart EmployeeHRBusinessPart)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeHRBusinessPart);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeHRBusinessPart = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeHRBusinessPart = new();
            _putEmployeeHRBusinessPart = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
    {
        public DeleteEmployeeHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeHRBusinessPart>(id);
        }
        public void Reset()
        {
            EmployeeHRBusinessPart = new();
        }
    }
    public class GetsEmployeeHRBusinessPartViewModel : BaseEmployeeHRBusinessPartViewModel
    {
        private List<EmployeeHRBusinessPart> _EmployeeHRBusinessParts = new();
        public List<EmployeeHRBusinessPart> EmployeeHRBusinessParts
        {
            get=> _EmployeeHRBusinessParts;
            set
            {
                SetValue(ref _EmployeeHRBusinessParts, value);   
            }
        }
        public GetsEmployeeHRBusinessPartViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHRBusinessPart>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeHRBusinessPart>();
            if(dtos != null)
            {
                if(_EmployeeHRBusinessParts.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeHRBusinessPart>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeHRBusinessPart>(userid);
            if(dtos != null)
            {
                if(_EmployeeHRBusinessParts.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeHRBusinessParts.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeHRBusinessParts.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeHRBusinessParts.Remove(obj); OnPropertyChanged(); }
        }
    }
}
