JAVA 손코딩 연습하기 



<내용 학습>

배열 선언 시 데이터 타입 뒤에 \[]를 붙여야 한다.



1일차 : 



* 구구단 출력  <2단부터 9단까지 보기 좋게 출력하기>



&nbsp;	기능 쪼개기

1\) 구구단 => 2 \* 1~9까지의  숫자

2\) 반복문 for문을 사용하기

3\) 반복문 안에 반복문을 사용하여 첫 번째 반복문에서는 2~9가 출력이 되도록 하고, 그 안의 반복문에서 1~9를 곱하게 한다.



public class Multiple { //곱하기(Multiple) 클래스 생성

&nbsp;	public static void main(String\[] args) { //main 메서드

&nbsp;		// 구구단 2~9단 for문 2개를 사용

&nbsp;		for(int a = 2; a<10; a++) {			  

&nbsp;			for(int b = 1; b<10; b++) {

&nbsp;				System.out.println(a + "X" + b + "=" + (a\*b) );

&nbsp;				}

&nbsp;			// 가독성을 위해 각 단 종료 후 밑줄 생성

&nbsp;			System.out.println("===========================");

&nbsp;			}

&nbsp;		}

&nbsp;	}



* 간단한 계산기 만들기



&nbsp;	기능 쪼개기











