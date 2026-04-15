// 001_bmi.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <stdio.h>

int main()
{
    float h, w; // height(키), weight(체중)

    printf("키(cm) : ");
    scanf_s("%f", &h);

    printf("체중(kg) : ");
    scanf_s("%f", &w);

    // bmi 계산하고 출력하기
    h /= 100; // m 단위로 변화
    float bmi = w / (h * h);

    printf("bmi = %.1f\n", bmi);
}
