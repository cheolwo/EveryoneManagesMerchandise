using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformLoadFrameViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformLoadFrame? _PlatformLoadFrame = new();
        public PlatformLoadFrame? PlatformLoadFrame
        {
            get => _PlatformLoadFrame;
            set
            {
                SetValue(ref _PlatformLoadFrame, value);
            }
        }
        public BasePlatformLoadFrameViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformLoadFrame = await _PlatformActorContext.GetByIdAsync<PlatformLoadFrame>(id);
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
        public PostPlatformLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformLoadFrame PlatformLoadFrame)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformLoadFrame>(PlatformLoadFrame);
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
        public PutPlatformLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformLoadFrame PlatformLoadFrame)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformLoadFrame>(PlatformLoadFrame);
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
        public DeletePlatformLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformLoadFrame>(id);
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
        public GetsPlatformLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformLoadFrame>? dtos = await _PlatformActorContext.GetsAsync<PlatformLoadFrame>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformLoadFrame>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformLoadFrame>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformLoadFrames.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformLoadFrames.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformLoadFrames.Remove(obj); OnPropertyChanged(); }
        }
    }
}
