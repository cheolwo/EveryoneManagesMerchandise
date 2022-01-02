using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManagement
{
    //// Range 데이타를 배열 (One-based array)로
                // 행 17697 : Column : 147
                // 세번 : 1, 4
                // 영문품명 : 1, 5
                // 한글품명 : 1, 6
                // 중량단위 : 1 , 7
                // 수량단위 : 1, 8
                // 나머지는 세율
                // 세번 값 시작 : 2,4
                // 제1류 시작 : 2, 4 끝 1620, 4   
    public enum HsExcelFileMetaInfo {EndRow = 17697, EndCoulumn = 147, 
    UsName = 5, KoName = 6, WeightUnit = 7, QuantityUnit = 8, 
    Part1EndRow = 1620,
    CheckStartRow = 2,
    HSColumn = 4,
    BasicTaxColumn = 10,
    AgreetMentTaxStartColumn = 11
    }
    public interface IHsCodeManagement
    {
        void HdInfoExcelToDb(Object[,] dataSet);
    }
    delegate Task WeightHsFuction(Object[,] dataSet, int Row);
    public class HsCodeManagement : IHsCodeManagement
    {
        private readonly CoutntryManager _coutntryManager;
        private readonly HsCodePartManager _hsCodePartMangaer;
        private readonly SubPartofHsCodeManager _subPartofHsCodeManager;
        private readonly PracticalHsCodeManager _practicalHsCodeManager;
        private readonly SubPracticalHsCodeManager _subPracticalHsCodeManager;
        private readonly DetailPracticalHsCodeManager _detailPracticalHsCodeManager;
        private readonly ClearanceofInfoofHsCode _clearanceofInfoofHsCodeManager;
        private List<PracticalHsCode> practicalHsCodes = new();
        private List<SubPracticalHsCode> subPracticalHsCodes = new();
        private Dictionary<int, WeightHsFuction> SetWeightFuction = new();
        
        // 신경강도확인
        // 상기 강도에 따른 함수 실행
        public HsCodeManagement(CoutntryManager coutntryManager, HsCodePartManager hsCodePartManager,
                        SubPartofHsCodeManager subPartofHsCodeManager, PracticalHsCodeManager practicalHsCodeManager,
                        SubPracticalHsCodeManager subPracticalHsCodeManager, DetailPracticalHsCodeManager detailPracticalHsCodeManager,
                        ClearanceInfoofHsCodeManager clearanceInfoofHsCodeManager)
        {
            _coutntryManager = coutntryManager;
            _hsCodePartMangaer = hsCodePartManager;
            _subPartofHsCodeManager = subPartofHsCodeManager;
            _practicalHsCodeManager = practicalHsCodeManager;
            _subPracticalHsCodeManager = subPracticalHsCodeManager;
            _detailPracticalHsCodeManager = detailPracticalHsCodeManager;
            _clearanceofInfoofHsCodeManager = clearanceInfoofHsCodeManager;
            SetWeightFuction.Add(4, Hs4Fuction);
            SetWeightFuction.Add(5, Hs5Or6Fuction);
            SetWeightFuction.Add(7, Hs7Fuction);
        }
        public void HdInfoExcelToDb(Object[,] dataSet)
        {
            string HsCode = null;
            int Weight = 0;
            for(int Row = HsExcelFileMetaInfo.CheckStartRow; Row <= HsExcelFileMetaInfo.EndRow; Row++)
            {
                HsCode = dataSet[Row, HsExcelFileMetaInfo.HSColumn].ToString();
                if(CheckPart1ofHs(Row))
                {
                    HsCode = Append0ToHsCode(HsCode);
                }
                Weight = WeightCheck(HsCode);
                SetWeightFuction[Weight](dataSet, Row);
            }
        }
        private string Append0ToHsCode(string HsCode)
        {
            return "0" +HsCode;
        }
        private bool CheckPart1ofHs(int Row)
        {
            if(Row <= (int)HsExcelFileMetaInfo.Part1EndRow)
            {
                return true;
            }
            else { return false; }
        }
        private int WeightCheck(string HsCode)
        {
            int Length = HsCode.GetLength();
            if(Length >= 4 && Length < 5)
            {
                return 4;
            } 
            if(Length >= 5 && Length < 7)
            {
                return 5;
            }            
            if(Length >= 7)
            {
                return 7;
            }
        }
        //// Range 데이타를 배열 (One-based array)로
                // 행 17697 : Column : 147
                // 세번 : 1, 4
                // 영문품명 : 1, 5
                // 한글품명 : 1, 6
                // 중량단위 : 1 , 7
                // 수량단위 : 1, 8
                // 나머지는 세율
                // 세번 값 시작 : 2,4
                // 제1류 시작 : 2, 4 끝 1620, 4  
        private async Task Hs4Fuction(Object[,] dataSet, int Row)
        {
            PracticalHsCode practicalHsCode = new();
            practicalHsCode.KoName = dataSet[Row, HsExcelFileMetaInfo.KoName].ToString();
            practicalHsCode.UsName = dataSet[Row, HsExcelFileMetaInfo.UsName].ToString();
            practicalHsCode.Name = dataSet[Row, HsExcelFileMetaInfo.HSColumn].ToString();
            practicalHsCode = await _practicalHsCodeManager.CreateAsync(practicalHsCode);
            practicalHsCodes.Add(practicalHsCode);
        }
        private string Get4Length(string HsCode)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(HsCode[0]);
            stringBuilder.Append(HsCode[1]);
            stringBuilder.Append(HsCode[2]);
            stringBuilder.Append(HsCode[3]);
            return stringBuilder.ToString();
        }
        private async Task Hs5Or6Fuction(Object[,] dataSet, int Row)
        {
            SubPracticalHsCode subPracticalHsCode = new();
            subPracticalHsCode.KoName = dataSet[Row, HsExcelFileMetaInfo.KoName].ToString();
            subPracticalHsCode.UsName = dataSet[Row, HsExcelFileMetaInfo.UsName].ToString();
            subPracticalHsCode.Name = dataSet[Row, HsExcelFileMetaInfo.HSColumn].ToString();
            string HsCode4 = Get4Length(subPracticalHsCodes.Name);
            var ForeignHsCode = practicalHsCodes.FirstOrDefault(e=>e.Name.Eqauls(HsCode4));
            subPracticalHsCode.PracticalHsCode = ForeignHsCode;
            subPracticalHsCode = await _subPartofHsCodeManager.CreateAsync(subPracticalHsCode);
            subPracticalHsCodes.Add(subPracticalHsCode);
        }
        private string Get6Length(string HsCode)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(HsCode[0]);
            stringBuilder.Append(HsCode[1]);
            stringBuilder.Append(HsCode[2]);
            stringBuilder.Append(HsCode[3]);
            stringBuilder.Append(HsCode[4]);
            stringBuilder.Append(HsCode[5]);
            return stringBuilder.ToString();
        }
        private async Task Hs7Fuction(Object[,] dataSet, int Row)
        {
            DetailPracticalHsCode detailPracticalHsCode = new();
            detailPracticalHsCode.KoName = dataSet[Row, HsExcelFileMetaInfo.KoName].ToString();
            detailPracticalHsCode.UsName = dataSet[Row, HsExcelFileMetaInfo.UsName].ToString();
            detailPracticalHsCode.Name = dataSet[Row, HsExcelFileMetaInfo.HSColumn].ToString();
            string HsCode6 = Get6Length(detailPracticalHsCode.Name);
            var ForeignHsCode = subPracticalHsCodes.FirstOrDefault(e=>e.Name.Eqauls(HsCode6)); 
            if(ForeignHsCode != null)
            {
                detailPracticalHsCode.SubPracticalHsCode = ForeignHsCode;
            }
            detailPracticalHsCode = await _detailPracticalHsCodeManager.CreateAsync(detailPracticalHsCode);
            
            ClearanceInfoofHsCode clearanceInfoofHsCode = new();
            clearanceInfoofHsCode.DetailPracticalHsCode = detailPracticalHsCode;
            clearanceInfoofHsCode.AgreetMentTaxRates = new();
            clearanceInfoofHsCode.BasicTaxRate = dataSet[Row, HsExcelFileMetaInfo.BasicTaxColumn].ToString();
            for(int Column = (int)HsExcelFileMetaInfo.AgreetMentTaxStartColumn; Column <= (int)HsExcelFileMetaInfo.EndCoulumn; Column++)
            {
                if(dataSet[Row, Column] != null)
                {
                    clearanceInfoofHsCode.AgreetMentTaxRates.Add(new (dataSet[1, Column].ToString(), dataSet[Row, Column].ToString()));
                }
            }
            clearanceInfoofHsCode = await _clearanceofInfoofHsCodeManager.CreateAsync(clearanceInfoofHsCode);
        }
    }
}
