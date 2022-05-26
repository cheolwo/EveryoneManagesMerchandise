using BusinessData.ofCommon.ofHsCode;
using BusinessData.ofCommon.ofHsCode.ofRepository;

namespace BusinessLogic.ofManagement.ofPatform
{
    enum HsTaxInfoExcelFile
    {
        KoName = 5, UsName = 6, WeightUnit = 7, QuantityUnit = 8,
    }
    public class PlatFormManagement
    {
        private readonly HsCodePartRepository _hsCodePartRepository;
        private readonly SubPartofHsCodeRepository _subPartofHsCodeRepository;
        private readonly PracticalHsCodeRepository _practicalHsCodeRepository;
        private readonly DetailPracticalHsCodeRepository _detailPracticalHsCodeRepository;
        private readonly CountryRepository _countryRepository;
        public PlatFormManagement(HsCodePartRepository hsCodePartRepository,
            SubPartofHsCodeRepository subPartofHsCodeRepository,
            PracticalHsCodeRepository practicalHsCodeRepository,
            DetailPracticalHsCodeRepository detailPracticalHsCodeRepository,
            CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
            _hsCodePartRepository = hsCodePartRepository;
            _subPartofHsCodeRepository = subPartofHsCodeRepository;
            _practicalHsCodeRepository = practicalHsCodeRepository;
            _detailPracticalHsCodeRepository = detailPracticalHsCodeRepository;
        }
        public async Task ExcelHsTaxInfoToDb(object[,] data)
        {
            // Part 1에 0삽입 : Excel File 에 0이 안붙어있음.
            var Part1 = Insert0ToFirstHsCodePart(data);
            int i = 2;
            bool IsSwitchPracticalHscode = false;
            PracticalHsCode practicalHsCode = new();

            DetailPracticalHsCode detailPracticalHsCode = new();
            detailPracticalHsCode.SubPracticalHsCode = new();
            detailPracticalHsCode.ClearanceInfoofHsCode = new();

            ClearanceInfoofHsCode claranceInfoofHsCode = new();
            claranceInfoofHsCode.AgreetMentTaxRates = new();
            claranceInfoofHsCode.DetailPracticalHsCode = new();
            //foreach (var HsCode in Part1)
            //{
            //    if (HsCode.Length == 4)
            //    {
            //        // 기존 4자리 확인
            //        if (IsSwitchPracticalHscode)
            //        {
            //            // 기존에 저장된 것을 정리;
            //            await _practicalHsCodeRepository.AddAsync(practicalHsCode);
            //            practicalHsCode.Clear();
            //            detailPracticalHsCode.Clear();
            //            claranceInfoofHsCode.Clear();
            //            // 다시 4자리부터 시작
            //            practicalHsCode.Name = HsCode;
            //            practicalHsCode.UsName = (string)data[i, (int)HsTaxInfoExcelFile.UsName];
            //            practicalHsCode.KoName = (string)data[i, (int)HsTaxInfoExcelFile.KoName];
            //            continue;
            //            i++;
            //        }
            //        // 4자리 확인
            //        if (!IsSwitchPracticalHscode)
            //        {
            //            IsSwitchPracticalHscode = true;
            //            practicalHsCode.Name = HsCode;
            //            practicalHsCode.UsName = (string)data[i, (int)HsTaxInfoExcelFile.UsName];
            //            practicalHsCode.KoName = (string)data[i, (int)HsTaxInfoExcelFile.KoName];
            //            i++;
            //            continue;
            //        }
            //    }
            //    if (HsCode.Length >= 5 && HsCode.Length <= 6)
            //    {
            //        detailPracticalHsCode.Name = HsCode;
            //        detailPracticalHsCode.KoName = (string)data[i, (int)HsTaxInfoExcelFile.UsName];
            //        detailPracticalHsCode.UsName = (string)data[i, (int)HsTaxInfoExcelFile.KoName];
            //        detailPracticalHsCode.SubPracticalHsCode = SubPracticalHsCode;
            //        practicalHsCode.DetailPracticalHsCodes.Add(detailPracticalHsCode);
            //        continue;
            //        i++;
            //    }
            //    if (HsCode.Length >= 7)
            //    {
            //        detailPracticalHsCode.Name = HsCode;
            //        detailPracticalHsCode.KoName = (string)data[i, (int)HsTaxInfoExcelFile.UsName];
            //        detailPracticalHsCode.UsName = (string)data[i, (int)HsTaxInfoExcelFile.KoName];
            //        for (int column = 10; column <= 147; column++)
            //        {
            //            if (data[i, column] != null)
            //            {
            //                claranceInfoofHsCode.AgreetMentTaxRates.Add(new AgreetMentTaxRate(data[i, column].ToString(), data[1, column].ToString()));
            //            }
            //        }
            //        claranceInfoofHsCode.DetailPracticalHsCode = detailPracticalHsCode;
            //        detailPracticalHsCode.ClearanceInfoofHsCode = claranceInfoofHsCode;
            //        detailPracticalHsCode.PracticalHsCode = practicalHsCode;
            //        practicalHsCode.DetailPracticalHsCodes.Add(detailPracticalHsCode);
            //        continue;
            //        i++;
            //    }
            //}
        }
        private List<string> Insert0ToFirstHsCodePart(object[,] data)
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
