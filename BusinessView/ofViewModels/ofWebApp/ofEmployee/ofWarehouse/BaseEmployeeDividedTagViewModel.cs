using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeDividedTagViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeDividedTag> _actorViewService;
        protected EmployeeDividedTag? _EmployeeDividedTag = new();
        public EmployeeDividedTag? EmployeeDividedTag
        {
            get => _EmployeeDividedTag;
            set
            {
                SetValue(ref _EmployeeDividedTag, value);
            }
        }
        public BaseEmployeeDividedTagViewModel(IActorViewService<EmployeeDividedTag> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeDividedTag = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployeeDividedTagViewModel(IActorViewService<EmployeeDividedTag> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeDividedTag EmployeeDividedTag)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeDividedTag);
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
        public PutEmployeeDividedTagViewModel(IActorViewService<EmployeeDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeDividedTag EmployeeDividedTag)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeDividedTag);
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
        public DeleteEmployeeDividedTagViewModel(IActorViewService<EmployeeDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployeeDividedTagViewModel(IActorViewService<EmployeeDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeDividedTag>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeDividedTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeDividedTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
