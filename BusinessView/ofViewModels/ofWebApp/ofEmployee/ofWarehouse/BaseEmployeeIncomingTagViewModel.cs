using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeIncomingTagViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeIncomingTag> _actorViewService;
        protected EmployeeIncomingTag? _EmployeeIncomingTag = new();
        public EmployeeIncomingTag? EmployeeIncomingTag
        {
            get => _EmployeeIncomingTag;
            set
            {
                SetValue(ref _EmployeeIncomingTag, value);
            }
        }
        public BaseEmployeeIncomingTagViewModel(IActorViewService<EmployeeIncomingTag> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeIncomingTag = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployeeIncomingTagViewModel(IActorViewService<EmployeeIncomingTag> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeIncomingTag EmployeeIncomingTag)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeIncomingTag);
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
        public PutEmployeeIncomingTagViewModel(IActorViewService<EmployeeIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeIncomingTag EmployeeIncomingTag)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeIncomingTag);
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
        public DeleteEmployeeIncomingTagViewModel(IActorViewService<EmployeeIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployeeIncomingTagViewModel(IActorViewService<EmployeeIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeIncomingTag>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeIncomingTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeIncomingTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
