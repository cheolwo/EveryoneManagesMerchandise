﻿using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessLogic.ofEntityManager.ofGeneric;

namespace BusinessLogic.ofEntityDTOManager.ofGeneric
{
    public interface ICenterDTOManager<DTO, Model> : ICenterManager<Model>
        where DTO : CenterDTO, new()
        where Model : Center, new()
    {
    }
}