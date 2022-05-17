using Microsoft.AspNetCore.Components.Forms;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofCommon.ofInterface
{
    public interface IEntityDTO
    {
        bool EqualsById(object obj);
        void BrowserFileToDTO(IList<IBrowserFile> files, EntityDTO entityDTO);
    }
}