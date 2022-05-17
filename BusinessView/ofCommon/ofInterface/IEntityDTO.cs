using System.Reflection;
using System.Collections;
using System.IO;

namespace BusinessView.ofCommon.ofInterface
{
    public interface IEntityDTO
    {
        bool EqualsById(object obj);
        void BrowserFileToDTO(IList<IBrowserFile> files, EntityDTO entityDTO);
    }
}