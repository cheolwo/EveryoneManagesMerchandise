using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace ModuleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadExcelData();
            Console.WriteLine("Hello World!");
        }
        public static void ReadExcelData()
        {
            Application excelApp = null;
            Workbook wb = null;
            Worksheet ws = null;
            try
            {
                excelApp = new Application();

                // 엑셀 파일 열기
                wb = excelApp.Workbooks.Open(@"C:\Users\user\Desktop\HS별 관세율표");

                // 첫번째 Worksheet
                ws = wb.Worksheets.get_Item(1) as Worksheet;

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
                var Part1 = Insert0ToFirstHsCodePart(data);
                foreach (var HsCode in Part1)
                {
                }
                    wb.Close(true);
                excelApp.Quit();
            }
            finally
            {
            }
        }
        static private List<string> Insert0ToFirstHsCodePart(object[,] data)
        {
            List<string> vs = new List<string>();
            for (int i = 2; i <= 1620; i++)
            {
                string HsCode = data[i, 4].ToString();
                HsCode = HsCode.Insert(0, "0");
                vs.Add(HsCode);
            }
            return vs;
        }
    }
}
