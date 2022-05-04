using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeIncomingTagViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeIncomingTag? _EmployeeIncomingTag = new();
        public EmployeeIncomingTag? EmployeeIncomingTag
        {
            get => _EmployeeIncomingTag;
            set
            {
                SetValue(ref _EmployeeIncomingTag, value);
            }
        }
        public BaseEmployeeIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeIncomingTag = await _EmployeeActorContext.GetByIdAsync<EmployeeIncomingTag>(id);
        }
    }
    public class PostEmployeeIncomingTagViewModel : BaseEmployeeIncomingTagViewModel
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
        private EmployeeIncomingTag? _postEmployeeIncomingTag = new();
        public EmployeeIncomingTag? PostEmployeeIncomingTag
        {
            get => _postEmployeeIncomingTag;
            set
            {
                SetValue(ref _postEmployeeIncomingTag, value);
            }
        }
        public PostEmployeeIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeIncomingTag EmployeeIncomingTag)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeIncomingTag>(EmployeeIncomingTag);
            if (PostValue != null)
            {
                PostEmployeeIncomingTag = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeIncomingTag = new();
            _postEmployeeIncomingTag = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeIncomingTagViewModel : BaseEmployeeIncomingTagViewModel
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
        private EmployeeIncomingTag? _putEmployeeIncomingTag = new();
        public EmployeeIncomingTag? PutEmployeeIncomingTag
        {
            get => _putEmployeeIncomingTag;
            set
            {
                SetValue(ref _putEmployeeIncomingTag, value);
            }
        }
        public PutEmployeeIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeIncomingTag EmployeeIncomingTag)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeIncomingTag>(EmployeeIncomingTag);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeIncomingTag = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeIncomingTag = new();
            _putEmployeeIncomingTag = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeIncomingTagViewModel : BaseEmployeeIncomingTagViewModel
    {
        public DeleteEmployeeIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeIncomingTag>(id);
        }
        public void Reset()
        {
            EmployeeIncomingTag = new();
        }
    }
    public class GetsEmployeeIncomingTagViewModel : BaseEmployeeIncomingTagViewModel
    {
        private List<EmployeeIncomingTag> _EmployeeIncomingTags = new();
        public List<EmployeeIncomingTag> EmployeeIncomingTags
        {
            get=> _EmployeeIncomingTags;
            set
            {
                SetValue(ref _EmployeeIncomingTags, value);   
            }
        }
        public GetsEmployeeIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeIncomingTag>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeIncomingTag>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeIncomingTag>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeIncomingTag>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeIncomingTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeIncomingTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
