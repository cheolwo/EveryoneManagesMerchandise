using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeLoadFrameViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployeeLoadFrame> _actorViewService;
        protected EmployeeLoadFrame? _EmployeeLoadFrame = new();
        public EmployeeLoadFrame? EmployeeLoadFrame
        {
            get => _EmployeeLoadFrame;
            set
            {
                SetValue(ref _EmployeeLoadFrame, value);
            }
        }
        public BaseEmployeeLoadFrameViewModel(IActorViewService<EmployeeLoadFrame> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _EmployeeLoadFrame = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostEmployeeLoadFrameViewModel : BaseEmployeeLoadFrameViewModel
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
        private EmployeeLoadFrame? _postEmployeeLoadFrame = new();
        public EmployeeLoadFrame? PostEmployeeLoadFrame
        {
            get => _postEmployeeLoadFrame;
            set
            {
                SetValue(ref _postEmployeeLoadFrame, value);
            }
        }
        public PostEmployeeLoadFrameViewModel(IActorViewService<EmployeeLoadFrame> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(EmployeeLoadFrame EmployeeLoadFrame)
        {
            var PostValue = await _actorViewService.PostAsync(EmployeeLoadFrame);
            if (PostValue != null)
            {
                PostEmployeeLoadFrame = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployeeLoadFrame = new();
            _postEmployeeLoadFrame = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployeeLoadFrameViewModel : BaseEmployeeLoadFrameViewModel
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
        private EmployeeLoadFrame? _putEmployeeLoadFrame = new();
        public EmployeeLoadFrame? PutEmployeeLoadFrame
        {
            get => _putEmployeeLoadFrame;
            set
            {
                SetValue(ref _putEmployeeLoadFrame, value);
            }
        }
        public PutEmployeeLoadFrameViewModel(IActorViewService<EmployeeLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(EmployeeLoadFrame EmployeeLoadFrame)
        {
            var PutValue = await _actorViewService.PutAsync(EmployeeLoadFrame);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployeeLoadFrame = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployeeLoadFrame = new();
            _putEmployeeLoadFrame = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployeeLoadFrameViewModel : BaseEmployeeLoadFrameViewModel
    {
        public DeleteEmployeeLoadFrameViewModel(IActorViewService<EmployeeLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            EmployeeLoadFrame = new();
        }
    }
    public class GetsEmployeeLoadFrameViewModel : BaseEmployeeLoadFrameViewModel
    {
        private List<EmployeeLoadFrame> _EmployeeLoadFrames = new();
        public List<EmployeeLoadFrame> EmployeeLoadFrames
        {
            get=> _EmployeeLoadFrames;
            set
            {
                SetValue(ref _EmployeeLoadFrames, value);   
            }
        }
        public GetsEmployeeLoadFrameViewModel(IActorViewService<EmployeeLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeLoadFrame>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = EmployeeLoadFrames.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeLoadFrames.Remove(obj); OnPropertyChanged(); }
        }
    }
}
