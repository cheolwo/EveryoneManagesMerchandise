using BusinessData.ofCommon.ofKapt;
using BusinessLogic.ofManagement;
using BusinessLogic.ofManagement.ofPatform;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace PlatformManager.Pages
{
    public partial class KaptInfo : ComponentBase
    {
        private const string KamisCodeFilePath = @"C:\\Users\\user\\Downloads\\20220103_단지_기본정보.xls";
        [Inject] public KAptManagement ?KAptManagement { get; set; }
        [Inject] public IEntityManager<KAptBasicInfo> ?entityManager { get; set; }
        [Inject] public GOCManagement ?GOCManagement { get; set; } 
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        public async Task KAptBasicInfoToGOCAndWarehouse()
        {
            List<KAptBasicInfo> kAptBasicInfos = await entityManager.GetToListAsync();
            await GOCManagement.CreateGOCAndWarehouseByKAptBasicInfo(kAptBasicInfos);
        }
        public async Task ExcelToDb()
        {
            Application excelApp = new();
            Workbook wb = null;
            wb = excelApp.Workbooks.Open(KamisCodeFilePath);
            await KAptManagement.KAptExcelToDb(wb);
        }
    }
}
