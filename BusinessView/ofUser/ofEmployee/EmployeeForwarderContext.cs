﻿using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser.ofEmployee
{
    public class EmployeeForwarderContext : EmployeeActorContext
    {
        public EmployeeForwarderContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeWCommodity), new EmployeeWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSWCommodity), new EmployeeSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMWCommodity), new EmployeeMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEWCommodity), new EmployeeEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeDividedTag), new EmployeeDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeDotBarcode), new EmployeeDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeIncomingTag), new EmployeeIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeLoadFrame), new EmployeeLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeWorkingDesk), new EmployeeWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(EmployeeTradeCenter), new EmployeeTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeTCommodity), new EmployeeTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSTCommodity), new EmployeeSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMTCommodity), new EmployeeMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeETCommodity), new EmployeeETCommodityService(_options.TradeServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}