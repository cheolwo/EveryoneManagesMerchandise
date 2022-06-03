using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessLogic.ofCenterManager.ofGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityDTOManager.ofGeneric
{
    public class CenterDTOManager<DTO, Model> : CenterManager<Model>, ICenterDTOManager<DTO, Model> where DTO : CenterDTO, new() where Model : Center, new()
    {
        private readonly ICenterDTORepository<DTO, Model> _CenterDTODataRepository;
        public CenterDTOManager(ICenterDTORepository<DTO, Model> CenterDataRepository,
            ICenterIdFactory<Model> CenterIdFactory,
            ICenterFileFactory<Model> CenterFileFactory,
            ICenterBlobStorage<Model> CenterBlobStorage,
            DicConvertFactory<Model> DicConvertFactory) : base(CenterDataRepository, CenterIdFactory, CenterFileFactory, CenterBlobStorage, DicConvertFactory)
        {
            _CenterDTODataRepository = CenterDataRepository;
        }
    }
