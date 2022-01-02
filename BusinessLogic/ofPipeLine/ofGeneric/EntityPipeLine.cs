//using System.Collections.Generic;
//using System.Threading.Tasks;
//using BusinessData;
//using BusinessData.ofAccount.ofModel;
//using BusinessData.ofFinancial.Model;
//using BusinessLogic.ofManager.ofGeneric;
//using Microsoft.AspNetCore.Authorization;

//namespace BusinessLogic.ofPipeLine.ofGeneric
//{
//    public class ResultofValidatedAddress
//    {
//        public string MacAddress { get; set; }
//        public string IPAddress { get; set; }
//        public bool IsValidated { get; set; }
//    }
//    public class ResultofValidatedRole
//    {
//        public string Role { get; set; }
//        public bool IsValidated { get; set; }
//    }
//    public class EntityPipeLine<TEntity, UEntity> : IEntityPipeLine<TEntity, UEntity>
//                                              where TEntity : Entity, IRelatedCenter, IRelatedRoles where UEntity : IdentityUser
//    {
//        private readonly IEntityManager<TEntity> _entityManager;
//        private ResultofValidatedAddress resultofValidatedAddress = new ResultofValidatedAddress();
//        private ResultofValidatedRole resultofValidatedRole = new ResultofValidatedRole();
//        public EntityPipeLine(IEntityManager<TEntity> entityManager)

//        {
//            _entityManager = entityManager;
//        }

//        public Task<TEntity> CreateAsync(TEntity entity)
//        {
//            return _entityManager.CreateAsync(entity);
//        }

//        public Task DeleteByIdAsync(string Id)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<List<TEntity>> GetToListAsync()
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<List<TEntity>> GetToListByUserAsync(UEntity uEntity)
//        {
//            throw new System.NotImplementedException();
//        }

//        public async Task<UEntity> GetUserByHttpContextAsync(HttpContext httpContext)
//        {
//            return await _userManager.GetUserAsync(httpContext.User);
//        }

//        public Task<TEntity> UpdateAsync(TEntity entity)
//        {
//            throw new System.NotImplementedException();
//        }

//        public ResultofValidatedAddress ValidateAddress(PipeModel<TEntity, UEntity> model)
//        {
//            resultofValidatedAddress.IPAddress = model.IPAddress;
//            resultofValidatedAddress.MacAddress = model.MacAddress;

//            Center center = model.BusinessEntity.GetRelatedCenter();
//            bool ValidatedIPAddress = false;
//            bool ValidatedMacAddress = false;
//            if (center != null)
//            {
//                foreach (var iPAddress in center.CenterIPAddresses)
//                {
//                    if (iPAddress.Equals(resultofValidatedAddress.IPAddress))
//                    {
//                        ValidatedIPAddress = true;
//                    }
//                }
//                foreach (var macAddress in center.CenterMacAddresses)
//                {
//                    if (macAddress.Equals(resultofValidatedAddress.MacAddress))
//                    {
//                        ValidatedMacAddress = true;
//                    }
//                }
//            }
//            if (ValidatedIPAddress && ValidatedMacAddress)
//            {
//                resultofValidatedAddress.IsValidated = true;
//            }
//            return resultofValidatedAddress;

//        }
//        public async Task<ResultofValidatedRole> ValidateRole(PipeModel<TEntity, UEntity> model)
//        {
//            IList<string> Roles = await _userManager.GetRolesAsync(model.UserEntity);
//            IList<string> AccesableRoles = model.BusinessEntity.GetRelatedRoles();

//            if (AccesableRoles.Count == 0)
//            {
//                resultofValidatedRole.IsValidated = true;
//                resultofValidatedRole.Role = typeof(AllowAnonymousAttribute).Name;
//                return resultofValidatedRole;
//            }
//            else
//            {
//                foreach (var Role in Roles)
//                {
//                    foreach (var AccesableRole in AccesableRoles)
//                    {
//                        if (AccesableRole.Equals(Role))
//                        {
//                            resultofValidatedRole.Role = AccesableRole;
//                            resultofValidatedRole.IsValidated = true;
//                            break;
//                        }
//                    }
//                }
//                return resultofValidatedRole;
//            }
//        }
//    }

//    public class PipeModel<TEntity, UEntity> where TEntity : Entity, IRelatedCenter, IRelatedRoles where UEntity : IdentityUser
//    {
//        public string MacAddress { get; set; }
//        public string IPAddress { get; set; }
//        public UEntity UserEntity { get; set; }
//        public TEntity BusinessEntity { get; set; }
//        public Journal Journal { get; set; }
//    }
//}