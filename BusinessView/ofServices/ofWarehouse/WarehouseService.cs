namespace BusinessView.ofCommon.ofServices
{
    public class WarehouseServiceOptions : DTOServiceOptions
    {

    }
    public class WarehouseService : DTOService
    {
        protected WarehouseServiceOptions _WarehouseServiceOptions;
        public WarehouseService(WarehouseServiceOptions options)
                :base(options)
        {
            _WarehouseServiceOptions = options;
            if (_WarehouseServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.WarehouseWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
