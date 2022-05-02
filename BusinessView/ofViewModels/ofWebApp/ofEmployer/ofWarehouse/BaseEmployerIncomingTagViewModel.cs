using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerIncomingTagViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerIncomingTag> _actorViewService;
        protected EmployerIncomingTag? _EmployerIncomingTag = new();
        public EmployerIncomingTag? EmployerIncomingTag
        {
            get => _EmployerIncomingTag;
            set
            {
                SetValue(ref _EmployerIncomingTag, value);
            }
        }
        public BaseEmployerIncomingTagViewModel(IActorViewService<EmployerIncomingTag> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerIncomingTag = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployerIncomingTagViewModel : BaseEmployerIncomingTagViewModel
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
        private EmployerIncomingTag? _postEmployerIncomingTag = new();
        public EmployerIncomingTag? PostEmployerIncomingTag
        {
            get => _postEmployerIncomingTag;
            set
            {
                SetValue(ref _postEmployerIncomingTag, value);
            }
        }
        public PostEmployerIncomingTagViewModel(IActorViewService<EmployerIncomingTag> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerIncomingTag EmployerIncomingTag)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerIncomingTag);
            if (PostValue != null)
            {
                PostEmployerIncomingTag = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerIncomingTag = new();
            _postEmployerIncomingTag = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerIncomingTagViewModel : BaseEmployerIncomingTagViewModel
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
        private EmployerIncomingTag? _putEmployerIncomingTag = new();
        public EmployerIncomingTag? PutEmployerIncomingTag
        {
            get => _putEmployerIncomingTag;
            set
            {
                SetValue(ref _putEmployerIncomingTag, value);
            }
        }
        public PutEmployerIncomingTagViewModel(IActorViewService<EmployerIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerIncomingTag EmployerIncomingTag)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerIncomingTag);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerIncomingTag = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerIncomingTag = new();
            _putEmployerIncomingTag = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerIncomingTagViewModel : BaseEmployerIncomingTagViewModel
    {
        public DeleteEmployerIncomingTagViewModel(IActorViewService<EmployerIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployerIncomingTag = new();
        }
    }
    public class GetsEmployerIncomingTagViewModel : BaseEmployerIncomingTagViewModel
    {
        private List<EmployerIncomingTag> _EmployerIncomingTags = new();
        public List<EmployerIncomingTag> EmployerIncomingTags
        {
            get=> _EmployerIncomingTags;
            set
            {
                SetValue(ref _EmployerIncomingTags, value);   
            }
        }
        public GetsEmployerIncomingTagViewModel(IActorViewService<EmployerIncomingTag> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerIncomingTag>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerIncomingTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerIncomingTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
