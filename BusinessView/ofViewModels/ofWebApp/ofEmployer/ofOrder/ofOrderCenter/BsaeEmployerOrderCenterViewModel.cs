using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerOrderCenterViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerOrderCenter? _EmployerOrderCenter = new();
        public EmployerOrderCenter? EmployerOrderCenter
        {
            get => _EmployerOrderCenter;
            set
            {
                SetValue(ref _EmployerOrderCenter, value);
            }
        }
        public BaseEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerOrderCenter = await _EmployerActorContext.GetByIdAsync<EmployerOrderCenter>(id);
        }
    }
    public class PostEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
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
        private EmployerOrderCenter? _postEmployerOrderCenter = new();
        public EmployerOrderCenter? PostEmployerOrderCenter
        {
            get => _postEmployerOrderCenter;
            set
            {
                SetValue(ref _postEmployerOrderCenter, value);
            }
        }
        public PostEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerOrderCenter EmployerOrderCenter)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerOrderCenter>(EmployerOrderCenter);
            if (PostValue != null)
            {
                PostEmployerOrderCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerOrderCenter = new();
            _postEmployerOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
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
        private EmployerOrderCenter? _putEmployerOrderCenter = new();
        public EmployerOrderCenter? PutEmployerOrderCenter
        {
            get => _putEmployerOrderCenter;
            set
            {
                SetValue(ref _putEmployerOrderCenter, value);
            }
        }
        public PutEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerOrderCenter EmployerOrderCenter)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerOrderCenter>(EmployerOrderCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerOrderCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerOrderCenter = new();
            _putEmployerOrderCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
    {
        public DeleteEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerOrderCenter>(id);
        }
        public void Reset()
        {
            EmployerOrderCenter = new();
        }
    }
    public class GetsEmployerOrderCenterViewModel : BaseEmployerOrderCenterViewModel
    {
        private List<EmployerOrderCenter> _EmployerOrderCenters = new();
        public List<EmployerOrderCenter> EmployerOrderCenters
        {
            get=> _EmployerOrderCenters;
            set
            {
                SetValue(ref _EmployerOrderCenters, value);   
            }
        }
        public GetsEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerOrderCenter>? dtos = await _EmployerActorContext.GetsAsync<EmployerOrderCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerOrderCenter>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerOrderCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerOrderCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerOrderCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerOrderCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
