// using BusinessData.ofAccount.ofModel;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;
// using Popbill;
// using Popbill.Closedown;
// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// namespace BusinessData.NationalTaxManager
// {
//     public class PopBillManager
//     {
//         private readonly UserManager<BusinessUser> _userManager;
//         private readonly HttpContextAccessor _httpContextAccessor;
//         private ClosedownService _closedownService;

//         public PopBillManager(UserManager<BusinessUser> userManager,
//                                     HttpContextAccessor httpContextAccessor)
//         {
//             _userManager = userManager;
//             _httpContextAccessor = httpContextAccessor;
//         }

//         public async Task PopBillInit(string UserId)
//         {
//             BusinessUser User = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
//             if (User != null)
//             {
//                 _closedownService = new ClosedownService(User.PopBillInfo.LinkId, User.PopBillInfo.SecreatKey)
//                 {

//                     // 연동환경 설정값, 개발용(true), 상업용(false)
//                     IsTest = true,

//                     // 인증토큰 아이피 제한 기능 사용여부 권장(true)
//                     IPRestrictOnOff = true,

//                     // 팝빌 API 서비스 고정 IP 사용여부(GA), true-사용, false-미사용, 기본값(false)
//                     UseStaticIP = false,

//                     // 로컬시스템 시간 사용여부, true(사용) - 기본값, false(미사용)
//                     UseLocalTimeYN = true
//                 };
//                 return;
//             }
//             throw new ArgumentException("PopBill Access Info is Null");
//         }

//         public async Task<List<CorpState>> CheckCloseDownByCorpNums(List<string> targetCorpNums)
//         {
//             //팝빌 연동회원 사업자번호 (하이픈 '-' 없이 10자리)
//             BusinessUser businessUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
//             if (businessUser != null)
//             {
//                 try
//                 {
//                     var response = _closedownService.checkCorpNums(businessUser.BuinessNumber, targetCorpNums, businessUser.PopBillInfo.PopBillId);
//                     return response;
//                 }
//                 catch (PopbillException pe)
//                 {
//                     throw new ArgumentException(pe.Message);
//                 }
//             }
//             throw new ArgumentException("Business User Is Null");
//         }

//         public async Task<CorpState> CheckCloseDownByCorpNum(string targetCorpNum)
//         {
//             BusinessUser businessUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
//             if (businessUser != null)
//             {
//                 try
//                 {
//                     var response = _closedownService.checkCorpNum(businessUser.BuinessNumber, targetCorpNum, businessUser.PopBillInfo.PopBillId);
//                     return response;
//                 }
//                 catch (PopbillException pe)
//                 {
//                     throw new ArgumentException(pe.Message);
//                 }
//             }
//             throw new ArgumentException("Business User Is Null");
//         }

//     }
// }

// /*
//  * 1	corpNum	사업자번호	string	-	조회한 사업자번호
//     2	type	사업자 과세유형	string	-	null : (미확인) / "1" : (일반과세자) / "2" : (면세과세자)
// "3" : (간이과세자) / "4" : (비영리법인 또는 국가기관, 고유번호가 부여된 단체) 중 반환
// 3	typeDate	과세유형 전환일자	string	-	형식 : yyyy-MM-dd
// 4	state	휴폐업상태	string	-	null : (미확인) / "0" : (미등록 - 등록되지 않은 사업자번호) / "1" : (사업중) / "2" : (폐업) / "3" : (휴업) 중 반환
// 5	stateDate	휴폐업일자	string	-	형식 : yyyy-MM-dd
// 6	checkDate	국세청 확인일자	string	-	팝빌이 휴폐업 조회한 일자 (형식 : yyyy-MM-dd)
//  */