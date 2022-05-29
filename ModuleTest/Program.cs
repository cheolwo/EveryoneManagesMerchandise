// See https://aka.ms/new-console-template for more information
using AutoMapper;
using BusinessData.ofWarehouse.Model;
using System.Reflection;
using System.Text;
using System.Text.Json;
//JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
//jsonSerializerOptions.WriteIndented = true;
//Warehouse warehouse = new Warehouse();
//warehouse.LoginId = "123";
//warehouse.Name = "박철우";
//var modelvalue = "{\"wCommodities\":[],\"ewCommodities\":[],\"mwCommodities\":[],\"swCommodities\":[],\"loadFrames\":[],\"dotBarcodes\":[],\"workingDesks\":[],\"dividedTags\":[],\"incomingTags\":[],\"loginId\":\"asd\",\"password\":\"fDF\",\"failLogin\":0,\"address\":\"ASDF\",\"countryCode\":\"ASDF\",\"phoneNumber\":\"ASDF\",\"faxNumber\":\"FASDFADFS\",\"commodities\":[],\"eStatuses\":[],\"mStatuses\":[],\"sStatuses\":[],\"centerCards\":[],\"centerMacAddresses\":[],\"centerIPAddresses\":[],\"centerRoles\":[],\"id\":\"W-36\",\"code\":\"Null\",\"name\":\"ASDFASD\",\"container\":\"Null\",\"createTime\":\"2022-05-24T01:23:58.7164655+09:00\",\"userId\":\"Null\",\"changedUsers\":[],\"imageofInfos\":[],\"docs\":[]}";
//var value = JsonSerializer.Deserialize<Warehouse>(modelvalue);
//var serialvalue = JsonSerializer.Serialize(warehouse, jsonSerializerOptions);
//Console.WriteLine(serialvalue);
//var deserialvalue = JsonSerializer.Deserialize<Warehouse>(serialvalue);
//Console.WriteLine(deserialvalue.LoginId);
//Console.WriteLine(value);
//var configuration = new MapperConfiguration(cfg => cfg.AddMaps("BusinessView"));
//var mapper = new Mapper(configuration);

SpinLockSample1();
Assembly assembly = Assembly.Load("BusinessView");
var pubTypesQuery = from type in assembly.GetTypes()
                    where type.IsPublic
                    from method in type.GetMethods()
                    where method.ReturnType.IsArray == true
                        || (method.ReturnType.GetInterface(
                            typeof(System.Collections.Generic.IEnumerable<>).FullName) != null
                        && method.ReturnType.FullName != "System.String")
                    group method.ToString() by type.ToString();

foreach (var groupOfMethods in pubTypesQuery)
{
    Console.WriteLine("Type: {0}", groupOfMethods.Key);
    foreach (var method in groupOfMethods)
    {
        Console.WriteLine("  {0}", method);
    }
}

Console.WriteLine("Press any key to exit... ");
Console.ReadKey();
static void SpinLockSample1()
{
    SpinLock sl = new SpinLock();

    StringBuilder sb = new StringBuilder();

    // Action taken by each parallel job.
    // Append to the StringBuilder 10000 times, protecting
    // access to sb with a SpinLock.
    Action action = () =>
    {
        //bool gotLock = false;
        for (int i = 0; i < 10000; i++)
        {
            //gotLock = false;
            try
            {
                //sl.Enter(ref gotLock);
                sb.Append((i % 10).ToString());
            }
            finally
            {
                // Only give up the lock if you actually acquired it
                //if (gotLock) sl.Exit();
            }
        }
    };

    // Invoke 3 concurrent instances of the action above
    Parallel.Invoke(action, action, action);

    // Check/Show the results
    Console.WriteLine("sb.Length = {0} (should be 30000)", sb.Length);
    Console.WriteLine("number of occurrences of '5' in sb: {0} (should be 3000)",
        sb.ToString().Where(c => (c == '5')).Count());
}

static void SpinLockSample2()
{
    // Instantiate a SpinLock
    SpinLock sl = new SpinLock();

    // These MRESs help to sequence the two jobs below
    ManualResetEventSlim mre1 = new ManualResetEventSlim(false);
    ManualResetEventSlim mre2 = new ManualResetEventSlim(false);
    bool lockTaken = false;
    Task taskB = Task.Factory.StartNew(() =>
    {
        mre1.Wait(); // wait for Task A to signal me
        Console.WriteLine("Task B: sl.IsHeld = {0} (should be true)", sl.IsHeld);
        Console.WriteLine("Task B: sl.IsHeldByCurrentThread = {0} (should be false)", sl.IsHeldByCurrentThread);
        Console.WriteLine("Task B: sl.IsThreadOwnerTrackingEnabled = {0} (should be true)", sl.IsThreadOwnerTrackingEnabled);

        try
        {
            sl.Exit();
            Console.WriteLine("Task B: Released sl, should not have been able to!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Task B: sl.Exit resulted in exception, as expected: {0}", e.Message);
        }

        mre2.Set(); // Signal Task A to exit the SpinLock
    });

    Task taskA = Task.Factory.StartNew(() =>
    {
        try
        {
            sl.Enter(ref lockTaken);
            Console.WriteLine("Task A: entered SpinLock");
            mre1.Set(); // Signal Task B to commence with its logic

            // Wait for Task B to complete its logic
            // (Normally, you would not want to perform such a potentially
            // heavyweight operation while holding a SpinLock, but we do it
            // here to more effectively show off SpinLock properties in
            // taskB.)
            mre2.Wait();
        }
        finally
        {
            if (lockTaken) sl.Exit();
        }
    });
    taskA.Start();
    

    // Wait for task completion and clean up
    Task.WaitAll(taskA, taskB);
    mre1.Dispose();
    mre2.Dispose();
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
