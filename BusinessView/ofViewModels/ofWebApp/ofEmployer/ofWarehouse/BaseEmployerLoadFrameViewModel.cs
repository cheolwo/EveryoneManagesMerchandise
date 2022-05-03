using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerLoadFrameViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerLoadFrame? _EmployerLoadFrame = new();
        public EmployerLoadFrame? EmployerLoadFrame
        {
            get => _EmployerLoadFrame;
            set
            {
                SetValue(ref _EmployerLoadFrame, value);
            }
        }
        public BaseEmployerLoadFrameViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerLoadFrame = await _EmployerActorContext.GetByIdAsync<EmployerLoadFrame>(id);
        }
    }
    public class PostEmployerLoadFrameViewModel : BaseEmployerLoadFrameViewModel
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
        private EmployerLoadFrame? _postEmployerLoadFrame = new();
        public EmployerLoadFrame? PostEmployerLoadFrame
        {
            get => _postEmployerLoadFrame;
            set
            {
                SetValue(ref _postEmployerLoadFrame, value);
            }
        }
        public PostEmployerLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerLoadFrame EmployerLoadFrame)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerLoadFrame>(EmployerLoadFrame);
            if (PostValue != null)
            {
                PostEmployerLoadFrame = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerLoadFrame = new();
            _postEmployerLoadFrame = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerLoadFrameViewModel : BaseEmployerLoadFrameViewModel
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
        private EmployerLoadFrame? _putEmployerLoadFrame = new();
        public EmployerLoadFrame? PutEmployerLoadFrame
        {
            get => _putEmployerLoadFrame;
            set
            {
                SetValue(ref _putEmployerLoadFrame, value);
            }
        }
        public PutEmployerLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerLoadFrame EmployerLoadFrame)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerLoadFrame>(EmployerLoadFrame);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerLoadFrame = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerLoadFrame = new();
            _putEmployerLoadFrame = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerLoadFrameViewModel : BaseEmployerLoadFrameViewModel
    {
        public DeleteEmployerLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerLoadFrame>(id);
        }
        public void Reset()
        {
            EmployerLoadFrame = new();
        }
    }
    public class GetsEmployerLoadFrameViewModel : BaseEmployerLoadFrameViewModel
    {
        private List<EmployerLoadFrame> _EmployerLoadFrames = new();
        public List<EmployerLoadFrame> EmployerLoadFrames
        {
            get=> _EmployerLoadFrames;
            set
            {
                SetValue(ref _EmployerLoadFrames, value);   
            }
        }
        public GetsEmployerLoadFrameViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerLoadFrame>? dtos = await _EmployerActorContext.GetsAsync<EmployerLoadFrame>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerLoadFrame>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerLoadFrame>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerLoadFrames.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerLoadFrames.Remove(obj); OnPropertyChanged(); }
        }
    }
}
