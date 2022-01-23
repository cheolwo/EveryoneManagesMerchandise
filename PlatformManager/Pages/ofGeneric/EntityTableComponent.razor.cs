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
    // 이것도 Dictionary 형태로 만드는 게 좋아보이기는 해.
    public class TableSetting
    {
        private Dictionary<string, PropertyInfo> NamePropPairs {get; set;}
        private PropertyInfo Origin {get; set;}
        public TableSetting(PropertyInfo origin)
        {
            Origin = origin;
            NamePropPairs = new();
        }    
        public void Add(string name, PropertyInfo prop)
        {
            NamePropPairs.Add(name, prop);
        }
        public IEnumrable<string> GetColumns()
        {
            return NamePropPairs.Keys;
        }
        public List<PropertyInfo> GetValues()
        {
            List<PropertyInfo> props = new();
            foreach(var key in NamePropPairs.Keys)
            {
                props.Add(NamePropPairs[key]);
            }
            return props;
        }
    }
    // One의 경우 버튼으로 나타낸다.
    public class EntityTableComponent<TEntity> : CompoenentBase where TEntity: Entity, IRelationable, ITablable
    {
        [Inject] public IEntityManager<TEntity> EntityManager {get; set;}
        [Parameter] public List<TEntity> Entities = new();
        [Parameter] public TableViewMode ViewMode {get; set;}
        [Parameter] public TableStatieMode StateMode {get; set;}
        private Dictionary<string, List<PropertyInfo>> DicTableProp {get; set;}
        private List<string> OneValueColumns = new();
        private List<PropertyInfo> OneValues = new();
        private List<PropertyInfo> ManyValues = new();
        private TEntity Entity = new();
        private bool IsOpenCreateDialog {get; set;}
        private bool IsOpenUpdateDilaog {get; set;} 
        protected bool IsOpenDeleteDialog {get; set;}
        protected override async Task OninitializedAsync()
        {            
            var props = typeof(TEntity).GerProperties();
            DicTableProp = Entity.GetToDictionaryforClassifiedPropertyByAttribute();
            Entities = await EntityManager.GetToListAsync();              
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
    }
}