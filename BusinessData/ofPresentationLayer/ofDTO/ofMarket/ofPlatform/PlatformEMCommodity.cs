﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(EMCommodity))]
    [HttpDTOService(typeof(EmployerEMCommodityService))]
    public class PlatformEMCommodity : EMCommodityDTO
    {
        
    }
}
