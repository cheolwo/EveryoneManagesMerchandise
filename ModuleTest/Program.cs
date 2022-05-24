// See https://aka.ms/new-console-template for more information
using AutoMapper;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofExternal.ofSearchingService;
using BusinessView.ofCommon.ofServices;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofGeneric;
using System.Text.Json;
JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
jsonSerializerOptions.WriteIndented = true;
Warehouse warehouse = new Warehouse();
warehouse.LoginId = "123";
warehouse.Name = "박철우";
var modelvalue = "{\"wCommodities\":[],\"ewCommodities\":[],\"mwCommodities\":[],\"swCommodities\":[],\"loadFrames\":[],\"dotBarcodes\":[],\"workingDesks\":[],\"dividedTags\":[],\"incomingTags\":[],\"loginId\":\"asd\",\"password\":\"fDF\",\"failLogin\":0,\"address\":\"ASDF\",\"countryCode\":\"ASDF\",\"phoneNumber\":\"ASDF\",\"faxNumber\":\"FASDFADFS\",\"commodities\":[],\"eStatuses\":[],\"mStatuses\":[],\"sStatuses\":[],\"centerCards\":[],\"centerMacAddresses\":[],\"centerIPAddresses\":[],\"centerRoles\":[],\"id\":\"W-36\",\"code\":\"Null\",\"name\":\"ASDFASD\",\"container\":\"Null\",\"createTime\":\"2022-05-24T01:23:58.7164655+09:00\",\"userId\":\"Null\",\"changedUsers\":[],\"imageofInfos\":[],\"docs\":[]}";
var value = JsonSerializer.Deserialize<Warehouse>(modelvalue);
var serialvalue = JsonSerializer.Serialize(warehouse, jsonSerializerOptions);
Console.WriteLine(serialvalue);
var deserialvalue = JsonSerializer.Deserialize<Warehouse>(serialvalue);
Console.WriteLine(deserialvalue.LoginId);
Console.WriteLine(value);
var configuration = new MapperConfiguration(cfg => cfg.AddMaps("BusinessView"));
var mapper = new Mapper(configuration);


public class Rootobject
{
    public Results results { get; set; }
}

public class Results
{
    public Common common { get; set; }
    public Juso[] juso { get; set; }
}

public class Common
{
    public string errorMessage { get; set; }
    public string countPerPage { get; set; }
    public string totalCount { get; set; }
    public string errorCode { get; set; }
    public string currentPage { get; set; }
}

public class Juso
{
    public string detBdNmList { get; set; }
    public string engAddr { get; set; }
    public string rn { get; set; }
    public string emdNm { get; set; }
    public string zipNo { get; set; }
    public string roadAddrPart2 { get; set; }
    public string emdNo { get; set; }
    public string sggNm { get; set; }
    public string jibunAddr { get; set; }
    public string siNm { get; set; }
    public string roadAddrPart1 { get; set; }
    public string bdNm { get; set; }
    public string admCd { get; set; }
    public string udrtYn { get; set; }
    public string lnbrMnnm { get; set; }
    public string roadAddr { get; set; }
    public string lnbrSlno { get; set; }
    public string buldMnnm { get; set; }
    public string bdKdcd { get; set; }
    public string liNm { get; set; }
    public string rnMgtSn { get; set; }
    public string mtYn { get; set; }
    public string bdMgtSn { get; set; }
    public string buldSlno { get; set; }
}
