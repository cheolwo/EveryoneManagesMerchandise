﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(SMCommodity))]
    [HttpDTOService(typeof(EmployerSMCommodityService))]
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSMCommodity : SMCommodityDTO
    {
       
    }
}
