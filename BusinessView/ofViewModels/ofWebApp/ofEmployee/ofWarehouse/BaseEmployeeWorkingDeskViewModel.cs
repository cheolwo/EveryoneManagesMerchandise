using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeWorkingDeskViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeWorkingDesk? _EmployeeWorkingDesk = new();
        public EmployeeWorkingDesk? EmployeeWorkingDesk
        {
            get => _EmployeeWorkingDesk;
            set
            {
                SetValue(ref _EmployeeWorkingDesk, value);
            }
        }
        public BaseEmployeeWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeWorkingDesk = await _EmployeeActorContext.GetByIdAsync<EmployeeWorkingDesk>(id);
        }
    }
    public class PostEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
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
        private EmployeeWorkingDesk? _postEmployeeWorkingDesk = new();
        public EmployeeWorkingDesk? PostEmployeeWorkingDesk
        {
            get => _postEmployeeWorkingDesk;
            set
            {
                SetValue(ref _postEmployeeWorkingDesk, value);
            }
        }
        public PostEmployeeWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeWorkingDesk EmployeeWorkingDesk)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeWorkingDesk>(EmployeeWorkingDesk);
            if (PostValue != null)
            {
                PostEmployeeWorkingDesk = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeWorkingDesk = new();
            _postEmployeeWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
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
        private EmployeeWorkingDesk? _putEmployeeWorkingDesk = new();
        public EmployeeWorkingDesk? PutEmployeeWorkingDesk
        {
            get => _putEmployeeWorkingDesk;
            set
            {
                SetValue(ref _putEmployeeWorkingDesk, value);
            }
        }
        public PutEmployeeWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeWorkingDesk EmployeeWorkingDesk)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeWorkingDesk>(EmployeeWorkingDesk);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeWorkingDesk = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeWorkingDesk = new();
            _putEmployeeWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
    {
        public DeleteEmployeeWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeWorkingDesk>(id);
        }
        public void Reset()
        {
            EmployeeWorkingDesk = new();
        }
    }
    public class GetsEmployeeWorkingDeskViewModel : BaseEmployeeWorkingDeskViewModel
    {
        private List<EmployeeWorkingDesk> _EmployeeWorkingDesks = new();
        public List<EmployeeWorkingDesk> EmployeeWorkingDesks
        {
            get=> _EmployeeWorkingDesks;
            set
            {
                SetValue(ref _EmployeeWorkingDesks, value);   
            }
        }
        public GetsEmployeeWorkingDeskViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeWorkingDesk>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeWorkingDesk>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeWorkingDesk>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeWorkingDesk>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeWorkingDesks.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeWorkingDesks.Remove(obj); OnPropertyChanged(); }
        }
    }
}
