using BusinessLogic.ofManagement;
using BusinessLogic.ofManagement.ofPatform;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text;

namespace PlatformManager.Pages
{
    public partial class HsDataView : ComponentBase
    {
        //@"C:\Users\user\Desktop\HS별 관세율표"
        private const string HsFilePath = @"C:\\Users\\user\\Desktop\\HS별 관세율표.csv";
        [Inject] public IWebHostEnvironment? Environment { get; set; }
        [Inject] public HsCodeManagement HsCodeManagement { get; set; }
        [Inject] public PlatFormManagement? PlatFormManagement { get; set; }
        protected override void OnInitialized()
        {     
        }
        public async Task ExcelToDb()
        {
            if(HsCodeManagement != null)
            {
                Application excelApp = new();
                Workbook wb = null;
                Worksheet ws = null;
                wb = excelApp.Workbooks.Open(HsFilePath);
                // 첫번째 Worksheet
                if(wb != null)
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
