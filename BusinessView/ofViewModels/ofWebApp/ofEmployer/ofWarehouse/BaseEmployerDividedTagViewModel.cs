using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerDividedTagViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerDividedTag> _actorViewService;
        protected EmployerDividedTag? _EmployerDividedTag = new();
        public EmployerDividedTag? EmployerDividedTag
        {
            get => _EmployerDividedTag;
            set
            {
                SetValue(ref _EmployerDividedTag, value);
            }
        }
        public BaseEmployerDividedTagViewModel(IActorViewService<EmployerDividedTag> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerDividedTag = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerDividedTagViewModel : BaseEmployerDividedTagViewModel
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
        private EmployerDividedTag? _postEmployerDividedTag = new();
        public EmployerDividedTag? PostEmployerDividedTag
        {
            get => _postEmployerDividedTag;
            set
            {
                SetValue(ref _postEmployerDividedTag, value);
            }
        }
        public PostEmployerDividedTagViewModel(IActorViewService<EmployerDividedTag> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerDividedTag EmployerDividedTag)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerDividedTag);
            if (PostValue != null)
            {
                PostEmployerDividedTag = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerDividedTag = new();
            _postEmployerDividedTag = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerDividedTagViewModel : BaseEmployerDividedTagViewModel
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
        private EmployerDividedTag? _putEmployerDividedTag = new();
        public EmployerDividedTag? PutEmployerDividedTag
        {
            get => _putEmployerDividedTag;
            set
            {
                SetValue(ref _putEmployerDividedTag, value);
            }
        }
        public PutEmployerDividedTagViewModel(IActorViewService<EmployerDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerDividedTag EmployerDividedTag)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerDividedTag);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerDividedTag = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerDividedTag = new();
            _putEmployerDividedTag = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerDividedTagViewModel : BaseEmployerDividedTagViewModel
    {
        public DeleteEmployerDividedTagViewModel(IActorViewService<EmployerDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerDividedTag = new();
        }
    }
    public class GetsEmployerDividedTagViewModel : BaseEmployerDividedTagViewModel
    {
        private List<EmployerDividedTag> _EmployerDividedTags = new();
        public List<EmployerDividedTag> EmployerDividedTags
        {
            get=> _EmployerDividedTags;
            set
            {
                SetValue(ref _EmployerDividedTags, value);   
            }
        }
        public GetsEmployerDividedTagViewModel(IActorViewService<EmployerDividedTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerDividedTag>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerDividedTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerDividedTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerDividedTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
