// See https://aka.ms/new-console-template for more information
using BusinessLogic.ofExternal.ofSearchingService;

KoreaSearchingAddressService KoreaSearchingAddressService = new();
var addresses = await KoreaSearchingAddressService.GetAddressByKeyword("아차산로");
foreach (var addr in addresses)
{
    Console.WriteLine(addr);
}


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
