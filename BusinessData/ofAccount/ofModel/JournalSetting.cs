using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

// 사용자 등록을 하면
// Seed가 주입되도록 해서 기능을 이용할 수 있도록 만들자.
// 역할에 등록이 될 때마다 사용자 등록이 가능해지도록 만드는 게 바람직하겠다.

namespace BusinessData.ofAccount.ofModel
{
    [DataContext(typeof(BusinessUserDbContext), DbConnectionString.BusinessUserDbConnection)]
    [Relation(typeof(JournalSetting), nameof(JournalSetting))]
    public class JournalSetting : Entity
    {
        public string Purpose {get; set;}
        public string RelationCode {get; set;}
        public List<string> Debits { get; set; }
        public List<string> Credits { get; set; }
        public BusinessUser BusinessUser { get; set; }
    }
    // public class PopBillInfo
    // {
    //     public string PopBillId { get; set; }
    //     public string Password { get; set; }
    //     public string LinkId { get; set; }
    //     public string SecreatKey { get; set; }
    // }
}
