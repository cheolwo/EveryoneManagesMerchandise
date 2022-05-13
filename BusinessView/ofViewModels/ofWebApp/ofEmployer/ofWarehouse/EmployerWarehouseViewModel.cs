using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Reflection;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerWarehouseViewModel : BaseViewModel
    {
        protected readonly IActorViewService<EmployerWarehouse> _actorViewService;
        private readonly ILogger<EmployerWarehouseViewModel> _logger;
        public EmployerWarehouseViewModel(IActorViewService<EmployerWarehouse> actorViewService,
            ILogger<EmployerWarehouseViewModel> logger)
        {
            _actorViewService = actorViewService;
            _logger = logger;
            TableProperties = employerWarehouse.GetToDictionaryforClassifiedPropertyByAttribute(typeof(EmployerWarehouse));
        }
        private EmployerWarehouse employerWarehouse = new();
        public EmployerWarehouse EmployeeWarehouse
        {
            get => employerWarehouse;
            set
            {
                employerWarehouse = value;
                OnPropertyChanged();
            }
        }
        private List<EmployerWarehouse> employerWarehouses = new();
        public List<EmployerWarehouse> EmployerWarehouses
        {
            get => employerWarehouses;
            set
            {
                employerWarehouses = value;
                OnPropertyChanged();
            }
        }
        // Dictionary String is Table Meta Info
        private Dictionary<string, List<PropertyInfo>> tableProperties = new();
        public Dictionary<string, List<PropertyInfo>> TableProperties
        {
            get => tableProperties;
            set
            {
                tableProperties = value;
                OnPropertyChanged();
            }
        }
        public async Task LoadData()
        {
            var ServerDatas = await _actorViewService.Get();
            foreach(var Data in ServerDatas)
            {
                employerWarehouses.Add(Data);
            }
            _logger.LogInformation(nameof(LoadData));
            OnPropertyChanged();
        }
        public async Task Add(EmployerWarehouse employerWarehouse)
        {
            try
            {
                var PostEmployerWarehouse = await _actorViewService.Post(employerWarehouse);
                employerWarehouses.Add(PostEmployerWarehouse);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                OnPropertyChanged();
                _logger.LogInformation(nameof(Add));
            }
        }
        public async Task Update(string id, EmployerWarehouse employerWarehouse)
        {
            try
            {
                var UpdateEmployerWarehouse = await _actorViewService.Update(id, employerWarehouse);
                employerWarehouses.Remove(employerWarehouse);
                employerWarehouses.Add(UpdateEmployerWarehouse);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                OnPropertyChanged();
                _logger.LogInformation(nameof(Update));
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                await _actorViewService.Delete(id);
                var FindEmployerWarehouse = employerWarehouses.Find(e => e.Equals(id));
                if(FindEmployerWarehouse != null)
                {
                    employerWarehouses.Remove(FindEmployerWarehouse);
                }
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message);
            }
            finally
            {
                OnPropertyChanged();
                _logger.LogInformation(nameof(Delete));
            }
        }
    }
}
