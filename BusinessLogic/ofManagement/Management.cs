// using System;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;

// namespace BusinessLogic.ofManagement
// {
//     public class AccountManagement
//     {
//         private readonly UserManager<IdentityUser> _userManager;
//         private readonly IHttpContextAccessor _httpContextAccessor;
//         public AccountManagement(UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
//         {
//             _userManager = userManager;
//             _httpContextAccessor = httpContextAccessor;
//         }
//         public virtual async Task<IdentityUser> OnInitializedAsync()
//         {
//             return await GetUserAsync();
//         }
//         public private async Task<IdentityUser> GetUserAsync()
//         {
//             return await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
//         }
//     }
//     public class EmployeeManagement<TEntity, UEntity> : AccountManagement, IEmployeeManagement<TEntity, UEntity> where TEntity : Entity, IRelationable, IRelatedCenter where UEntity : IRelatedUser
//     {
//         private readonly IEmployeeUserManager _employeeUserManager;
//         private readonly IBusinessEmployeeManager _businessEmployeeManager;
//         public EmployeeManagement(IEmployeeUserManaegr employeeUserManaegr, IBusinessEmployeeManager businessEmployeeManager, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
//                             :base(userManager, httpContextAccessor)
//         {
//             _employeeUserManager = employeeUserManaegr;
//             _businessEmployeeManager = businessEmployeeManager;
//         }
//         public override Task<BusinessEmployee> OnInitializedAsync(TEntity tentity)
//         {
//             var User = base.OnInitializedAsync();
//             if(User != null)
//             {
//                 var employee = GetEmployeeUserAsync(User);
//                 if(employee != null)
//                 {
//                     var businssemployee = await _businessEmployeeManager.GetUserAsyncByEmployeeId(employee.Id);
//                     if(businssemployee != null)
//                     {
//                         var center = tentity.GetRelatedCenter();
//                         if(center.Id.Equals(businssemployee.CenterId))
//                         {
//                             return businssemployee;
//                         }
//                         throw new ArgumentException();
//                     }
//                 }
//                 throw new ArgumentNullException();
//             }
//             throw new ArgumentNullException();
//         }
//         private async Task<EmployeeUser> GetEmployeeUserAsync(IdentityUser identityUser)
//         {
//             return await _employeeUserManager.GetUserAsyncByIdentityUser(identityUser);
//         }
//     }
// }