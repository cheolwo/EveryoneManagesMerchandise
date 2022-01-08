namespace BusinessRazor.ofCommon
{
    public partial class EntityTableComponent : ComponentBase
    {
       [Parameter] public IUserTableManager<TEntity> UserTableManager {get; set;} // 형식구성담당
       [Parameter] public IUserJounalManager<TEntity> JounalManager {get; set;} 
       [Parameter] public IUserPayManager<TEntity> PayManager {get; set;}
       [Parameter] public IEntityManager<TEntity> EntityManager { get; set; } 
       [Parameter] public INavigateFactory<TEntity> NavigateFactory { get; set; }
       [Parameter] public NavigationManager NavigationManager { get; set; }
       [Parameter] public BusinessUser businessUser {get; set;}
       [Parameter] public TEntity Entity {get; set;}
       [CascadingParameter] public CenterComponent centerComponent {get; set;}
       public List<TEntity> Entities = new();
       public List<string> UserTableView = new();
        
       protected override async Task OnInitializedAsync()
       {
           Entities = await EntityManager.GetToListAsync();
           UserTableView = UserTableManager.GetToListAsync();
       }
       public bool IsOpen_DialogofAdd {get; set;}
       public bool IsOpen_DialogofUpdate {get; set;}
       public bool IsOpen_DialogofDelete {get; set;}
        

       public void DialogofAddToggle()
       {
           IsOpen_DialogofAdd = !IsOpen_DialogofAdd;
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