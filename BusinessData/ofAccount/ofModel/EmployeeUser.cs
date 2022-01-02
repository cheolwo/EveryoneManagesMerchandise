using BusinessData.ofAccount.ofInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofAccount.ofModel
{
    public class EmployeeAccountEntity
    {
        [Key] public string Id { get; set; }
        public DateTime CreateTime {get; set;}
        public IList<ChangeUser> ChangedUsers {get; set;}
        public IList<ImageofInfo> ImageofInfos {get; set;}
        public IList<Doc> Docs {get; set;}
    }
    public class EmployeeUser : EmployeeAccountEntity, IRelatedUser
    {
        public string UserId {get; set;} // IdentityUser.Id
        public IList<DocofEmployee> DocsofEmployee { get; set; }
        public IList<AttendanceCalender> AttendanceCalenders { get; set; }

        public string GetRelatedUser()
        {
            throw new NotImplementedException();
        }

        public string GetRelationCode()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(type, typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetEntityRelation();
        }

        public Type GetRelationType()
        {
            Type type = this.GetType();
            RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(type, typeof(RelationAttribute));
            
            if(relationAttribute == null)
            {
                throw new ArgumentException("Not Define Relation");
            }

            return relationAttribute.GetRelationType();
        }
    }

    public class DocofEmployee
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }        // 근로규칙, 근로계약서, 통장사본
        public string FileTitle { get; set; }
        public string FileRoute { get; set; }
        public EmployeeUser Salary { get; set; }
    }

    public class AttendanceCalender
    {
        [Key] public int Id { get; set; }
        public string Role { get; set; }
        public DateTime? StrartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public EmployeeUser Employee { get; set; }
    }
}
