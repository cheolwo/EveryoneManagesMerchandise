﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(EOCommodity))]
    [HttpDTOService(typeof(EmployerEOCommodityService))]
    public class EmployerEOCommodity : EOCommodityDTO
    {
      
    }
}
