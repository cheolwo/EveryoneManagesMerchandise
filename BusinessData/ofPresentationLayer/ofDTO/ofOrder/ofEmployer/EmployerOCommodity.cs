﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(OCommodity))]
    [HttpDTOService(typeof(EmployerOCommodityService))]
    public class EmployerOCommodity : OCommodityDTO
    {
        
    }
}
