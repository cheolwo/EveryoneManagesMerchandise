using BusinessData;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using BusinessRazor.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using ProducterWebApp.Pages.ofGeneric;
using System.Reflection;

namespace BusinessRazor.ofGeneric
{
    public enum TableManagedMode { Dialog, Page }
    public enum TableViewMode { Get, Detail }
    public class TableInfo
    {
        private PropertyInfo PropertyInfo { get; set; }
        private Dictionary<string, PropertyInfo> keyValuePairs { get; set; }
        public TableInfo(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
            keyValuePairs = new();
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
    public class EntityTableComponent<TEntity> : ComponentBase where TEntity : Entity, IRelationable, ITablable, new()
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
        [CascadingParameter] public UserComponent UserComponent { get; set; }
        protected List<TEntity> Entities { get; set; }
        public List<PropertyInfo> EntitySingleObject { get; set; }
        public List<PropertyInfo> EntityMultifleObject { get; set; }
        public string TableViewMode { get; set; }
        private string TableManagedMode { get; set; }
        private TableSetting TableSetting { get; set; }
        private TableInfo EntitySingleObjectTableInfo { get; set; }
        private List<TableInfo> EntityMultifleObjectTableInfo { get; set; }
        private Dictionary<string, List<PropertyInfo>> DicTableProp { get; set; }
        private TEntity Entity = new();
        private IdentityUser IdentityUser { get; set; }
        private bool IsOpenCreateDialog { get; set; }
        private bool IsOpenUpdateDialog { get; set; }
        protected bool IsOpenDeleteDialog { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            if (UserComponent != null)
            {
                IdentityUser = UserComponent.IdentityUser;
                var BusinessUser = await _BusinessUserManager.GetByUserId(IdentityUser.Id); // 이 코드는 암묵적으로 SNS 계정 하나 당 비즈니스 유저 하나만을 나타낼 수 있음을 의미한다.
                if (BusinessUser == null) { _NavigationManager.NavigateTo($"/Create/BusinessUser/{IdentityUser.Id}"); }
                else { TableSetting = BusinessUser.TableSettings.FirstOrDefault(e => e.RelationCode.Equals(Entity.GetRelationCode())); return; }
                if (TableSetting != null)
                {
                    TableManagedMode = TableSetting.ManagedMode;
                    TableViewMode = TableSetting.ViewMode;
                    if (TableSetting.GetColumnsSelected == null) { TableSetting.GetColumnsSelected = new(); }
                    if (TableSetting.DetailColumnsSelected == null) { TableSetting.DetailColumnsSelected = new(); }
                }
                //else { await InitUserTableSetting(BusinessUser, Entity); }
            }
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

            tableSetting.GetColumnsSelected = GetColumnsSelected;
            tableSetting.DetailColumnsSelected = DetailColumnsSelected;

            await _BusinessUserManager.UpdateAsync(businessUser);
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
        protected override async Task OnInitializedAsync()
        {
            Entities = new();
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