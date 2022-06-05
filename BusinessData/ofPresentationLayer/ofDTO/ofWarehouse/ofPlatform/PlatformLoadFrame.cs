﻿using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
l;

namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(LoadFrame))]
    [HttpDTOService(typeof(PlatformLoadFrameService))]
    public class PlatformLoadFrame : LoadFrameDTO
    {
        
    }
}
