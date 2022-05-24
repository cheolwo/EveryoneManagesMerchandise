﻿using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRRole))]
    public class EmployerHRRole : EmployerEntity
    {
        [Get]public string? DetailName {get; set;}
        public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}