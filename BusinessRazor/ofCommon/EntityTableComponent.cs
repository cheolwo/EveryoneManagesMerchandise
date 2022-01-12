using BusinessData;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace BusinessRazor.ofCommon
{
    public partial class EntityTableComponent<TEntity> : ComponentBase where TEntity : Entity, IRelationable
    {
        [Parameter] public IEntityManager<TEntity> EntityManager { get; set; }
        [Parameter] public INavigateFactory<TEntity> NavigateFactory { get; set; }
        [Parameter] public NavigationManager NavigationManager { get; set; }
        [CascadingParameter] public UserComponent UserComponent { get; set; }
        public List<TEntity> Entities = new();
        public List<string> UserTableView = new();
        public TEntity? Entity { get; set; }
        public Dictionary<string, List<PropertyInfo>> DicProp = new();

        protected override async Task OnParametersSetAsync()
        {
            DicProp =  Entity.GetToDictionaryforClassifiedPropertyByAttribute();
        }
        protected override async Task OnInitializedAsync()
        {
            Entities = await EntityManager.GetToListAsync();
        }
        public bool IsOpen_DialogofAdd { get; set; }
        public bool IsOpen_DialogofUpdate { get; set; }
        public bool IsOpen_DialogofDelete { get; set; }

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