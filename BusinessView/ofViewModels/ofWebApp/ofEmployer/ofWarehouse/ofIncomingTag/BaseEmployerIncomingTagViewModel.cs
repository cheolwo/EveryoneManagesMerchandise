using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerIncomingTagViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerIncomingTag? _EmployerIncomingTag = new();
        public EmployerIncomingTag? EmployerIncomingTag
        {
            get => _EmployerIncomingTag;
            set
            {
                SetValue(ref _EmployerIncomingTag, value);
            }
        }
        public BaseEmployerIncomingTagViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerIncomingTag = await _EmployerActorContext.GetByIdAsync<EmployerIncomingTag>(id);
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
        public PostEmployerIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerIncomingTag EmployerIncomingTag)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerIncomingTag>(EmployerIncomingTag);
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
        public PutEmployerIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerIncomingTag EmployerIncomingTag)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerIncomingTag>(EmployerIncomingTag);
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
        public DeleteEmployerIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerIncomingTag>(id);
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
        public GetsEmployerIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerIncomingTag>? dtos = await _EmployerActorContext.GetsAsync<EmployerIncomingTag>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerIncomingTag>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerIncomingTag>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerIncomingTags.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerIncomingTags.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerIncomingTags.Remove(obj); OnPropertyChanged(); }
        }
    }
}
