﻿using BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployee;
using BusinessView.ofGroupOrder.ofEmployee;
using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofUser.ofEmployee
{
    public class EmployeeOrderer : EmployeeActor
    {
        public EmployeeOrderer()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWCommodity), new EmployeeWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeSWCommodity), new EmployeeSWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeMWCommodity), new EmployeeMWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeEWCommodity), new EmployeeEWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeDividedTag), new EmployeeDividedTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeDotBarcode), new EmployeeDotBarcodeService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeIncomingTag), new EmployeeIncomingTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeLoadFrame), new EmployeeLoadFrameService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployeeGOC), new EmployeeGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeGOCC), new EmployeeGOCCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeSGOC), new EmployeeSGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeMGOC), new EmployeeMGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeEGOC), new EmployeeEGOCService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployeeTradeCenter), new EmployeeTradeCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeTCommodity), new EmployeeTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeSTCommodity), new EmployeeSTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeMTCommodity), new EmployeeMTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeETCommodity), new EmployeeETCommodityService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployeeOrderCenter), new EmployeeOrderCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeOCommodity), new EmployeeOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeSOCommodity), new EmployeeSOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeMOCommodity), new EmployeeMOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeEOCommodity), new EmployeeEOCommodityService(e => e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
