using BusinessData.ofCommon.ofKapt;
using BusinessLogic.ofExternalManager.ofKApt;
using Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;

namespace BusinessLogic.ofExternalManager.ofManagerment.ofPlatform
{
    public class KAptManagement
    {
        private readonly KAptBasicInfoManager _KAptBasicInfoManager;
        public KAptManagement(KAptBasicInfoManager kAptAPIInfoManager)
        {
            _KAptBasicInfoManager = kAptAPIInfoManager;
        }
        public async Task KAptExcelToDb(Workbook wb)
        {
            Worksheet ws1 = null;
            if (wb != null)
            {
                ws1 = wb.Worksheets.get_Item(1) as Worksheet;
            }
            if (ws1 != null) { await KAptSheet1ToDb(ws1); }
        }
        private async Task KAptSheet1ToDb(Worksheet ws)
        {
            KAptBasicInfo KAptBasicInfo = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {                 
                    KAptBasicInfo.County = data[i, 1]?.ToString() ?? "";
                    KAptBasicInfo.City= data[i, 2]?.ToString() ?? "";
                    KAptBasicInfo.Town = data[i, 3]?.ToString() ?? "";
                    KAptBasicInfo.Viliage = data[i, 4]?.ToString() ?? "";
                    KAptBasicInfo.Id = data[i, 5]?.ToString() ?? "";
                    KAptBasicInfo.Name = data[i, 6]?.ToString() ?? "";
                    KAptBasicInfo.Classification = data[i, 7]?.ToString() ?? "";
                    KAptBasicInfo.StreetAddress = data[i, 8]?.ToString() ?? "";
                    KAptBasicInfo.RegalAddress = data[i, 9]?.ToString() ?? "";
                    KAptBasicInfo.SalesType = data[i, 10]?.ToString() ?? "";
                    KAptBasicInfo.DateofApprovalForUse = data[i, 11]?.ToString() ?? "";
                    KAptBasicInfo.NumberofApt = data[i, 12]?.ToString() ?? "";
                    KAptBasicInfo.NumberofHouseHolds = data[i, 13]?.ToString() ?? "";
                    KAptBasicInfo.Managementmethod = data[i, 14]?.ToString() ?? "";
                    KAptBasicInfo.Housemanager = data[i, 19]?.ToString() ?? "";
                    KAptBasicInfo.Managementmanagementmethod = data[i, 20]?.ToString() ?? "";
                    KAptBasicInfo.Generalmanagementpersonnel = data[i, 21]?.ToString() ?? "";
                    KAptBasicInfo.GuardManagement = data[i, 22]?.ToString() ?? "";
                    KAptBasicInfo.GuardNumber = data[i, 23]?.ToString() ?? "";
                    KAptBasicInfo.GuardManager = data[i, 24]?.ToString() ?? "";
                    KAptBasicInfo.Numberofparkingspaces = data[i, 45]?.ToString() ?? "";
                    KAptBasicInfo.Numberofundergroundparkingspaces = data[i, 46]?.ToString() ?? "";
                    KAptBasicInfo.ManagementOfficeAddress = data[i, 49]?.ToString() ?? "";
                    KAptBasicInfo.ManagementOfficePhoneNumber = data[i, 50]?.ToString() ?? "";
                    KAptBasicInfo.ManagementOfficeFax = data[i, 51]?.ToString() ?? "";
                    KAptBasicInfo.WelfareFacility = data[i, 52]?.ToString() ?? "";                   
                    await _KAptBasicInfoManager.CreateAsync(KAptBasicInfo);
                    i++;
                }
            }
            catch
            {
                KAptBasicInfo = null;
                return;
            }
        }
    }
}
