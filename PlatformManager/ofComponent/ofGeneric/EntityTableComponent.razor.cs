using BusinessData;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace PlatformManager.ofComponent.ofGeneric
{
    public enum TableManagedMode { Dialog, Page }
    public enum TableViewMode { Get, Detail }
    // 데이터 로드와는 관계
    public class TableOption
    {
        private TableViewMode TableViewMode { get; set; }
        private TableManagedMode TableManagedMode { get; set; }
        private bool IsUserTableSetting { get; set; }
        public TableOption(TableViewMode tableViewMode, TableManagedMode tableManagedMode)
        {
            TableViewMode = tableViewMode;
            TableManagedMode = tableManagedMode;
            IsUserTableSetting = false;
        }
        public void IsSetUserSettingTable() { IsUserTableSetting = true; }
        public TableOption(string tableView, string tableManagedMode)
        {
            if(tableView.Equals(TableViewMode.Get.ToString()))
            {
                TableViewMode = TableViewMode.Get;
            }
            else
            {
                TableViewMode = TableViewMode.Detail;
            }
            if(tableManagedMode.Equals(TableManagedMode.Dialog.ToString()))
            {
               TableManagedMode = TableManagedMode.Dialog;
            }
            else
            {
                TableManagedMode= TableManagedMode.Page;
            }
        }
        public TableViewMode GetTableViewMode()
        {
            return TableViewMode;
        }
        public TableManagedMode GetTableManagedMode()
        {
            return TableManagedMode;
        }
    }
    public class TableInfo
    {
        private PropertyInfo PropertyInfo { get; set; }
        private Dictionary<string, PropertyInfo> keyValuePairs { get; set; }
        public TableInfo(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
            keyValuePairs = new();
        }
        public PropertyInfo GetOrigin()
        {
            return PropertyInfo;
        }
        public TableInfo()
        {
            keyValuePairs = new();
        }
        public void Add(string name, PropertyInfo propertyInfo)
        {
            keyValuePairs.Add(name, propertyInfo);
        }
    }
    public enum TableInitCode { Success, Required_User_Register, Success_With_Table_Setting }
    public class EntityTableComponent<TEntity> where TEntity : Entity, IRelationable, ITablable, new()
    {
        protected readonly EntityManager<TEntity> _EntityManager;
        protected readonly EntityManager<BusinessUser> _BusinessUserManager;
        protected readonly EntityNavigateFactory<TEntity> _EntityNavigateFactory;
        protected readonly NavigationManager _NavigationManager;
        public EntityTableComponent(EntityManager<TEntity> entityManager, EntityManager<BusinessUser> businessUserManager,
                                EntityNavigateFactory<TEntity> entityNavigateFactory, NavigationManager navigationManager)
        {
            _EntityManager = entityManager;
            _BusinessUserManager = businessUserManager;
            _EntityNavigateFactory = entityNavigateFactory;
            _NavigationManager = navigationManager;
        }
        private IdentityUser IdentityUser { get; set; }
        public List<TEntity> Entities { get; set; }
        private List<PropertyInfo> EntitySingleObject { get; set; }
        private List<PropertyInfo> EntityMultifleObject { get; set; }

        public string TableViewMode { get; set; }
        private string TableManagedMode { get; set; }
        private TableSetting TableSetting { get; set; }
       
        private TableInfo EntitySingleObjectTableInfo { get; set; }
        private List<TableInfo> EntityMultifleObjectTableInfo { get; set; }

        private Dictionary<string, List<PropertyInfo>> DicTableProp { get; set; }
        private TEntity Entity = new();

        private bool IsOpenCreateDialog { get; set; }
        private bool IsOpenUpdateDialog { get; set; }
        protected bool IsOpenDeleteDialog { get; set; }
        public string GetTableManagedMode()
        {
            return TableManagedMode;
        }
        public string GetTableViewMode()
        {
            return TableViewMode;
        }
        public List<PropertyInfo> GetEntitySingleObjectProps()
        {
            return EntitySingleObject;
        }
        public List<PropertyInfo> GetEntityMultifleObjectProps()
        {
            return EntityMultifleObject;
        }
        public TableInfo GetSingObjectTableInfo()
        {
            return EntitySingleObjectTableInfo;
        }
        public List<TableInfo> GetMultifleObjectTableInfo()
        {
            return EntityMultifleObjectTableInfo;
        }
        public async Task<string> OnParametersSetAsync(List<TEntity> entities, UserComponent UserComponent)
        {
            if(entities != null)
            {
                Entities = entities;
            }
            if (UserComponent != null)
            {
                IdentityUser = UserComponent.IdentityUser;
                var BusinessUser = await _BusinessUserManager.GetByUserId(IdentityUser.Id); // 이 코드는 암묵적으로 SNS 계정 하나 당 비즈니스 유저 하나만을 나타낼 수 있음을 의미한다.
                if (BusinessUser == null) { return TableInitCode.Required_User_Register.ToString(); }
                TableSetting = BusinessUser.TableSettings.FirstOrDefault(e => e.RelationCode.Equals(Entity.GetRelationCode()));
                if (TableSetting != null)
                {
                    TableManagedMode = TableSetting.ManagedMode;
                    TableViewMode = TableSetting.ViewMode;
                    if (TableSetting.GetColumnsSelected == null) { TableSetting.GetColumnsSelected = new(); }
                    if (TableSetting.DetailColumnsSelected == null) { TableSetting.DetailColumnsSelected = new(); }
                    return TableInitCode.Success.ToString();
                }
                //await InitUserTableSetting(BusinessUser, Entity);
            }
            return TableInitCode.Success_With_Table_Setting.ToString();
        }
        private async Task InitUserTableSetting(BusinessUser businessUser, TEntity entity)
        {
            TableSetting tableSetting = new TableSetting();
            TableSetting.CreateTime = DateTime.Now;
            Dictionary<string, List<PropertyInfo>> DicTable = entity.GetToDictionaryforClassifiedPropertyByAttribute();
            List<string> GetColumnsSelected = new();
            List<string> DetailColumnsSelected = new();
            List<PropertyInfo> propertyInfos1 = DicTable[TableMetaInfo.Get];
            List<PropertyInfo> propertyInfos2 = DicTable[TableMetaInfo.GetMany];
            List<PropertyInfo> propertyInfos3 = DicTable[TableMetaInfo.GetOne];

            InitGetSettting(propertyInfos1, GetColumnsSelected);
            InitGetSettting(propertyInfos2, GetColumnsSelected);
            InitGetSettting(propertyInfos3, GetColumnsSelected);

            List<PropertyInfo> propertyInfos4 = DicTable[TableMetaInfo.Detail];
            List<PropertyInfo> propertyInfos5 = DicTable[TableMetaInfo.DetailOne];
            List<PropertyInfo> propertyInfos6 = DicTable[TableMetaInfo.DetailMany];

            InitDetailSettting(propertyInfos4, DetailColumnsSelected);
            InitDetailSettting(propertyInfos5, DetailColumnsSelected);
            InitDetailSettting(propertyInfos6, DetailColumnsSelected);

            tableSetting.RelationCode = entity.GetRelationCode();
            tableSetting.GetColumnsSelected = GetColumnsSelected;
            tableSetting.DetailColumnsSelected = DetailColumnsSelected;

            await _BusinessUserManager.UpdateAsync(businessUser); // 이거 할 때 오류나면 Attach 로 해야되.
        }
        private void InitGetSettting(List<PropertyInfo> propertyInfos, List<string> GetColumnsSelected)
        {
            foreach(var prop in propertyInfos)
            {
                GetColumnsSelected.Add(prop.Name);
            }
        }
        private void InitDetailSettting(List<PropertyInfo> propertyInfos, List<string> DetailColumnsSelected)
        {
            foreach (var prop in propertyInfos)
            {
                DetailColumnsSelected.Add(prop.Name);
            }
        }
        public async Task OnInitializedAsync(List<TEntity> entities)
        {
            if (entities.Count > 0)
            {
                var props = typeof(TEntity).GetProperties();
                DicTableProp = Entity.GetToDictionaryforClassifiedPropertyByAttribute();
                InitView();
                if (IdentityUser != null)
                {
                    Entities = await _EntityManager.GetToListByUserAsync(IdentityUser);
                }
                else
                {
                    Entities = await _EntityManager.GetToListAsync();
                }
            }
        }
        public void SwitchCreateDialog()
        {
            IsOpenCreateDialog = !IsOpenCreateDialog;
        }
        public void SwitchDeleteDialog()
        {
            IsOpenDeleteDialog = !IsOpenDeleteDialog;
        }
        public void SwitchUpdateDialog()
        {
            IsOpenUpdateDialog = !IsOpenUpdateDialog;
        }
        // PropertyInfo.PropertyType is being
        private void InitView()
        {
            if (TableViewMode.Equals("Get"))
            {
                var props = DicTableProp[TableMetaInfo.Get];
                foreach (var prop in props)
                {
                    if (prop.PropertyType.Equals(typeof(IList<>)) || prop.PropertyType.Equals(typeof(List<>)))
                    {
                        EntityMultifleObject.Add(prop);
                    }
                    else
                    {
                        EntitySingleObject.Add(prop);
                    }
                }
                InitEntitySingObject(EntitySingleObject);
                InitEntityMultifleObject(EntityMultifleObject);
            }
            if (TableViewMode.Equals("Detail"))
            {
                var props = DicTableProp[TableMetaInfo.Detail];
                foreach (var prop in props)
                {
                    if (prop.PropertyType.Equals(typeof(IList<>)) || prop.PropertyType.Equals(typeof(List<>)))
                    {
                        EntityMultifleObject.Add(prop);
                    }
                    else
                    {
                        EntitySingleObject.Add(prop);
                    }
                }
                InitEntitySingObject(EntitySingleObject);
                InitEntityMultifleObject(EntityMultifleObject);
            }
        }
        // EntityMultifleObject 에 대한 자료를 제어할 수 있게 해주는 부분.
        private void InitEntityMultifleObject(List<PropertyInfo> entityMultifleObject)
        {
            foreach (var prop in entityMultifleObject)
            {
                TableInfo newTable = new TableInfo(prop);
                var listprops = prop.PropertyType.GetProperties();
                foreach (var lprop in listprops)
                {
                    newTable.Add(lprop.Name, lprop);
                }
                EntityMultifleObjectTableInfo.Add(newTable);
            }
        }
        private void InitEntitySingObject(List<PropertyInfo> oneProps)
        {
            TableInfo newTable = new TableInfo();
            foreach (var prop in oneProps)
            {
                newTable.Add(prop.Name, prop);
            }
            EntitySingleObjectTableInfo = newTable;
        }
        public async Task CreateAsync(TEntity entity)
        {
            // 이러한 코드 부분은 Finallty 에 해당한다.
            await _EntityManager.CreateAsync(entity);
            SwitchCreateDialog();
            _NavigationManager.NavigateTo(_EntityNavigateFactory.GetPageofEntity(entity));
        }
        public async Task UpdateAsync(TEntity entity)
        {
            await _EntityManager.UpdateAsync(entity);
            SwitchUpdateDialog();
            _NavigationManager.NavigateTo(_EntityNavigateFactory.GetPageofEntity(entity));
        }
        public async Task DeleteAsync(TEntity entity)
        {
            await _EntityManager.DeleteByIdAsync(entity.Id);
            SwitchDeleteDialog();
            _NavigationManager.NavigateTo(_EntityNavigateFactory.GetPageofEntity(entity));
        }
    }
}