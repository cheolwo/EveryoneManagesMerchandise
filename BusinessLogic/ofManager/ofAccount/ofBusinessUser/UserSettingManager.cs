// using Microsoft.EntityFrameworkCore;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace BusinessData.ofManager
// {
//     /*
//         1. 회계 : 차변 및 대변 구성 Status Attribute에 대해서    
//         2. 테이블 : 열 선택 가능    
//     */

//     public class UserSettingManager<TEntity> where TEntity : Entity
//     {
//         private readonly SettingJouranlRepository _settingJouranlRepository;
//         private SettingJouranl settingJouranl { get; set; }
//         public UserSettingManager(SettingJouranlRepository settingJouranlRepository)
//         {
//             _settingJouranlRepository = settingJouranlRepository;
//             settingJouranl = new SettingJouranl();
//         }
//         public enum Purpose
//         {
//             PCommodity, SPCommodity, MPCommodity, EPCommodity,
//             TCommodity, STCommodity, MTCommodity, ETCommodity,
//             WCommodity, SWCommodity, MWCommodity, EWCommodity,
//             MCommodity, SMCommodity, MMCommodity, EMCommodity,
//             DCommodity, SDCommodity, MDCommodity, EDCommodity
//         }

//         public async Task InitAccountingSubject(string UserId)
//         {
//             settingJouranl.UserId = UserId;
//             foreach (var purpose in Enum.GetValues(typeof(Purpose)))
//             {
//                 settingJouranl.Purpose = purpose.ToString();
//                 await _settingJouranlRepository.AddAsync(settingJouranl);
//             }
//         }
//     }
// }