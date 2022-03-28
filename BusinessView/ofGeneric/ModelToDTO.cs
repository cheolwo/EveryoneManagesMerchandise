using BusinessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofGeneric
{
    public interface INameAndValue
    {
        Dictionary<string, object> GetNameAndValue();
    }
    public interface IDTO : INameAndValue
    {
        IDTO CreateDTOByNameAndValue(Dictionary<string, object> nameAndValue);
    }
    public static class ModelToDTO<Model, DTO> where Model : class where DTO : class
    {
        public static DTO ConvertToDTO(Model model, DTO dto)
        {
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var prop in ModelProps)
            {
                var modelvalue = prop.GetValue(model);
                foreach(var dtoprop in DTOProps)
                {
                    if(dtoprop.Name.Equals(prop.Name))
                    {
                        dtoprop.SetValue(dto, modelvalue);
                    }
                }
            }
            return dto;
        }
    }
}
