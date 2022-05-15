using BusinessView.ofCommon.ofInterface;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofDTO.ofCommon
{
    public class IdentityUserDTO : IEntityDTO
    {
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Id { get; set; }

        public Dictionary<string, List<PropertyInfo>> DictionaryforClassifiedPropertyByAttribute(Type t)
        {
            throw new NotImplementedException();
        }

        public bool EqualsById(object obj)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyDetailManyProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyDetailOneProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyDetailProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyGetManyProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyGetOneProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyGetProperties(Type t)
        {
            throw new NotImplementedException();
        }
    }
}
