// using System.Threading.Tasks;
// using BusinessData.ofAccount.ofModel;

// namespace BusinessData.ofManager.ofAccount
// {
//     public interface IPayManager<TEntity> where TEntity : Entity
//     {
//         Task<bool> IsPayed(BusinessUser businessUser);
//         Task InitSeed(BusinessUser busineeUser);
//     }
//     public class PayManager<TEntity> : IPayManager<TEntity> where TEntity : Entity
//     {
//         private readonly UserPayRepository _userPayRepository;
//         private UserPay UserPay = new UserPay();
//         public PayManager(UserPayRepository userPayRepository)
//         {
//             _userPayRepository = userPayRepository;
//         }
//         // BusinessUser 및 TEntity를 매개변수로 하여 Pay 했는지 체크
//         public async Task<bool> IsPayed(BusinessUser businessUser)
//         {
//             string Type = typeof(TEntity).ToString();
//             UserPay.businessUser = businessUser;
//             UserPay.payService.DetailServiceName = Type;
//             UserPay userPay = _userPayRepository.GetByEntity(userPay);
//             if (userPay != null) { return true; }
//             else { return false; }
//         }
//     }
// }