// using BusinessData;
// using BusinessData.ofAccount.ofModel;
// using BusinessData.ofPlanOrder;
// using BusinessLogic.ofManager.ofEntityGeneric;
// using BusinessLogic.ofManager.ofOrder;
// using Microsoft.AspNetCore.Components;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// namespace BusinessLogic.ofPresentation.ofBlazor
// {
//     public class OrderCardManager<TEntity> where TEntity : Status
//     {
//         private readonly StatusManager<TEntity> _StatusManager;
//         private readonly OCommodityManager _OCommodityManager;
//         private readonly OrderCenterManager _OrderCenterManager;
//         private readonly UserManager<BusinessUser> _UserManager;
//         private readonly IHttpContextAccessor _HttpContextAccessor;

//         public BusinessUser businessUser = new();
//         public OrderCenter orderCenter = new();
//         private List<TEntity> Entities = new();
//         private Dictionary<int, TEntity> DicEntities = new();
        
//         public OrderCardManager(NavigationManager navigationManager, StatusManager<TEntity> statusManager,
//                 UserManager<BusinessUser> userManager, HttpContextAccessor httpContextAccessor, OCommodityManager oCommodityManager,
//                 OrderCenterManager orderCenterManager)
//         {
//             _StatusManager = statusManager;
//             _UserManager = userManager;
//             _HttpContextAccessor = httpContextAccessor;
//             _OCommodityManager = oCommodityManager;
//             _OrderCenterManager = orderCenterManager;
//         }
        
//         public async Task LoadData()
//         {
//             Entities = await _StatusManager.GetToListAsync();
//             foreach(var Entity in Entities)
//             {
//                 DicEntities.Add(Entity.GetHashCode(), Entity);
//             }
//             businessUser = await _UserManager.GetUserAsync(_HttpContextAccessor.HttpContext.User);
//             orderCenter = await _OrderCenterManager.GetByUserAsync(businessUser);
//         }
        
//         public void DisPoseData()
//         {
//             Entities.Clear();
//             DicEntities.Clear();
//             businessUser = null;
//             orderCenter = null;
//         }
        
//         public async Task Order(Order order)
//         {
//             if(typeof(TEntity).Name.Equals(order.GetOrderOption().GetTypeofStatus().Name))
//             {

//             }
//         }
        
//     }
//     //public class CardManager<TEntity> : ComponentBase where TEntity : Status
//     //{
//     //    public BusinessUser BusinessUser = new();
//     //    public TEntity entity { get; set; }
//     //    public List<TEntity> Entities = new();
//     //    public Dictionary<int, TEntity> DicEntities = new();

//     //    protected override async Task OnInitializedAsync()
//     //    {
//     //        Entities = await EntityManager.GetToListAsync();
//     //        DicEntities = EntityManager.ConvertToDic(Entities);
//     //        Assembly assembly = typeof(TEntity).Assembly;
//     //        entity = (TEntity)assembly.CreateInstance(typeof(TEntity).Name);
//     //        BusinessUser = await UserManager.GetUserAsync(HttpContextAccessor.HttpContext.User);
//     //    }
//     //}
// }
