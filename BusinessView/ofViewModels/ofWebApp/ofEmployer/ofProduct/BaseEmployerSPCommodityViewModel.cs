using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerSPCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerSPCommodity? _EmployerSPCommodity = new();
        public EmployerSPCommodity? EmployerSPCommodity
        {
            get => _EmployerSPCommodity;
            set
            {
                SetValue(ref _EmployerSPCommodity, value);
            }
        }
        public BaseEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerSPCommodity = await _EmployerActorContext.GetByIdAsync<EmployerSPCommodity>(id);
        }
    }
    public class PostEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
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
        private EmployerSPCommodity? _postEmployerSPCommodity = new();
        public EmployerSPCommodity? PostEmployerSPCommodity
        {
            get => _postEmployerSPCommodity;
            set
            {
                SetValue(ref _postEmployerSPCommodity, value);
            }
        }
        public PostEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerSPCommodity EmployerSPCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerSPCommodity>(EmployerSPCommodity);
            if (PostValue != null)
            {
                PostEmployerSPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSPCommodity = new();
            _postEmployerSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
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
        private EmployerSPCommodity? _putEmployerSPCommodity = new();
        public EmployerSPCommodity? PutEmployerSPCommodity
        {
            get => _putEmployerSPCommodity;
            set
            {
                SetValue(ref _putEmployerSPCommodity, value);
            }
        }
        public PutEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerSPCommodity EmployerSPCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerSPCommodity>(EmployerSPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSPCommodity = new();
            _putEmployerSPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
    {
        public DeleteEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerSPCommodity>(id);
        }
        public void Reset()
        {
            EmployerSPCommodity = new();
        }
    }
    public class GetsEmployerSPCommodityViewModel : BaseEmployerSPCommodityViewModel
    {
        private List<EmployerSPCommodity> _EmployerSPCommoditys = new();
        public List<EmployerSPCommodity> EmployerSPCommoditys
        {
            get=> _EmployerSPCommoditys;
            set
            {
                SetValue(ref _EmployerSPCommoditys, value);   
            }
        }
        public GetsEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSPCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerSPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerSPCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerSPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerSPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
