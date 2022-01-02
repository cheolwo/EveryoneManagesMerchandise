using BusinessData.ofAccount.ofInterface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// 사용자 등록을 하면
// Seed가 주입되도록 해서 기능을 이용할 수 있도록 만들자.
// 역할에 등록이 될 때마다 사용자 등록이 가능해지도록 만드는 게 바람직하겠다.
namespace BusinessData.ofAccount.ofModel
{
    [NotMapped]
    public class BusinessAccountEntity
    {
        [Key] public string Id { get; set; }
        public DateTime CreateTime {get; set;}
        public IList<ChangeUser> ChangedUsers {get; set;}
        public IList<ImageofInfo> ImageofInfos {get; set;}
        public IList<Doc> Docs {get; set;}
    }
    // IdentityDataBase

    public class BusinessUser : BusinessAccountEntity, IRelatedUser
    {
        public string UserId {get ;set;} // IdentityUser.Id
        public string BuinessNumber { get; set; }
        public string CoutryCode {get; set;}    // 바코드 국가코드
        public string LogisticsCode {get; set;} // 바코드 업체코드
        public List<JournalSetting> JournalSettings { get; set; }
        public List<PayService> PayServices { get; set; }
        public List<TableSetting> TableSetings { get; set; }

        public string GetRelatedUser()
        {
            throw new NotImplementedException();
        }
    }
    public class WarehouseUser : BusinessUser
    {

    }

    public class JournalSetting : BusinessAccountEntity
    {
        public string Purspoe { get; set; }
        public IList<string> Debits { get; set; }
        public IList<string> Credits { get; set; }
        public BusinessUser BusinessUser { get; set; }
    }
    public class PayService : BusinessAccountEntity
    {
        public string ServiceName { get; set; }   // EntityManager,  OpenMakret, Tax, Message.. 등등
        public string DetailServiceName { get; set; } // TCommodity, SCommodity... 등등
        public IList<string> oprations { get; set; } // Add, Delete, Get, Update
        public BusinessUser BusinessUser { get; set; }
    }
    public class TableSetting : BusinessAccountEntity
    {
        public string EntityCode {get; set; }
        public List<string> SelectColumn { get; set; }
        public BusinessUser BusinessUser {get; set;}
    }
    public class PopBillInfo
    {
        public string PopBillId { get; set; }
        public string Password { get; set; }
        public string LinkId { get; set; }
        public string SecreatKey { get; set; }
    }
}
