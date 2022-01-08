using BusinessData.ofCommon.ofHsCode;
using BusinessLoogic.ofManager.ofHsCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManagement
{
    //// Range 데이타를 배열 (One-based array)로
                // 행 17967 : Column : 147
                // 세번 : 1, 4
                // 영문품명 : 1, 5
                // 한글품명 : 1, 6
                // 중량단위 : 1 , 7
                // 수량단위 : 1, 8
                // 나머지는 세율
                // 세번 값 시작 : 2,4
                // 제1류 시작 : 2, 4 끝 1620, 4   
    public enum HsExcelFileMetaInfo 
    {
        EndRow = 17967, EndCoulumn = 147, 
        UsName = 5, KoName = 6, WeightUnit = 7, QuantityUnit = 8, 
        Part1EndRow = 1620,
        CheckStartRow = 2,
        HSColumn = 4,
        BasicTaxColumn = 10,
        AgreetMentTaxStartColumn = 11
    }
    public interface IHsCodeManagement
    {
        Task HsInfoExcelToDb(object[,] dataSet);
    }
    delegate Task WeightHsFuction(Object[,] dataSet, int Row);

    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    public class HsCodeManagement : IHsCodeManagement
    {
        private readonly CountryManager _coutntryManager;
        private readonly HsCodePartManager _hsCodePartMangaer;
        private readonly SubPartofHsCodeManager _subPartofHsCodeManager;
        private readonly PracticalHsCodeManager _practicalHsCodeManager;
        private readonly SubPracticalHsCodeManager _subPracticalHsCodeManager;
        private readonly DetailPracticalHsCodeManager _detailPracticalHsCodeManager;
        private readonly ClearanceInfoofHsCodeManager _clearanceInfoofHsCodeManager;
        private List<PracticalHsCode> practicalHsCodes = new();
        private List<SubPracticalHsCode> subPracticalHsCodes = new();
        private Dictionary<int, WeightHsFuction> SetWeightFuction = new();
        private PracticalHsCode CurrentPracticalHsCode = new();

        // 신경강도확인
        // 상기 강도에 따른 함수 실행
        public HsCodeManagement(CountryManager coutntryManager, HsCodePartManager hsCodePartManager,
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
            _clearanceInfoofHsCodeManager = clearanceInfoofHsCodeManager;
            CurrentPracticalHsCode.SubPracticalHsCodes = new();
            
            SetWeightFuction.Add(4, Hs4Fuction);
            SetWeightFuction.Add(5, Hs5Or6Fuction);
            SetWeightFuction.Add(7, Hs7Fuction);
        }
        public async Task HsInfoExcelToDb(object[,] dataSet)
        {
            string HsCode = null;
            int Weight = 0;
            for(int Row = (int)HsExcelFileMetaInfo.CheckStartRow; Row <= (int)HsExcelFileMetaInfo.EndRow; Row++)
            {
                if(dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn] != null)
                {
                    HsCode = dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn].ToString();
                    if (CheckPart1ofHs(Row))
                    {
                        HsCode = Append0ToHsCode(HsCode);
                        dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn] = HsCode;
                    }
                    Weight = WeightCheck(HsCode);
                    await SetWeightFuction[Weight](dataSet, Row);
                };
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
            int Length = HsCode.Length;
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
            throw new ArgumentException("Not Validate HsCode");
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
        bool IsReHs4 = false;
        private async Task Hs4Fuction(object[,] dataSet, int Row)
        {
            if(IsReHs4)
            {
                await _practicalHsCodeManager.CreateAsync(CurrentPracticalHsCode);
                CurrentPracticalHsCode = null;
                CurrentPracticalHsCode = new();
                CurrentPracticalHsCode.SubPracticalHsCodes = new();
                IsReHs4 = false;
            }
            if(dataSet[Row, (int)HsExcelFileMetaInfo.KoName] != null) { CurrentPracticalHsCode.KoName = dataSet[Row, (int)HsExcelFileMetaInfo.KoName].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.UsName] != null) { CurrentPracticalHsCode.UsName = dataSet[Row, (int)HsExcelFileMetaInfo.UsName].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn] != null) { CurrentPracticalHsCode.Name = dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn].ToString(); }
            CurrentPracticalHsCode.Id = Math.Abs(CurrentPracticalHsCode.Name.GetHashCode()).ToString();
            practicalHsCodes.Add(CurrentPracticalHsCode);
            IsReHs4 = true;
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
            subPracticalHsCode.DetailPracticalHsCodes = new();
            if (dataSet[Row, (int)HsExcelFileMetaInfo.KoName] != null) { subPracticalHsCode.KoName = dataSet[Row, (int)HsExcelFileMetaInfo.KoName].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.UsName] != null) { subPracticalHsCode.UsName = dataSet[Row, (int)HsExcelFileMetaInfo.UsName].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn] != null) { subPracticalHsCode.Name = dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn].ToString(); }
            subPracticalHsCode.Id = Math.Abs(subPracticalHsCode.Name.GetHashCode()).ToString();
            CurrentPracticalHsCode.SubPracticalHsCodes.Add(subPracticalHsCode);
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
        // 중량 7, 수량 8
        private async Task Hs7Fuction(object[,] dataSet, int Row)
        {
            DetailPracticalHsCode detailPracticalHsCode = new();
            detailPracticalHsCode.ClearanceInfoofHsCode = new();
            if (dataSet[Row, (int)HsExcelFileMetaInfo.WeightUnit] != null) { detailPracticalHsCode.WeightUnits = dataSet[Row, (int)HsExcelFileMetaInfo.WeightUnit].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.QuantityUnit] != null) { detailPracticalHsCode.QuantityUnits = dataSet[Row, (int)HsExcelFileMetaInfo.QuantityUnit].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.KoName] != null) { detailPracticalHsCode.KoName = dataSet[Row, (int)HsExcelFileMetaInfo.KoName].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.UsName] != null) { detailPracticalHsCode.UsName = dataSet[Row, (int)HsExcelFileMetaInfo.UsName].ToString(); }
            if (dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn] != null) { detailPracticalHsCode.Name = dataSet[Row, (int)HsExcelFileMetaInfo.HSColumn].ToString(); }
            detailPracticalHsCode.Id = Math.Abs(detailPracticalHsCode.Name.GetHashCode()).ToString();
            
            ClearanceInfoofHsCode clearanceInfoofHsCode = new();
            clearanceInfoofHsCode.DetailPracticalHsCode = detailPracticalHsCode;
            clearanceInfoofHsCode.AgreetMentTaxRates = new();
            clearanceInfoofHsCode.Id = "ClearanceInfo-" + detailPracticalHsCode.Id;
            if(dataSet[Row, (int)HsExcelFileMetaInfo.BasicTaxColumn] != null)
            {
                clearanceInfoofHsCode.BasicTaxRate = dataSet[Row, (int)HsExcelFileMetaInfo.BasicTaxColumn].ToString();
            }            
            for(int Column = (int)HsExcelFileMetaInfo.AgreetMentTaxStartColumn; Column <= (int)HsExcelFileMetaInfo.EndCoulumn; Column++)
            {
                if(dataSet[Row, Column] != null)
                {
                    clearanceInfoofHsCode.AgreetMentTaxRates.Add(new (dataSet[Row, Column].ToString(), dataSet[1, Column].ToString()));
                }
            }
            detailPracticalHsCode.ClearanceInfoofHsCode = clearanceInfoofHsCode;
            string HsCode6 = Get6Length(detailPracticalHsCode.Name);
            var subPracticalHsCode = CurrentPracticalHsCode.SubPracticalHsCodes.FirstOrDefault(e => e.Name.Equals(HsCode6));
            if (subPracticalHsCode != null){ subPracticalHsCode.DetailPracticalHsCodes.Add(detailPracticalHsCode);}
            // Final
            if (Row.Equals((int)HsExcelFileMetaInfo.EndRow)) {
                await _practicalHsCodeManager.CreateAsync(CurrentPracticalHsCode);
                CurrentPracticalHsCode = null;
                IsReHs4 = false;
            }
        }
    }
}
