using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR
{
    public class BaseEmployerHRCenterViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerHRCenter? _EmployerHRCenter = new();
        public EmployerHRCenter? EmployerHRCenter
        {
            get => _EmployerHRCenter;
            set
            {
                SetValue(ref _EmployerHRCenter, value);
            }
        }
        public BaseEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerHRCenter = await _EmployerActorContext.GetByIdAsync<EmployerHRCenter>(id);
        }
    }
    public class PostEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
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
        private EmployerHRCenter? _postEmployerHRCenter = new();
        public EmployerHRCenter? PostEmployerHRCenter
        {
            get => _postEmployerHRCenter;
            set
            {
                SetValue(ref _postEmployerHRCenter, value);
            }
        }
        public PostEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerHRCenter EmployerHRCenter)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerHRCenter>(EmployerHRCenter);
            if (PostValue != null)
            {
                PostEmployerHRCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerHRCenter = new();
            _postEmployerHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
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
        private EmployerHRCenter? _putEmployerHRCenter = new();
        public EmployerHRCenter? PutEmployerHRCenter
        {
            get => _putEmployerHRCenter;
            set
            {
                SetValue(ref _putEmployerHRCenter, value);
            }
        }
        public PutEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerHRCenter EmployerHRCenter)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerHRCenter>(EmployerHRCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerHRCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerHRCenter = new();
            _putEmployerHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
    {
        public DeleteEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerHRCenter>(id);
        }
        public void Reset()
        {
            EmployerHRCenter = new();
        }
    }
    public class GetsEmployerHRCenterViewModel : BaseEmployerHRCenterViewModel
    {
        private List<EmployerHRCenter> _EmployerHRCenters = new();
        public List<EmployerHRCenter> EmployerHRCenters
        {
            get=> _EmployerHRCenters;
            set
            {
                SetValue(ref _EmployerHRCenters, value);   
            }
        }
        public GetsEmployerHRCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerHRCenter>? dtos = await _EmployerActorContext.GetsAsync<EmployerHRCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerHRCenter>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerHRCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerHRCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerHRCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
