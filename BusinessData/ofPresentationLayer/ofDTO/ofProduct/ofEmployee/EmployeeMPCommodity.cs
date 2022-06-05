﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(MPCommodity))]
    [HttpDTOService(typeof(EmployeeMPCommodityService))]
    public class EmployeeMPCommodity : MPCommodityDTO
    {   
       
    }
}
