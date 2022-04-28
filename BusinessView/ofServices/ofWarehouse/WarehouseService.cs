namespace BusinessView.ofCommon.ofServices
{
    public class WarehouseServiceOptions : DTOServiceOptions
    {

    }
    public class WarehouseService : DTOService
    {
        public WarehouseService(Action<DTOServiceOptions> options)
        {
            options.Invoke(_options);
            if (_options.IsDevelopment)
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
