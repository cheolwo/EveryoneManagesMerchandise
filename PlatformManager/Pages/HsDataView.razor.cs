using BusinessData.ofCommon.ofHsCode;
using BusinessLogic.ofManagement;
using BusinessLogic.ofManagement.ofPatform;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;

namespace PlatformManager.Pages
{
    public partial class HsDataView : ComponentBase
    {
        //@"C:\Users\user\Desktop\HS별 관세율표"
        //C:\Users\user\Desktop\EveryoneManagesMerchandise\EveryoneManagesMerchandise\PlatformManager\ofFile\HS별 관세율표.csv
        private const string HsFilePath = @"C:\\Users\\user\\Desktop\\HS관세율표.csv";
        [Inject] public IWebHostEnvironment? Environment { get; set; }
        [Inject] public HsCodeManagement ?HsCodeManagement { get; set; }
        [Inject] public EntityManager<PracticalHsCode> ?PracticalHsCodeManager { get; set; }
        [Inject] public PlatFormManagement? PlatFormManagement { get; set; }
        int Count { get; set; }
        protected override async Task OnInitializedAsync()
        {
           Count =  await PracticalHsCodeManager._EntityDataRepository.GetCountAsync();
        }
        public async Task ExcelToDb()
        {
            if (Count == 0)
            {
                if (HsCodeManagement != null)
                {
                    Application excelApp = new();
                    Workbook wb = null;
                    Worksheet ws = null;
                    wb = excelApp.Workbooks.Open(HsFilePath);
                    // 첫번째 Worksheet
                    if (wb != null)
                    {
                        ws = wb.Worksheets.get_Item(1) as Worksheet;
                    }
                    // 현재 Worksheet에서 사용된 Range 전체를 선택
                    Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
                    object[,] data = rng.Value;
                    await HsCodeManagement.HsInfoExcelToDb(data);
                }
            }
        }
    }
}
