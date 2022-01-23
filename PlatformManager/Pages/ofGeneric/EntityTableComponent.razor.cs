namespace PlatformManager.Pages.ofGeneric
{
    // 1. Column Name
    // 2. Column Value
    // 3. Manager
    // 4. 제약조건 ITablable
    // EntityTableComponent Control Dialog View
    // 제어는 부모 페이지에서 한다.
    // Many, One is RelationShip
    public enum TableViewMode {Dialog, Page}
    public enum TableStateMode {Get, Detail} 
    // Foreign Key의 경우 버튼으로 나타낸다. View 단 코드 처리하는 게 남아있다.
    public class EntityTableComponent<TEntity> : CompoenentBase where TEntity: Entity, IRelationable, ITablable, new()
    {
        [Inject] public IEntityManager<TEntity> EntityManager {get; set;}
        [CascadingParameter] public UserComponent UserComponent {get; set;}
        [Parameter] public List<TEntity> Entities = new();
        [Parameter] public TableViewMode ViewMode {get; set;}
        [Parameter] public TableStatieMode StateMode {get; set;}        
        private Dictionary<string, List<PropertyInfo>> DicTableProp {get; set;}
        private List<string> OneValueColumns = new();
        public List<PropertyInfo> OneValues = new();
        public List<PropertyInfo> ManyValues = new();
        private TEntity Entity = new();
        private IdentityUser IdentityUser {get; set;}
        private bool IsOpenCreateDialog {get; set;}
        private bool IsOpenUpdateDilaog {get; set;} 
        protected bool IsOpenDeleteDialog {get; set;}
        // 사용자 정의 View를 여기서 불러오면 되겠다.
        // IdentityUser 초기화 할 때.
        // 테이블 옵션에 해당하는 기능들을 추가했을 때 사용자 설정을 기억해야되니
        // OnParameterSetAsync()에서 기억하게 만들면 되겠다.
        protected override async Task OnParameterSetAsync()
        {
            // 이런 거는 ? 로 어떻게 처리할 수 있겠다.
            if(UserComponent != null) { IdentityUser = UserComponent.IdentityUser;}
            if(StateModel == null ) { StateMode = TableStateMode.Get;}
        }
        protected override async Task OnInitializedAsync()
        {            
            var props = typeof(TEntity).GerProperties();
            DicTableProp = Entity.GetToDictionaryforClassifiedPropertyByAttribute();    
            InitViewColumn(StateMode);
            if(IdentityUser != null)
            {
                Entities = await EntityManager.GetToListByUserAsync(IdentityUser);
            }     
            else
            {
                Entities = await EntityManager.GetToListAsync();
            }
        }
        public void SwitchCreateDialog()
        {
            IsOpenCreateDialog = !IsOpenCreateDialog;
        }
        public void SwitchCDeleteDialog()
        {
            IsOpenCDeleteDialog = !IsOpenCDeleteDialog;
        }
        public void SwitchUpdateDialog()
        {
            IsOpenUpdateDialog = !IsOpenUpdateDialog;
        }    
        // PropertyInfo.PropertyType is being
        private void InitViewColumn(TableStateMode stateMode)
        {
            if(stateMode.Equals(TableStateMode.Get))
            {   
                var props = DicTableProp[TableMetaInfo.Get];
                foreach(var prop in props)
                {
                    if(prop.PropertyType.Equals(typeof(IList) || prop.PropertyType.Equals(typeof(List))))
                    {
                        ManyValues.Add(prop);
                    }
                    else
                    {
                        OneValues.Add(prop);
                    }
                }
                InitOneValues(OneValues);
                InitManyValues(ManyValues);
            }
            if(stateMode.Equals(TableStateMode.Detail))
            {
                var props = DicTableProp[TableMetaInfo.Detail];
                foreach(var prop in props)
                {
                    if(prop.PropertyType.Equals(typeof(IList) || prop.PropertyType.Equals(typeof(List))))
                    {
                        ManyValues.Add(prop);
                    }
                    else
                    {
                        OneValues.Add(prop);
                    }
                }
                InitOneValues(OneValues);
                InitManyValues(ManyValues);
            }
        }
        // ManyValues 에 대한 자료를 제어할 수 있게 해주는 부분.
        private void InitManyValues(List<PropertyInfo> manyProps)
        {
            foreach(var prop in manyProps)
            {
                TableSetting newTable = new(prop);
                var props = prop.PropertyType.GetProperties();
                foreach(var prop in props)
                {
                    newTable.Add(prop.Name, prop);
                }
            }
        }
        private void InitOneValues(List<PropertyInfo> oneProps)
        {
            foreach(var prop in oneProps)
            {
                OneValueColumns.Add(prop.Name);
            }
        }
        public async Task CreateAsync(TEntity entity)
        {
            
        }
    }
}