using System;

namespace BusinessData.ofAccount.ofModel
{
    public class BusinessEmployee : Entity
    {
        public string BusinessUserId {get; set;}
        public string EmployeeUserId {get; set;}
        public string EmployeeRole {get; set;}
        public string DetailRole {get; set;}
        public string CenterId {get; set;}
    }
}