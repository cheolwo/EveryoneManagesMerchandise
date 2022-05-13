using BusinessData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessView.ofGeneric
{
    public interface IDTO 
    {
        string GetServerUrl(bool IsProduct);
    }
    // 직렬화가 주요 개념
    public class ModelToDTO<Model, DTO> where Model : class where DTO : class
    {
        public static DTO ConvertToDTO(Model model, DTO dto)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var prop in ModelProps)
            {
                var modelvalue = prop.GetValue(model);
                foreach(var dtoprop in DTOProps)
                {
                    if(dtoprop.Name.Equals(prop.Name))
                    {
                        var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                        var One = dtoprop.GetCustomAttribute<OneAttribute>();
                        if (Many is not null || One is not null)
                        {
                            var dtovalue = JsonConvert.SerializeObject(modelvalue, Formatting.Indented);
                            dtoprop.SetValue(dto, dtovalue);
                            break;
                        }
                        else
                        {
                            dtoprop.SetValue(dto, modelvalue);
                            break;
                        }
                    }
                }
            }
            return dto;
        }
    }
    // 역직렬화가 주요 개념
    public class DTOToModel<DTO, Model> where DTO : class where Model : class
    {
        public static Model ConvertToModel(DTO dto, Model model)
        {
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var dtoprop in DTOProps)
            {
                var dtovalue = dtoprop.GetValue(dto);
                if (dtovalue != null)
                {
                    foreach (var modelprop in ModelProps)
                    {
                        if (dtoprop.Name.Equals(modelprop.Name))
                        {
                            var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                            var One = dtoprop.GetCustomAttribute<OneAttribute>();
                            if (Many is not null || One is not null)
                            {
                                string JsonDtoValue = (string)dtovalue;
                                var DeserialObject = JsonConvert.DeserializeObject(JsonDtoValue, modelprop.PropertyType);
                                modelprop.SetValue(model, DeserialObject);
                                break;
                            }
                            else
                            {
                                modelprop.SetValue(model, dtovalue);
                                break;
                            }
                        }
                    }
                }
            }
            return model;
        }
    }
}
