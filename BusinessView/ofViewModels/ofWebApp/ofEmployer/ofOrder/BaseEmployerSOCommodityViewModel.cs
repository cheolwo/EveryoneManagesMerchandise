using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerSOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerSOCommodity? _EmployerSOCommodity = new();
        public EmployerSOCommodity? EmployerSOCommodity
        {
            get => _EmployerSOCommodity;
            set
            {
                SetValue(ref _EmployerSOCommodity, value);
            }
        }
        public BaseEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerSOCommodity = await _EmployerActorContext.GetByIdAsync<EmployerSOCommodity>(id);
        }
    }
    public class PostEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
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
        private EmployerSOCommodity? _postEmployerSOCommodity = new();
        public EmployerSOCommodity? PostEmployerSOCommodity
        {
            get => _postEmployerSOCommodity;
            set
            {
                SetValue(ref _postEmployerSOCommodity, value);
            }
        }
        public PostEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerSOCommodity EmployerSOCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerSOCommodity>(EmployerSOCommodity);
            if (PostValue != null)
            {
                PostEmployerSOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSOCommodity = new();
            _postEmployerSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
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
        private EmployerSOCommodity? _putEmployerSOCommodity = new();
        public EmployerSOCommodity? PutEmployerSOCommodity
        {
            get => _putEmployerSOCommodity;
            set
            {
                SetValue(ref _putEmployerSOCommodity, value);
            }
        }
        public PutEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerSOCommodity EmployerSOCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerSOCommodity>(EmployerSOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSOCommodity = new();
            _putEmployerSOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
    {
        public DeleteEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerSOCommodity>(id);
        }
        public void Reset()
        {
            EmployerSOCommodity = new();
        }
    }
    public class GetsEmployerSOCommodityViewModel : BaseEmployerSOCommodityViewModel
    {
        private List<EmployerSOCommodity> _EmployerSOCommoditys = new();
        public List<EmployerSOCommodity> EmployerSOCommoditys
        {
            get=> _EmployerSOCommoditys;
            set
            {
                SetValue(ref _EmployerSOCommoditys, value);   
            }
        }
        public GetsEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSOCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerSOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerSOCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerSOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerSOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
