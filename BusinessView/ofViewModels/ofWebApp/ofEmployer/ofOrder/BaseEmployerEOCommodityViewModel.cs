using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerEOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerEOCommodity? _EmployerEOCommodity = new();
        public EmployerEOCommodity? EmployerEOCommodity
        {
            get => _EmployerEOCommodity;
            set
            {
                SetValue(ref _EmployerEOCommodity, value);
            }
        }
        public BaseEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerEOCommodity = await _EmployerActorContext.GetByIdAsync<EmployerEOCommodity>(id);
        }
    }
    public class PostEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
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
        private EmployerEOCommodity? _postEmployerEOCommodity = new();
        public EmployerEOCommodity? PostEmployerEOCommodity
        {
            get => _postEmployerEOCommodity;
            set
            {
                SetValue(ref _postEmployerEOCommodity, value);
            }
        }
        public PostEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerEOCommodity EmployerEOCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerEOCommodity>(EmployerEOCommodity);
            if (PostValue != null)
            {
                PostEmployerEOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEOCommodity = new();
            _postEmployerEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
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
        private EmployerEOCommodity? _putEmployerEOCommodity = new();
        public EmployerEOCommodity? PutEmployerEOCommodity
        {
            get => _putEmployerEOCommodity;
            set
            {
                SetValue(ref _putEmployerEOCommodity, value);
            }
        }
        public PutEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerEOCommodity EmployerEOCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerEOCommodity>(EmployerEOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEOCommodity = new();
            _putEmployerEOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
    {
        public DeleteEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerEOCommodity>(id);
        }
        public void Reset()
        {
            EmployerEOCommodity = new();
        }
    }
    public class GetsEmployerEOCommodityViewModel : BaseEmployerEOCommodityViewModel
    {
        private List<EmployerEOCommodity> _EmployerEOCommoditys = new();
        public List<EmployerEOCommodity> EmployerEOCommoditys
        {
            get=> _EmployerEOCommoditys;
            set
            {
                SetValue(ref _EmployerEOCommoditys, value);   
            }
        }
        public GetsEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEOCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerEOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerEOCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerEOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerEOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
