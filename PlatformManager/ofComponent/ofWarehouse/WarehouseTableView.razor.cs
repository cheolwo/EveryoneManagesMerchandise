using BusinessData.ofWarehouse.Model;
using Microsoft.AspNetCore.Components;
using PlatformManager.ofComponent.ofGeneric;

namespace PlatformManager.ofComponent.ofWarehouse
{
    public partial class WarehouseTableView : ComponentBase
    {
        [Inject] public EntityTableComponent<Warehouse> ?EntityTableComponent { get; set; }
        [CascadingParameter] public UserComponent ?UserComponent { get; set; }
        public List<Warehouse> ?Warehouses { get; set; }
        public Warehouse ?Warehouse { get; set; }

        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;

        protected override async Task OnParametersSetAsync()
        {
            await EntityTableComponent.OnParametersSetAsync(Warehouses, UserComponent);
        }
        protected override async Task OnInitializedAsync()
        {
        }
    }
}
