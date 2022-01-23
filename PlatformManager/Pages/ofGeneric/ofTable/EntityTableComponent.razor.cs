using BusinessData;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace PlatformManager.Pages.ofGeneric
{
    // 1. Column Name
    // 2. Column Value
    // 3. Manager
    // 4. 제약조건 ITablable
    // EntityTableComponent Control Dialog View
    // 제어는 부모 페이지에서 한다.
    // Many, One is RelationShip
    public enum TableManagedMode {Dialog, Page}
    public enum TableViewMode {Get, Detail} 
    // Foreign Key의 경우 버튼으로 나타낸다. View 단 코드 처리하는 게 남아있다.
    // 프론트 개발자는 주어진 기능을 이용하여 앞에 디자인 단을 개발하는 그런 사람을 말하는 게 아닌가 싶네.
    public partial class EntityTableComponent<TEntity> : ComponentBase where TEntity: Entity, IRelationable, ITablable, new()
    {
        [Inject] public IEntityManager<TEntity> EntityManager {get; set;}
        [Inject] public IEntityManager<BusinessUser> BusinessUserManager {get; set;}
        [Inject] public EntityNavigateFactory<TEntity> EntityNavigateFactory {get; set;}
        [Inject] public NavigationManager NavigationManager {get; set;}
        [CascadingParameter] public UserComponent UserComponent {get; set;}
        [Parameter] public List<TEntity> Entities { get; set; }
        [Parameter] public string ViewMode {get; set;}
        [Parameter] public string ManagedMode {get; set;}    
        private TableSetting tableSetting {get; set;}    
        private Dictionary<string, List<PropertyInfo>> DicTableProp {get; set;}
        private List<string> OneValueColumns = new();
        public List<PropertyInfo> OneValues = new();
        public List<PropertyInfo> ManyValues = new();
        private TEntity Entity = new();
        private IdentityUser IdentityUser {get; set;}
        private bool IsOpenCreateDialog {get; set;}
        private bool IsOpenUpdateDialog {get; set;} 
        protected bool IsOpenDeleteDialog {get; set;}
        // 사용자 정의 View를 여기서 불러오면 되겠다.
        // IdentityUser 초기화 할 때.
        // 테이블 옵션에 해당하는 기능들을 추가했을 때 사용자 설정을 기억해야되니
        // OnParameterSetAsync()에서 기억하게 만들면 되겠다.
        protected override async Task OnParameterSetAsync()
        {
            // 이런 거는 ? 로 어떻게 처리할 수 있겠다.
            if(UserComponent != null) 
            {
                IdentityUser = UserComponent.IdentityUser;
                var BusinessUser = await BusinessUserManager.GetByUserId(IdentityUser.Id); // 이 코드는 암묵적으로 SNS 계정 하나 당 비즈니스 유저 하나만을 나타낼 수 있음을 의미한다.
                if(BusinessUser == null) {NavigationManager.NavigateTo($"/Create/BusinessUser/{IdentityUser.Id}");}
                TableSetting = await BusinessUser.TableSettings.FirstorDefaultAsync(e=>e.RelationCode.Equals(Entity.GetRelationCode()));
                if(TableSetting != null)
                {
                  TableManagedMode = TableSetting.ManagedMode;
                  TableViewMode = TableSetting.ViewMode; 
                  if(TableSetting.GetColumnsSelected == null)
                  {
                      TableSetting.GetColumnsSelected = new();
                  }
                  if(TableSetting.DetailColumnsSelected == null)
                  {
                      TableSetting.DetailColumnsSelected = new();
                  }
                }
                else
                {
                    await InitUserTableSetting(BusinessUser);
                }
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
        public void SwitchCDeleteDialog()
        {
            IsOpenDeleteDialog = !IsOpenDeleteDialog;
        }
        public void SwitchUpdateDialog()
        {
            IsOpenUpdateDialog = !IsOpenUpdateDialog;
        }    
        // PropertyInfo.PropertyType is being
        private void InitViewColumn(TableViewMode ViewMode)
        {
            if(ViewMode.Equals(TableViewMode.Get))
            {   
                var props = DicTableProp[TableMetaInfo.Get];
                foreach(var prop in props)
                {
                    if(prop.PropertyType.Equals(typeof(IList<>)) || prop.PropertyType.Equals(typeof(List<>)))
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
            if(ViewMode.Equals(TableViewMode.Detail))
            {
                var props = DicTableProp[TableMetaInfo.Detail];
                foreach(var prop in props)
                {
                    if(prop.PropertyType.Equals(typeof(IList<>)) || prop.PropertyType.Equals(typeof(List<>)))
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
                TableSetting newTable = new TableSetting(prop);
                var listprops = prop.PropertyType.GetProperties();
                foreach(var lprop in listprops)
                {
                    newTable.Add(lprop.Name, lprop);
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