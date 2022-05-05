using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR
{
    public class BaseEmployeeHRCenterViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeHRCenter? _EmployeeHRCenter = new();
        public EmployeeHRCenter? EmployeeHRCenter
        {
            get => _EmployeeHRCenter;
            set
            {
                SetValue(ref _EmployeeHRCenter, value);
            }
        }
        public BaseEmployeeHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public virtual async Task GetByIdAsync(string id)
        {
            _EmployeeHRCenter = await _EmployeeActorContext.GetByIdAsync<EmployeeHRCenter>(id);
        }
    }
    public class PostEmployeeHRCenterViewModel : BaseEmployeeHRCenterViewModel
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
        private EmployeeHRCenter? _postEmployeeHRCenter = new();
        public EmployeeHRCenter? PostEmployeeHRCenter
        {
            get => _postEmployeeHRCenter;
            set
            {
                SetValue(ref _postEmployeeHRCenter, value);
            }
        }
        public PostEmployeeHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeHRCenter EmployeeHRCenter)
        {
            var PostValue = await _EmployeeActorContext.PostAsync(EmployeeHRCenter);
            if (PostValue != null)
            {
                PostEmployeeHRCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeHRCenter = new();
            _postEmployeeHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeHRCenterViewModel : BaseEmployeeHRCenterViewModel
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
        private EmployeeHRCenter? _putEmployeeHRCenter = new();
        public EmployeeHRCenter? PutEmployeeHRCenter
        {
            get => _putEmployeeHRCenter;
            set
            {
                SetValue(ref _putEmployeeHRCenter, value);
            }
        }
        public PutEmployeeHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeHRCenter EmployeeHRCenter)
        {
            var PutValue = await _EmployeeActorContext.PutAsync(EmployeeHRCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeHRCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeHRCenter = new();
            _putEmployeeHRCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeHRCenterViewModel : BaseEmployeeHRCenterViewModel
    {
        public DeleteEmployeeHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeHRCenter>(id);
        }
        public void Reset()
        {
            EmployeeHRCenter = new();
        }
    }
    public class GetsEmployeeHRCenterViewModel : BaseEmployeeHRCenterViewModel
    {
        private List<EmployeeHRCenter> _EmployeeHRCenters = new();
        public List<EmployeeHRCenter> EmployeeHRCenters
        {
            get=> _EmployeeHRCenters;
            set
            {
                SetValue(ref _EmployeeHRCenters, value);   
            }
        }
        public GetsEmployeeHRCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeHRCenter>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeHRCenter>();
            if(dtos != null)
            {
                if(_EmployeeHRCenters.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeHRCenter>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeHRCenter>(userid);
            if(dtos != null)
            {
                if(_EmployeeHRCenters.Count > 0) {return;}
                foreach(var dto in dtos)
                {
                    _EmployeeHRCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeHRCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeHRCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
