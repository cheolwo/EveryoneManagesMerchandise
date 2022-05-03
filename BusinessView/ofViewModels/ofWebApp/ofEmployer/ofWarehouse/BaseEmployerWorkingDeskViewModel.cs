using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWorkingDeskViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerWorkingDesk? _EmployerWorkingDesk = new();
        public EmployerWorkingDesk? EmployerWorkingDesk
        {
            get => _EmployerWorkingDesk;
            set
            {
                SetValue(ref _EmployerWorkingDesk, value);
            }
        }
        public BaseEmployerWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerWorkingDesk = await _EmployerActorContext.GetByIdAsync<EmployerWorkingDesk>(id);
        }
    }
    public class PostEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
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
        private EmployerWorkingDesk? _postEmployerWorkingDesk = new();
        public EmployerWorkingDesk? PostEmployerWorkingDesk
        {
            get => _postEmployerWorkingDesk;
            set
            {
                SetValue(ref _postEmployerWorkingDesk, value);
            }
        }
        public PostEmployerWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerWorkingDesk EmployerWorkingDesk)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerWorkingDesk>(EmployerWorkingDesk);
            if (PostValue != null)
            {
                PostEmployerWorkingDesk = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerWorkingDesk = new();
            _postEmployerWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
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
        private EmployerWorkingDesk? _putEmployerWorkingDesk = new();
        public EmployerWorkingDesk? PutEmployerWorkingDesk
        {
            get => _putEmployerWorkingDesk;
            set
            {
                SetValue(ref _putEmployerWorkingDesk, value);
            }
        }
        public PutEmployerWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerWorkingDesk EmployerWorkingDesk)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerWorkingDesk>(EmployerWorkingDesk);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerWorkingDesk = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerWorkingDesk = new();
            _putEmployerWorkingDesk = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
    {
        public DeleteEmployerWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerWorkingDesk>(id);
        }
        public void Reset()
        {
            EmployerWorkingDesk = new();
        }
    }
    public class GetsEmployerWorkingDeskViewModel : BaseEmployerWorkingDeskViewModel
    {
        private List<EmployerWorkingDesk> _EmployerWorkingDesks = new();
        public List<EmployerWorkingDesk> EmployerWorkingDesks
        {
            get=> _EmployerWorkingDesks;
            set
            {
                SetValue(ref _EmployerWorkingDesks, value);   
            }
        }
        public GetsEmployerWorkingDeskViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerWorkingDesk>? dtos = await _EmployerActorContext.GetsAsync<EmployerWorkingDesk>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerWorkingDesk>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerWorkingDesk>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerWorkingDesks.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerWorkingDesks.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerWorkingDesks.Remove(obj); OnPropertyChanged(); }
        }
    }
}
