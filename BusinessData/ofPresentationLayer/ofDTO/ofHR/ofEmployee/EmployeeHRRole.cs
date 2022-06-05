﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HRRole))]
    [HttpDTOService(typeof(EmployeeEmployeeRoleService))]
    public class EmployeeHRRole : HRRoleDTO
    {
       
    }
}