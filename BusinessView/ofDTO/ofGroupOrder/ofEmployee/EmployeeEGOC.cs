using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using FluentValidation;
using FluentValidation.Internal;
using BusinessData.ofGroupOrder;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData;

namespace BusinessView.ofDTO.ofGroupOrder.ofEmployee
{
    [AutoMap(typeof(EGOC))]
    public class EmployeeEGOC : EmployeeEStatus
    {
    }
}
