using BusinessData.ofAccount.ofModel;
using BusinessData.ofAccount.ofRepository;
using Microsoft.AspNetCore.Identity;

namespace BusinessData.ofManager
{
   public interface IEmployeeUserManager<TEntity> where TEntity : EmployeeAccountEntity
   {
   }
   public class EmployeeUserManager<TEntity> : IEmployeeUserManager<TEntity> where TEntity : EmployeeAccountEntity
   {
       private readonly IEmployeeUserRepository<TEntity> _EmployeeUserRepository;
       public EmployeeUserManager(EmployeeUserRepository<TEntity> EmployeeUserRepository)
       {
           _EmployeeUserRepository = EmployeeUserRepository;
       }
   }
   //public class EmployeeUserManager<TEntity> : UserManager<TEntity> where TEntity : EmployeeUser
   //{
   //    public EmployeeUserManager()
   //}
}