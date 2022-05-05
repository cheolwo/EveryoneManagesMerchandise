using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJournalViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformJournal? _PlatformJournal = new();
        public PlatformJournal? PlatformJournal
        {
            get => _PlatformJournal;
            set
            {
                SetValue(ref _PlatformJournal, value);
            }
        }
        public BasePlatformJournalViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformJournal = await _PlatformActorContext.GetByIdAsync<PlatformJournal>(id);
        }
    }
    public class PostPlatformJournalViewModel : BasePlatformJournalViewModel
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
        private PlatformJournal? _postPlatformJournal = new();
        public PlatformJournal? PostPlatformJournal
        {
            get => _postPlatformJournal;
            set
            {
                SetValue(ref _postPlatformJournal, value);
            }
        }
        public PostPlatformJournalViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformJournal PlatformJournal)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformJournal>(PlatformJournal);
            if (PostValue != null)
            {
                PostPlatformJournal = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformJournal = new();
            _postPlatformJournal = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformJournalViewModel : BasePlatformJournalViewModel
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
        private PlatformJournal? _putPlatformJournal = new();
        public PlatformJournal? PutPlatformJournal
        {
            get => _putPlatformJournal;
            set
            {
                SetValue(ref _putPlatformJournal, value);
            }
        }
        public PutPlatformJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformJournal PlatformJournal)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformJournal>(PlatformJournal);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformJournal = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformJournal = new();
            _putPlatformJournal = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformJournalViewModel : BasePlatformJournalViewModel
    {
        public DeletePlatformJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformJournal>(id);
        }
        public void Reset()
        {
            PlatformJournal = new();
        }
    }
    public class GetsPlatformJournalViewModel : BasePlatformJournalViewModel
    {
        private List<PlatformJournal> _PlatformJournals = new();
        public List<PlatformJournal> PlatformJournals
        {
            get=> _PlatformJournals;
            set
            {
                SetValue(ref _PlatformJournals, value);   
            }
        }
        public GetsPlatformJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformJournal>? dtos = await _PlatformActorContext.GetsAsync<PlatformJournal>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformJournal>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformJournal>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJournals.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformJournals.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformJournals.Remove(obj); OnPropertyChanged(); }
        }
    }
}
