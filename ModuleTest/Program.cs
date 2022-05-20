// See https://aka.ms/new-console-template for more information
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Text.Json;



EmployerWarehouse employerWarehouse = new EmployerWarehouse();
JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
jsonSerializerOptions.WriteIndented = true;

var Value = JsonSerializer.Serialize(employerWarehouse, jsonSerializerOptions);
Console.WriteLine(Value);
