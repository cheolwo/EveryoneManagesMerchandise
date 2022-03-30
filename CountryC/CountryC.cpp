// CountryC.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <stdio.h>
#include <malloc.h>
#include <string.h>

int main(void)
{
	int students;			// 학생수
	int sum = 0;				// 합계
	int l, s;				// for루프를 위한 임시변수
	int* lessons = NULL;
	int** score = NULL;

	printf("학생수를 입력하세요: ");
	scanf_s("%d", &students);
	printf("---------------------------------\n");

	// 세로축에 해당하는 메모리 할당
	score = (int**)malloc(sizeof(int*) * students);
	lessons = (int*)malloc(sizeof(int) * students);

	for (s = 0; s < students; s++) 			// 학생 수만큼 루프
	{
		printf("%d번째 학생의 수강과목 수: ", s + 1);
		scanf_s("%d", &lessons[s]);			// 학생별 수강과목 수 입력

		// 가로축에 해당하는 메모리 할당
		score[s] = (int*)malloc(sizeof(int) * lessons[s]);

		printf("%d번째 학생의 점수 (%d개): ", s + 1, lessons[s]);
		for (l = 0; l < lessons[s]; l++)		// 과목 수만큼 루프
		{
			scanf_s("%d", &score[s][l]);		// 점수 입력
		}
	}
	printf("---------------------------------\n");

	for (s = 0; s < students; s++) 			// 학생 수만큼 루프
	{
		sum = 0;
		for (l = 0; l < lessons[s]; l++)
		{
			sum += score[s][l];				// 학생별 평균 계산
		}
		printf("%d번째 학생: %0.2f\n", s + 1, (double)sum / lessons[s]);
	}

	for (s = 0; s < students; s++)				// 학생 수만큼 루프
	{
		free(score[s]);						// 가로축에 해당하는 메모리 반납
	}
	free(score);							// 세로축에 해당하는 메모리 반납
	free(lessons);
	return 0;
}


// 프로그램 실행: <Ctrl+F5> 또는 [디버그] > [디버깅하지 않고 시작] 메뉴
// 프로그램 디버그: <F5> 키 또는 [디버그] > [디버깅 시작] 메뉴

// 시작을 위한 팁: 
//   1. [솔루션 탐색기] 창을 사용하여 파일을 추가/관리합니다.
//   2. [팀 탐색기] 창을 사용하여 소스 제어에 연결합니다.
//   3. [출력] 창을 사용하여 빌드 출력 및 기타 메시지를 확인합니다.
//   4. [오류 목록] 창을 사용하여 오류를 봅니다.
//   5. [프로젝트] > [새 항목 추가]로 이동하여 새 코드 파일을 만들거나, [프로젝트] > [기존 항목 추가]로 이동하여 기존 코드 파일을 프로젝트에 추가합니다.
//   6. 나중에 이 프로젝트를 다시 열려면 [파일] > [열기] > [프로젝트]로 이동하고 .sln 파일을 선택합니다.
