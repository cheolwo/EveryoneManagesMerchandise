﻿using BusinessData;
using BusinessView.ofExternal.ofSearchingService;

namespace BusinessView.ofDTO.ofCommon.ofPlatform
{
    // 인터페이스로 확장하는 형태가 만들어지겠다.
    public interface IPlatformEntity 
    {
    }
    public interface IPlatformCenter : IPlatformEntity
    {

    }
    public interface IPlatformCommodity : IPlatformEntity
    {

    }
    public interface IPlatformStatus : IPlatformEntity
    {

    }
    public interface IPlatformSStatus : IPlatformStatus
    {

    }
    public interface IPlatformMStatus : IPlatformStatus
    {

    }
    public interface IPlatformEStatus : IPlatformStatus
    {

    }
    // PlatformCenter는 PlatformEntity 이면서 CenterDTO 라는 걸 표현하고 싶은데.
    public class PlatformCenter : CenterDTO, IPlatformCenter
    {
      
    }
    public class PlatformCommodity : CommodityDTO, IPlatformCommodity
    {

    }
    public class PlatformStatus : StatusDTO, IPlatformStatus
    {
      
    }
    public class PlatformSStatus : PlatformStatus, IPlatformSStatus
    {
       
    }
    public class PlatformMStatus : PlatformStatus, IPlatformMStatus
    {
        
    }
    public class PlatformEStatus : PlatformStatus, IPlatformEStatus
    {
       
    }
}
