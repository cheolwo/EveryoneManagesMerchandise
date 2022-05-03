using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerOCommodity? _EmployerOCommodity = new();
        public EmployerOCommodity? EmployerOCommodity
        {
            get => _EmployerOCommodity;
            set
            {
                SetValue(ref _EmployerOCommodity, value);
            }
        }
        public BaseEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerOCommodity = await _EmployerActorContext.GetByIdAsync<EmployerOCommodity>(id);
        }
    }
    public class PostEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
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
        private EmployerOCommodity? _postEmployerOCommodity = new();
        public EmployerOCommodity? PostEmployerOCommodity
        {
            get => _postEmployerOCommodity;
            set
            {
                SetValue(ref _postEmployerOCommodity, value);
            }
        }
        public PostEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerOCommodity EmployerOCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerOCommodity>(EmployerOCommodity);
            if (PostValue != null)
            {
                PostEmployerOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerOCommodity = new();
            _postEmployerOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
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
        private EmployerOCommodity? _putEmployerOCommodity = new();
        public EmployerOCommodity? PutEmployerOCommodity
        {
            get => _putEmployerOCommodity;
            set
            {
                SetValue(ref _putEmployerOCommodity, value);
            }
        }
        public PutEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerOCommodity EmployerOCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerOCommodity>(EmployerOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerOCommodity = new();
            _putEmployerOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
    {
        public DeleteEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerOCommodity>(id);
        }
        public void Reset()
        {
            EmployerOCommodity = new();
        }
    }
    public class GetsEmployerOCommodityViewModel : BaseEmployerOCommodityViewModel
    {
        private List<EmployerOCommodity> _EmployerOCommoditys = new();
        public List<EmployerOCommodity> EmployerOCommoditys
        {
            get=> _EmployerOCommoditys;
            set
            {
                SetValue(ref _EmployerOCommoditys, value);   
            }
        }
        public GetsEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerOCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerOCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
