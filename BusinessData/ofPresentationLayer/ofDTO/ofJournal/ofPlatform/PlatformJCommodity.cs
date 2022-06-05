﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform
{
    [AutoMap(typeof(JCommodity))]
    [HttpDTOService(typeof(PlatformJCommodityService))]
    public class PlatformJCommodity : JCommodityDTO
    {
       
    }
}
