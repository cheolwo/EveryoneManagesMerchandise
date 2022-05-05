using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerPCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerPCommodity? _EmployerPCommodity = new();
        public EmployerPCommodity? EmployerPCommodity
        {
            get => _EmployerPCommodity;
            set
            {
                SetValue(ref _EmployerPCommodity, value);
            }
        }
        public BaseEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerPCommodity = await _EmployerActorContext.GetByIdAsync<EmployerPCommodity>(id);
        }
    }
    public class PostEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
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
        private EmployerPCommodity? _postEmployerPCommodity = new();
        public EmployerPCommodity? PostEmployerPCommodity
        {
            get => _postEmployerPCommodity;
            set
            {
                SetValue(ref _postEmployerPCommodity, value);
            }
        }
        public PostEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerPCommodity EmployerPCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerPCommodity>(EmployerPCommodity);
            if (PostValue != null)
            {
                PostEmployerPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerPCommodity = new();
            _postEmployerPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
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
        private EmployerPCommodity? _putEmployerPCommodity = new();
        public EmployerPCommodity? PutEmployerPCommodity
        {
            get => _putEmployerPCommodity;
            set
            {
                SetValue(ref _putEmployerPCommodity, value);
            }
        }
        public PutEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerPCommodity EmployerPCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerPCommodity>(EmployerPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerPCommodity = new();
            _putEmployerPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
    {
        public DeleteEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerPCommodity>(id);
        }
        public void Reset()
        {
            EmployerPCommodity = new();
        }
    }
    public class GetsEmployerPCommodityViewModel : BaseEmployerPCommodityViewModel
    {
        private List<EmployerPCommodity> _EmployerPCommoditys = new();
        public List<EmployerPCommodity> EmployerPCommoditys
        {
            get=> _EmployerPCommoditys;
            set
            {
                SetValue(ref _EmployerPCommoditys, value);   
            }
        }
        public GetsEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerPCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerPCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
