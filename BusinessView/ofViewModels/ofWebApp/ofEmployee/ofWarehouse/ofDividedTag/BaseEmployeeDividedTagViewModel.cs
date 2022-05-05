using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeDividedTagViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeDividedTag? _EmployeeDividedTag = new();
        public EmployeeDividedTag? EmployeeDividedTag
        {
            get => _EmployeeDividedTag;
            set
            {
                SetValue(ref _EmployeeDividedTag, value);
            }
        }
        public BaseEmployeeDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeDividedTag = await _EmployeeActorContext.GetByIdAsync<EmployeeDividedTag>(id);
        }
    }
    public class PostEmployeeDividedTagViewModel : BaseEmployeeDividedTagViewModel
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
        private EmployeeDividedTag? _postEmployeeDividedTag = new();
        public EmployeeDividedTag? PostEmployeeDividedTag
        {
            get => _postEmployeeDividedTag;
            set
            {
                SetValue(ref _postEmployeeDividedTag, value);
            }
        }
        public PostEmployeeDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeDividedTag EmployeeDividedTag)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeDividedTag>(EmployeeDividedTag);
            if (PostValue != null)
            {
                PostEmployeeDividedTag = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeDividedTag = new();
            _postEmployeeDividedTag = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeDividedTagViewModel : BaseEmployeeDividedTagViewModel
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
        private EmployeeDividedTag? _putEmployeeDividedTag = new();
        public EmployeeDividedTag? PutEmployeeDividedTag
        {
            get => _putEmployeeDividedTag;
            set
            {
                SetValue(ref _putEmployeeDividedTag, value);
            }
        }
        public PutEmployeeDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeDividedTag EmployeeDividedTag)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeDividedTag>(EmployeeDividedTag);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeDividedTag = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeDividedTag = new();
            _putEmployeeDividedTag = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeDividedTagViewModel : BaseEmployeeDividedTagViewModel
    {
        public DeleteEmployeeDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeDividedTag>(id);
        }
        public void Reset()
        {
            EmployeeDividedTag = new();
        }
    }
    public class GetsEmployeeDividedTagViewModel : BaseEmployeeDividedTagViewModel
    {
        private List<EmployeeDividedTag> _EmployeeDividedTags = new();
        public List<EmployeeDividedTag> EmployeeDividedTags
        {
            get=> _EmployeeDividedTags;
            set
            {
                SetValue(ref _EmployeeDividedTags, value);   
            }
        }
        public GetsEmployeeDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeDividedTag>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeDividedTag>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeDividedTag>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeDividedTag>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeDividedTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeDividedTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
