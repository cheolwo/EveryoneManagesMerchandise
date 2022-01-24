using BusinessData;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace PlatformManager.Pages.ofGeneric
{
    public enum TableManagedMode {Dialog, Page}
    public enum TableViewMode {Get, Detail} 
    public partial class EntityTableComponent<TEntity> : ComponentBase where TEntity: Entity, IRelationable, ITablable, new()
    {
        [Inject] public IEntityManager<TEntity> EntityManager {get; set;}
        [Inject] public IEntityManager<BusinessUser> BusinessUserManager {get; set;}
        [Inject] public EntityNavigateFactory<TEntity> EntityNavigateFactory {get; set;}
        [Inject] public NavigationManager NavigationManager {get; set;}
        [CascadingParameter] public UserComponent UserComponent {get; set;}
        [Parameter] public List<TEntity> Entities { get; set; }
        private List<PropertyInfo> EntitySingObject {get; set;}
        private List<PropertyInfo> EntityMultifleObject {get; set;}
        private string TableViewMode {get; set;}
        private string TableManagedMode {get; set;}    
        private TableSetting TableSetting {get; set;}   
        private TableInfo EntitySingleObjectTableInfo {get; set;} 
        private List<TableInfo> EntityMultifleObjectTableInfo {get; set;}
        private Dictionary<string, List<PropertyInfo>> DicTableProp {get; set;}
        private TEntity Entity = new();
        private IdentityUser IdentityUser {get; set;}
        private bool IsOpenCreateDialog {get; set;}
        private bool IsOpenUpdateDialog {get; set;} 
        protected bool IsOpenDeleteDialog {get; set;}
        protected override async Task OnParameterSetAsync()
        {
            if(UserComponent != null) 
            {
                IdentityUser = UserComponent.IdentityUser;
                var BusinessUser = await BusinessUserManager.GetByUserId(IdentityUser.Id); // 이 코드는 암묵적으로 SNS 계정 하나 당 비즈니스 유저 하나만을 나타낼 수 있음을 의미한다.
                if(BusinessUser == null) {NavigationManager.NavigateTo($"/Create/BusinessUser/{IdentityUser.Id}");}
                else { TableSetting = await BusinessUser.TableSettings.FirstorDefaultAsync(e=>e.RelationCode.Equals(Entity.GetRelationCode()));}
                if(TableSetting != null)
                {
                  TableManagedMode = TableSetting.ManagedMode;
                  TableViewMode = TableSetting.ViewMode; 
                  if(TableSetting.GetColumnsSelected == null) { TableSetting.GetColumnsSelected = new();}
                  if(TableSetting.DetailColumnsSelected == null) { TableSetting.DetailColumnsSelected = new();}
                }
                else{ await InitUserTableSetting(BusinessUser);}
            }
        }
        protected override async Task OnInitializedAsync()
        {            
            var props = typeof(TEntity).GetProperties();
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
        public void SwitchDeleteDialog()
        {
            IsOpenDeleteDialog = !IsOpenDeleteDialog;
        }
        public void SwitchUpdateDialog()
        {
            IsOpenUpdateDialog = !IsOpenUpdateDialog;
        }    
        // PropertyInfo.PropertyType is being
        private void InitView(TableViewMode ViewMode)
        {
            if(ViewMode.Equals(TableViewMode.Get))
            {   
                var props = DicTableProp[TableMetaInfo.Get];
                foreach(var prop in props)
                {
                    if(prop.PropertyType.Equals(typeof(IList<>)) || prop.PropertyType.Equals(typeof(List<>)))
                    {
                        EntityMultifleObject.Add(prop);
                    }
                    else
                    {
                        EntitySingObject.Add(prop);
                    }
                }
                InitEntitySingObject(EntitySingObject);
                InitEntityMultifleObject(EntityMultifleObject);
            }
            if(ViewMode.Equals(TableViewMode.Detail))
            {
                var props = DicTableProp[TableMetaInfo.Detail];
                foreach(var prop in props)
                {
                    if(prop.PropertyType.Equals(typeof(IList<>)) || prop.PropertyType.Equals(typeof(List<>)))
                    {
                        EntityMultifleObject.Add(prop);
                    }
                    else
                    {
                        EntitySingleObject.Add(prop);
                    }
                }
                InitEntitySingObject(EntitySingObject);
                InitEntityMultifleObject(EntityMultifleObject);
            }
        }
        // EntityMultifleObject 에 대한 자료를 제어할 수 있게 해주는 부분.
        private void InitEntityMultifleObject(List<PropertyInfo> entityMultifleObject)
        {
            foreach(var prop in entityMultifleObject)
            {
                
                TableInfo newTable = new TableInfo(prop);
                var listprops = prop.PropertyType.GetProperties();
                foreach(var lprop in listprops)
                {
                    newTable.Add(lprop.Name, lprop);
                }
                EntityMultifleObject.Add(newTable);
            }
        }
        private void InitEntitySingObject(List<PropertyInfo> oneProps)
        {
            foreach(var prop in oneProps)
            {
                TableInfo newTable = new TableInfo();
                newTable.Add(prop.Name, prop);
            }
            EntitySingObject = newTable;
        }
        public async Task CreateAsync(TEntity entity)
        {
            // 이러한 코드 부분은 Finallty 에 해당한다.
            await EntityManager.CreateAsync(entity);
            SwitchCreateDialog();
            NavigationManager.NavigateTo(EntityNavigateFactory.GetPageofEntity());
        }
        public async Task UpdateAsync(TEntity entity)
        {
            await EntityManager.UpdateAsync(entity);
            SwitchUpdateDialog();
            NavigationManager.NavigateTo(EntityNavigateFactory.GetPageofEntity());
        }
        public async Task DeleteAsync(TEntity entity)
        {
            await EntityManager.DeleteAsync(entity);
            SwitchCDeleteDialog();
            NavigationManager.NavigateTo(EntityNavigateFactory.GetPageofEntity());
        }
    }
}