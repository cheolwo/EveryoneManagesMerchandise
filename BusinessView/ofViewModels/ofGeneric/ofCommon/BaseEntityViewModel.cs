using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public delegate void PostPageToGets();
    public delegate void PutPageToGets();
    public delegate void DeletePageToGets();
    public delegate Task GetsPageToPost(string id);
    public delegate Task GetsPageToPut(string id);
    public delegate Task GetsPageToDelete(string id);
    public class BaseEntityViewModel<TEntity> : BaseViewModel where TEntity : new()
    {
        protected readonly ActorContext _ActorContext;
        protected TEntity? _TEntity = new();
        public TEntity? Entity
        {
            get=>_TEntity;
            set
            {
                SetValue(ref _TEntity, value);
            }
        }
        public BaseEntityViewModel(ActorContext ActorContext)
        {
            _ActorContext = ActorContext;
        }    
        public async Task GetByIdAsync(string id)
        {
            Entity = await _ActorContext.GetByIdAsync<TEntity>(id);
        }   
    }
    /*
    
    */
    public class EntityPostViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public PostPageToGets? postPageToGets {get; set;}
        public EntityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
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
        private TEntity? _postTEntity = new();
        public TEntity? PostTEntity
        {
            get => _postTEntity;
            set
            {
                SetValue(ref _postTEntity, value);
            }
        }
        public async Task PostAsync(TEntity Entity)
        {
            var PostValue = await _ActorContext.PostAsync<TEntity>(Entity);
            if (PostValue != null)
            {
                PostTEntity = PostValue;
                IsPost = true;
                Back();
            }
        }
        public void Back()
        {
            Reset();
            if(postPageToGets == null) { throw new ArgumentNullException("PostPageToGets Is Null");}
            postPageToGets();
        }
        public void Reset()
        {
            IsPost = false;
            _TEntity = new();
            _postTEntity = new();
            OnPropertyChanged();
        }
    }
    public class EntityPutViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public PutPageToGets? putPageToGets {get; set;}
        public EntityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
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
        private TEntity? _putTEntity = new();
        public TEntity? PutTEntity
        {
            get => _putTEntity;
            set
            {
                SetValue(ref _putTEntity, value);
            }
        }
        public async Task PutAsync(TEntity TEntity)
        {
            var PutValue = await _ActorContext.PutAsync<TEntity>(TEntity);
            if(PutValue != null)
            {
                _isPut = true;
                PutTEntity = PutValue;
                Back();
            }
        }
        public void Back()
        {
            Reset();
            if(putPageToGets == null ) {throw new ArgumentNullException("PutPageToGets == null");}
            putPageToGets();
        }
        public void Reset()
        {
            _isPut = false;
            _TEntity = new();
            _putTEntity = new();
            OnPropertyChanged();
        }
    }
    public class EntityDeleteViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public DeletePageToGets? deletePageToGets {get; set;}
        public EntityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _ActorContext.DeleteByIdAsync<TEntity>(id);
            Back();
        }
        public void Back()
        {
            Reset();
            if(deletePageToGets == null) { throw new ArgumentNullException("DeletePageToGets Is Null");}
            deletePageToGets();
        }
        public void Reset()
        {
            Entity = new();
        }
    }
    public class EntityGetsViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public GetsPageToPost? getsPageToPost {get; set;}
        public GetsPageToPut? getsPageToPut {get; set;}
        public GetsPageToDelete? getsPageToDelete {get; set;}
        public EntityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        private List<TEntity> _TEntitys = new();
        public List<TEntity> TEntitys
        {
            get=> _TEntitys;
            set
            {
                SetValue(ref _TEntitys, value);   
            }
        }
        public async Task GetsAsync()
        {
            IEnumerable<TEntity>? dtos = await _ActorContext.GetsAsync<TEntity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _TEntitys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<TEntity>? dtos = await _ActorContext.GetsAsyncByUserId<TEntity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _TEntitys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsPageToPost(string id)
        {
            if(getsPageToPost == null ) {throw new ArgumentNullException("GetsPageToPost Is Null");}
            await getsPageToPost(id);
        }
        public async Task GetsPageToPut(string id)
        {
            if(getsPageToPut == null ) {throw new ArgumentNullException("GetsPageToPut Is Null");}
            await getsPageToPut(id);
        }
        public async Task GetsPageToDelete(string id)
        {
            if(getsPageToDelete == null ) {throw new ArgumentNullException("GetsPageToDelete Is Null");}
            await getsPageToDelete(id);
        }
    }
}