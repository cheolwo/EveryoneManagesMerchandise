using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofDTO.ofCommon
{
    public class IdentityUserDTO : IViewModel
    {
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Id { get; set; }
    }
}
