using BusinessLogic.ofManagement;
using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;

namespace PlatformManager.Pages
{
    public partial class KamisCode : ComponentBase
    {
        //C:\Users\user\Downloads\농축수산물 품목 및 등급 코드표.xlsx
        private const string KamisCodeFilePath = @"C:\\Users\\user\\Downloads\\농축수산물 품목 및 등급 코드표.xlsx";
        [Inject] public KamisManagement ?KamisManagement { get; set; }
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        public async Task ExcelToDb()
        {
            Application excelApp = new();
            Workbook wb = null;
            wb = excelApp.Workbooks.Open(KamisCodeFilePath);
            await KamisManagement.KamisCodeExcelToDb(wb);
        }
        public async Task Sheet4ToDb()
        {
            Application excelApp = new();
            Workbook wb = null;
            wb = excelApp.Workbooks.Open(KamisCodeFilePath);
            await KamisManagement.KamisCodeSheet4ToDb(wb.Worksheets[4]);
        }
    }
}

