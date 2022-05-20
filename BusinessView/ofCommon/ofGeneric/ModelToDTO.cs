using BusinessData;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json;

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
                            if(prop.PropertyType.IsGenericType)
                            {
                                var JsonModelValue = JsonConvert.SerializeObject(modelvalue, Formatting.Indented);
                                dtoprop.SetValue(dto, JsonModelValue);
                                break;
                            }
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
                                var DeserialObject = JsonConvert.DeserializeObject((string)dtovalue, modelprop.PropertyType);
                                modelprop.SetValue(model, DeserialObject);
                                break;
                            }
                            else
                            {
                                var Generic = dtoprop.GetCustomAttribute<GenericAttribute>();
                                if (Generic is not null)
                                {
                                    var DesirialObject = JsonConvert.DeserializeObject((string)dtovalue, Generic._t);
                                    modelprop.SetValue(model, DesirialObject);
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
            }
            return model;
        }
    }
}
