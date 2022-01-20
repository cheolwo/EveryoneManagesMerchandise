namespace BusinessLogic.ofManager.ofFisheries
{
    // 추상적으로 모듈화 해놓으니까 개편하네.
    // 각 센터의 품목별로 RequestFactory를 만들어야돼.
    // 그렇기에 굳이 여러 Repository 모듈을 DI 할 필요가 없어.

    /* 창고정보 API URL 예시
    // page랑 rows는 WebAPI로 넘겨줄 떄 이용되는 Query
    http://apis.data.go.kr/1192000
    /select0120List/
    getselect0120List?serviceKey=인증키(URL Encode)
    & pageNo=1
    &numOfRows=10
    &mxtrNm=경인북부수산업협동조합
    &wrhousNm=판매사업과(이용)
    */
    /* 재고정보 API URL 예시
    http://apis.data.go.kr/1192000
    /select0150List/
    getselect0150List?serviceKey=인증키(URL Encode)
    & pageNo=1&numOfRows=10
    &baseDt=20210101
    &mxtrNm=경인북부수산업협동조합
    &wrhousNm=판매사업과(이용)
    &mprcStdCodeNm=고등어
    */
    /* 입출고정보 API URL 예시
    http://apis.data.go.kr/1192000
    /select0140List/
    getselect0140List?serviceKey=인증키(URL Encode)
    & pageNo=1
    &numOfRows=10
    &baseDt=20210101
    &mxtrNm=인천수산업협동조합
    &wrhousNm=이용가공팀(이용)
    &mprcStdCodeNm=기타가오리류
    &inOutNm=입고
    */
    public class FisheriesRequestFactory
    {
        private readonly ICenterDataRepository<Fisheries> _CenterDataRepository;
        public FisheriesRequestFactory(ICenterDataRepository<Fisheries> centerDataRepository)
        {
            _CenterDataRepository = centerDataRepository;
        }
        // 조합명, 창고명, 품목명, 입출고구분, 기준일자
        public async Task<List<RequestMessage>> MakeFisheriesRequestMessage()
        {

        }
    }
}