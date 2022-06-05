﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(EPCommodity))]
    [HttpDTOService(typeof(PlatformEPCommodityService))]
    public class PlatformEPCommodity : EPCommodityDTO
    {   
       
    }
}
