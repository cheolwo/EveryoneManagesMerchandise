// See https://aka.ms/new-console-template for more information
using BusinessView.ofActorService;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofUser;

EmployerEntity employerEntity = new EmployerEntity();
var props = typeof(EmployerEntity).GetProperties();
foreach(var prop in props)
{
    Console.WriteLine(prop.PropertyType);
}
