using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;

namespace PlatformManager.Pages
{
    public partial class KamisCode : ComponentBase
    {
        //C:\Users\user\Downloads\농축수산물 품목 및 등급 코드표.xlsx
        private const string KamisCodeFilePath = @"C:\\Users\\user\\Downloads\\농축수산물 품목 및 등급 코드표.xlsx";
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        public void ExcelToDb()
        {
            Application excelApp = new();
            Workbook wb = null;
            Worksheet ws1 = null;
            Worksheet ws2 = null;
            Worksheet ws3 = null;
            Worksheet ws4 = null;
            Worksheet ws5 = null;
            wb = excelApp.Workbooks.Open(KamisCodeFilePath);
            // 첫번째 Worksheet
            if (wb != null)
            {
                ws1 = wb.Worksheets.get_Item(1) as Worksheet;
                ws2 = wb.Worksheets.get_Item(2) as Worksheet;
                ws3 = wb.Worksheets.get_Item(3) as Worksheet;
                ws4 = wb.Worksheets.get_Item(4) as Worksheet;
                ws5 = wb.Worksheets.get_Item(5) as Worksheet;
            }
            // 현재 Worksheet에서 사용된 Range 전체를 선택
            Microsoft.Office.Interop.Excel.Range rng1 = ws1.UsedRange;
            Microsoft.Office.Interop.Excel.Range rng2 = ws2.UsedRange;
            Microsoft.Office.Interop.Excel.Range rng3 = ws3.UsedRange;
            Microsoft.Office.Interop.Excel.Range rng4 = ws4.UsedRange;
            Microsoft.Office.Interop.Excel.Range rng5 = ws5.UsedRange;

            object[,] data1 = rng1.Value; //1~7, 1~2
            object[,] data2 = rng2.Value;//1~88, 1~3
            object[,] data3 = rng3.Value;//1~205, 1~16
            object[,] data4 = rng4.Value;//1~205, 1~18
            object[,] data5 = rng5.Value;//1~21. 1~4
        }
    }
}

