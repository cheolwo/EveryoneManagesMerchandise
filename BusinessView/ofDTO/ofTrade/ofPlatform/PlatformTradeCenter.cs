﻿using AutoMapper;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofDTO.ofCommon.ofTrade;
namespace BusinessView.ofTrade.ofPlatform
{
    [AutoMap(typeof(TradeCenter))]
    public class PlatformTradeCenter : TradeCenterDTO
    {
       
    }
}
