using BusinessData.ofPresentationLayer.ofDTOServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofViewContext
{
    public class ViewContext
    {
        protected ViewModelBuilder viewModelBuilder = new();
        public ViewContext()
        {

        }
    }
    /// <summary>
    /// DTO 에 대한
    /// </summary>
    public class ViewModelBuilder
    {
        private Dictionary<int, > DicViewService { get; set; }
        public ViewModelBuilder()
        {
            DicViewService = new();
        }
        // Using // Actor : virtual void OnConfigureViewService(ServiceBuilder serviceBuilder)
        public void Add(string nameofDTO, DTOService viewService)
        {
            DicViewService.Add(nameofDTO.GetHashCode(), viewService);
        }
        // Using // Actor : virtaul Add<T> (T t) where T : IViewModel
        // This Method Purpose is to Get ViewService In Dictionay of ViewServices
        public DTOService Get(string nameofDTO)
        {
            return DicViewService[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewService For ViewModel");
        }
    }
}
