// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using System;
// using System.Linq;
// using Microsoft.AspNetCore.Identity;
// using BusinessData.ofAccount.ofModel;
// using BusinessData.ofAccount.ofRepository;

// namespace BusinessData.ofManager
// {
//     // 매니저에서 예외를 던져주고
//     // 컨트롤러에서 예외를 처리하는 것으로 하자.
//     // 예외에 따라 페이지를 전환해주던가 Dialog 창을 띄워주던가 하는 것으로
//     // Page 처리방식을 결정할 수 있겠다.
//     public class BusinessUserManager : UserManager<BusinessUser>
//     {
//         private readonly UserJournalSettingRepository _userJounalSettingRepository;
//         private readonly BusinessUserRepository _businessUserRepository;
//         public BusinessUserManager(UserJournalSettingRepository userJournalSettingRepository,
//                                     BusinessUserRepository businessUserRepository)
//         {
//             _userJounalSettingRepository = userJournalSettingRepository;
//             _businessUserRepository = businessUserRepository;
//         }
//         public async Task AddToJournalSetting(BusinessUser businessUser, JounalSetting jounalSetting)
//         {
//             // 같은 목적을 가지는 JounalSetting 있는지 확인필요.
//             UserJounalSetting checkSetting = await _userJounalSettingRepository.GetByBusinessUserAsync(businessUser);
//             if (!checkSetting.journalSetting.purpose.Equals(jounalSetting.purpose))
//             {
//                 await _userJounalSettingRepository.AddAsync(new UserJounalSetting { businessUser, jounalSetting });
//             }

//             throw new ArgumentException("Joural Purpose Is Duplecated");
//         }
//         public async Task<JounalSetting> GetJounalSettingByPurpose(BusinessUser businessUser, string Purpose)
//         {
//             List<UserJournalSetting> userJournalSettings = await _userJounalSettingRepository.GetToListAsyncByBusinessUser(businessUser);
//             UserJounalSetting userJounalSetting = userJournalSettings.FirstOrDefaultAsync(e => e.Purpose.Equals(Purpose));
//             if (userJounalSetting != null)
//             {
//                 return userJounalSetting;
//             }
//             throw new ArgumentException("Not Register");
//         }
//     }
// }