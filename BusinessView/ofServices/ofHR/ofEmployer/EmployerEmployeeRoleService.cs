﻿using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployerEmployeeRoleService : HRService
    {
        public EmployerEmployeeRoleService(HRServiceOptions options)
            : base(options)
        {

        }
    }
}
