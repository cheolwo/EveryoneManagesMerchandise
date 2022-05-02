using BusinessView.ofGeneric;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformLoadFrameViewModel : BaseViewModel
    {
        protected readonly IActorViewService<PlatformLoadFrame> _actorViewService;
        protected PlatformLoadFrame? _PlatformLoadFrame = new();
        public PlatformLoadFrame? PlatformLoadFrame
        {
            get => _PlatformLoadFrame;
            set
            {
                SetValue(ref _PlatformLoadFrame, value);
            }
        }
        public BasePlatformLoadFrameViewModel(IActorViewService<PlatformLoadFrame> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            _PlatformLoadFrame = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostPlatformLoadFrameViewModel : BasePlatformLoadFrameViewModel
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
        private PlatformLoadFrame? _postPlatformLoadFrame = new();
        public PlatformLoadFrame? PostPlatformLoadFrame
        {
            get => _postPlatformLoadFrame;
            set
            {
                SetValue(ref _postPlatformLoadFrame, value);
            }
        }
        public PostPlatformLoadFrameViewModel(IActorViewService<PlatformLoadFrame> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(PlatformLoadFrame PlatformLoadFrame)
        {
            var PostValue = await _actorViewService.PostAsync(PlatformLoadFrame);
            if (PostValue != null)
            {
                PostPlatformLoadFrame = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformLoadFrame = new();
            _postPlatformLoadFrame = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformLoadFrameViewModel : BasePlatformLoadFrameViewModel
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
        private PlatformLoadFrame? _putPlatformLoadFrame = new();
        public PlatformLoadFrame? PutPlatformLoadFrame
        {
            get => _putPlatformLoadFrame;
            set
            {
                SetValue(ref _putPlatformLoadFrame, value);
            }
        }
        public PutPlatformLoadFrameViewModel(IActorViewService<PlatformLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(PlatformLoadFrame PlatformLoadFrame)
        {
            var PutValue = await _actorViewService.PutAsync(PlatformLoadFrame);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformLoadFrame = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformLoadFrame = new();
            _putPlatformLoadFrame = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformLoadFrameViewModel : BasePlatformLoadFrameViewModel
    {
        public DeletePlatformLoadFrameViewModel(IActorViewService<PlatformLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            PlatformLoadFrame = new();
        }
    }
    public class GetsPlatformLoadFrameViewModel : BasePlatformLoadFrameViewModel
    {
        private List<PlatformLoadFrame> _PlatformLoadFrames = new();
        public List<PlatformLoadFrame> PlatformLoadFrames
        {
            get=> _PlatformLoadFrames;
            set
            {
                SetValue(ref _PlatformLoadFrames, value);   
            }
        }
        public GetsPlatformLoadFrameViewModel(IActorViewService<PlatformLoadFrame> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformLoadFrame>? dtos = await _actorViewService.GetsAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = PlatformLoadFrames.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformLoadFrames.Remove(obj); OnPropertyChanged(); }
        }
    }
}
