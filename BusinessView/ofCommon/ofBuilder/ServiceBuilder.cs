using BusinessView.ofCommon.ofInterface;
using BusinessView.ofUser.ofCommon.ofInterface;

namespace BusinessView.ofUser.ofCommon
{
    public class ServiceBuilder
    {
        private Dictionary<IViewModel, IViewService> DicViewService { get; set; }
        public ServiceBuilder()
        {
            DicViewService = new();
        }
        // Using // Actor : virtual void OnConfigureViewService(ServiceBuilder serviceBuilder)
        public void Add(IViewModel viewModel, IViewService viewService)
        {
            DicViewService.Add(viewModel, viewService);
        }
        // Using // Actor : virtaul Add<T> (T t) where T : IViewModel
        // This Method Purpose is to Get ViewService In Dictionay of ViewServices
        public IViewService Get(IViewModel viewModel)
        {
            return DicViewService[viewModel]
                   ?? throw new ArgumentNullException("Not Include ViewService For ViewModel");
        }
    }
}
