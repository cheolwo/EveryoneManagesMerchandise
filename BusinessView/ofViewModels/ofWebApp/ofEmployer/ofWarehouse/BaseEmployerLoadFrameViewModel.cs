using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerLoadFrameViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerLoadFrame> _actorViewService;
        protected EmployerLoadFrame? _EmployerLoadFrame = new();
        public EmployerLoadFrame? EmployerLoadFrame
        {
            get => _EmployerLoadFrame;
            set
            {
                SetValue(ref _EmployerLoadFrame, value);
            }
        }
        public BaseEmployerLoadFrameViewModel(IActorViewService<EmployerLoadFrame> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployerLoadFrame = await _actorViewService.GetByIdAsync(id);
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
        public PostEmployerLoadFrameViewModel(IActorViewService<EmployerLoadFrame> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployerLoadFrame EmployerLoadFrame)
        {
            var PostValue = await _actorViewService.PostAsync(EmployerLoadFrame);
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
        public PutEmployerLoadFrameViewModel(IActorViewService<EmployerLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployerLoadFrame EmployerLoadFrame)
        {
            var PutValue = await _actorViewService.PutAsync(EmployerLoadFrame);
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
        public DeleteEmployerLoadFrameViewModel(IActorViewService<EmployerLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
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
        public GetsEmployerLoadFrameViewModel(IActorViewService<EmployerLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerLoadFrame>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployerLoadFrames.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerLoadFrames.Remove(obj); OnPropertyChanged(); }
        }
    }
}
