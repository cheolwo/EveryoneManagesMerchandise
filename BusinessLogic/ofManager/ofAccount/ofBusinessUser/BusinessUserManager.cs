namespace BusinessData.ofManager
{
}

/* Role Seed Logic*/
// private enum Role { Producter, Consumer, OnlineSelle, Logister, TradionSeller }

//         public async Task InitRole()
//         {
//             foreach (Role Role in Enum.GetValues(typeof(Role)))
//             {
//                 IdentityRole identityRole = new IdentityRole(Role.ToString());
//                 BusinessRole newRole = await _roleManager.FindByNameAsync(Role.ToString());
//                 if (newRole is null)
//                 {
//                     await _roleManager.CreateAsync(newRole);
//                 }
//             }
//         }
//         public async Task RegisteRoletoTraditionalSeller(string UserId)
//         {
//             BusinessUser user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
//             if (user != null)
//             {
//                 var Result = await _userManager.AddToRoleAsync(user, Role.TradionSeller.ToString());

//                 if (Result.Succeeded)
//                 {
//                     return;
//                 }
//                 else
//                 {
//                     throw new ArgumentException("Failed Register Role");
//                 }
//             }
//         }
//         public async Task RegisteRoletoTraditionalSeller(BusinessUser user)
//         {
//             if (user != null)
//             {
//                 var Result = await _userManager.AddToRoleAsync(user, Role.TradionSeller.ToString());

//                 if (Result.Succeeded)
//                 {
//                     return;
//                 }
//                 else
//                 {
//                     throw new ArgumentException("Failed Register Role");
//                 }
//             }
//         }
