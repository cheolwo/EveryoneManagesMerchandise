using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerEPCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerEPCommodity? _EmployerEPCommodity = new();
        public EmployerEPCommodity? EmployerEPCommodity
        {
            get => _EmployerEPCommodity;
            set
            {
                SetValue(ref _EmployerEPCommodity, value);
            }
        }
        public BaseEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerEPCommodity = await _EmployerActorContext.GetByIdAsync<EmployerEPCommodity>(id);
        }
    }
    public class PostEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
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
        private EmployerEPCommodity? _postEmployerEPCommodity = new();
        public EmployerEPCommodity? PostEmployerEPCommodity
        {
            get => _postEmployerEPCommodity;
            set
            {
                SetValue(ref _postEmployerEPCommodity, value);
            }
        }
        public PostEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerEPCommodity EmployerEPCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerEPCommodity>(EmployerEPCommodity);
            if (PostValue != null)
            {
                PostEmployerEPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEPCommodity = new();
            _postEmployerEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
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
        private EmployerEPCommodity? _putEmployerEPCommodity = new();
        public EmployerEPCommodity? PutEmployerEPCommodity
        {
            get => _putEmployerEPCommodity;
            set
            {
                SetValue(ref _putEmployerEPCommodity, value);
            }
        }
        public PutEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerEPCommodity EmployerEPCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerEPCommodity>(EmployerEPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEPCommodity = new();
            _putEmployerEPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
    {
        public DeleteEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerEPCommodity>(id);
        }
        public void Reset()
        {
            EmployerEPCommodity = new();
        }
    }
    public class GetsEmployerEPCommodityViewModel : BaseEmployerEPCommodityViewModel
    {
        private List<EmployerEPCommodity> _EmployerEPCommoditys = new();
        public List<EmployerEPCommodity> EmployerEPCommoditys
        {
            get=> _EmployerEPCommoditys;
            set
            {
                SetValue(ref _EmployerEPCommoditys, value);   
            }
        }
        public GetsEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEPCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerEPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerEPCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerEPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerEPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
