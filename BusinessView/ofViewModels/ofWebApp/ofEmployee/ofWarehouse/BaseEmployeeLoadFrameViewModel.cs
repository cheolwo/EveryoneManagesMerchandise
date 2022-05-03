using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployeeLoadFrameViewModel : BaseViewModel
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        protected EmployeeLoadFrame? _EmployeeLoadFrame = new();
        public EmployeeLoadFrame? EmployeeLoadFrame
        {
            get => _EmployeeLoadFrame;
            set
            {
                SetValue(ref _EmployeeLoadFrame, value);
            }
        }
        public BaseEmployeeLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployeeLoadFrame = await _EmployeeActorContext.GetByIdAsync<EmployeeLoadFrame>(id);
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
        public PostEmployeeLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
        public async Task PostAsync(EmployeeLoadFrame EmployeeLoadFrame)
        {
            var PostValue = await _EmployeeActorContext.PostAsync<EmployeeLoadFrame>(EmployeeLoadFrame);
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
        public PutEmployeeLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task PutAsync(EmployeeLoadFrame EmployeeLoadFrame)
        {
            var PutValue = await _EmployeeActorContext.PutAsync<EmployeeLoadFrame>(EmployeeLoadFrame);
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
        public DeleteEmployeeLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployeeActorContext.DeleteByIdAsync<EmployeeLoadFrame>(id);
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
        public GetsEmployeeLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployeeLoadFrame>? dtos = await _EmployeeActorContext.GetsAsync<EmployeeLoadFrame>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployeeLoadFrame>? dtos = await _EmployeeActorContext.GetsAsyncByUserId<EmployeeLoadFrame>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployeeLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployeeLoadFrames.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployeeLoadFrames.Remove(obj); OnPropertyChanged(); }
        }
    }
}
