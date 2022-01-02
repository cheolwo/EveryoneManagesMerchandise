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
        private const string HsFilePath = @"C:\\Users\\user\\Desktop\\개발\\EveryoneManagesMerchandise\\PlatformManager\\ofFile\\HS별 관세율표.csv";
        [Inject] public IWebHostEnvironment? Environment { get; set; }
        [Inject] public PlatFormManagement? PlatFormManagement { get; set; }
        protected override void OnInitialized()
        {     
        }
        public async Task ExcelToDb()
        {
            if(PlatFormManagement != null)
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

                // 현재 Worksheet에서 일부 범위만 선택
                // Excel.Range rng = ws.Range[ws.Cells[2, 1], ws.Cells[5, 3]];

                // Range 데이타를 배열 (One-based array)로
                // 행 17697 : Column : 147
                // 세번 : 1, 4
                // 영문품명 : 1, 5
                // 한글품명 : 1, 6
                // 중량단위 : 1 , 7
                // 수량단위 : 1, 8
                // 나머지는 세율
                // 세번 값 시작 : 2,4
                // 제1류 시작 : 2, 4 끝 1620, 4          
                object[,] data = rng.Value;
                await PlatFormManagement.ExcelHsTaxInfoToDb(data);
                // 첫번째 Worksheet
                //ws = wb.Worksheets.get_Item(1) as Worksheet;
                //await PlatFormManagement.ExcelHsTaxInfoToDb(HsExcelTaxInfo);
            }         
        }
    }
}
