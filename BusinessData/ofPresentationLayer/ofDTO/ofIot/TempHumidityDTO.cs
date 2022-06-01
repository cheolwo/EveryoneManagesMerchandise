using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofDTO.ofIotDTO
{
    public class TempHumidityDTO
    {
        public DateTime CreateTime { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Humidity { get; set; }
        public string Temperature { get; set; }
    }
}
