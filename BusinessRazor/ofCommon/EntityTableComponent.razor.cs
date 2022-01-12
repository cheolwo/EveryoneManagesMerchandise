namespace BusinessRazor.ofCommon
{
    public partial class EntityTableComponent<TEntity> : ComponentBase where TEntity : Entity, IRelationable
    {
        [Inject] public IEntityManager<TEntity> EntityManager { get; set; }
        [Inject] public INavigateFactory<TEntity> NavigateFactory { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Parameter] public List<TEntity> Entities { get; set; } // Not Data Load List Parameter
        [Parameter] public bool GetMode { get; set; }
        [CascadingParameter] public UserComponent UserComponent { get; set; }
        public Dictionary<string, List<PropertyInfo>> DicPropSet = new();
        protected override async Task OnInitializedAsync()
        {
            // Data Load
            if (UserComponent != null) { Entities = await EntityManager.GetToListByUserAsync(UserComponent.IdentityUser); }
            else { Entities = await EntityManager.GetToListAsync(); }
            // Column
            //public override Dictionary<string, List<PropertyInfo>> GetToDictionaryfoClassifiedPropertyByAttribute()
            DicPropSet = TEntity.GetToDictionaryfoClassifiedPropertyByAttribute();
        }
        public async Task Create(TEntity Entity)
        {
            var TEntity = await EntityManager.CreateAsync(Entity);
            if(TEntity != null) 
            {
                Entities.Add(TEntity);
                StashHasChanged();
            }
            DialogofCreateToggle();
        }
        public async Task Update(TEntity Entity)
        {
            var TEntity = await EntityManager.UpdateAsync(Entity);
            if(TEntity != null)
            {
                var UpdateEntity = Entities.Find(e=>e.Id.Equals(TEntity.Id));
                UpdateEntity = TEntity;
            }
            DialogofUpdateToggle();
        }
        public async Task Delete(TEntity Entity)
        {
            try
            {
                await EntityManager.DeleteAsync(Entity);
            }
            finally
            {
                Entities.Remove(Entity);
                StashHasChanged();
            }
            DialogofDeleteToggle();
        }
        public bool IsOpen_DialogofCreate { get; set; }
        public bool IsOpen_DialogofUpdate { get; set; }
        public bool IsOpen_DialogofDelete { get; set; }

        public void DialogofCreateToggle()
        {
            IsOpen_DialogofCreate = !IsOpen_DialogofCreate;
        }
        public void DialogofDeleteToggle()
        {
            IsOpen_DialogofDelete = !IsOpen_DialogofDelete;
        }
        public void DialogofUpdateToggle()
        {
            IsOpen_DialogofUpdate = !IsOpen_DialogofUpdate;
        }
    }
}