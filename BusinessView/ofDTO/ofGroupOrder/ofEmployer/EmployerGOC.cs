﻿using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofGroupOrder;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData;

namespace BusinessView.ofDTO.ofGroupOrder.ofEmployer
{
    [AutoMap(typeof(GOC))]
    public class EmployerGOC : GOCDTO
    {
    }
}
