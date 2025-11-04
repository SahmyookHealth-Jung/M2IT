C# 숫자 맞추기 게임 (NumberGame)



* 텍스트 박스, 입력 버튼, 게임 시작 버튼을 생성 후 Name을 부여
* findNumber - rand.Next를 사용하여 난수 생성
* int inputNumber = Int32.Parse(textBox.Text) - textBox의 숫자 입력을 inputNumber에 대입
* inputNumber가 findNumber와 같을 시 승리 틀릴 시 실패
* chance 변수 만들고 조건문에 틀릴 경우 chance-- 를 통해 기회 줄이기



=========================================================================================



<숫자 맞추기 게임 응용.ver> - 스스로 응용 버전 만들기 연습 (NumberGame2)



* 텍스트 박스, 입력 버튼, 게임 시작 버튼, up/down 레이블을 생성 후 Name을 부여 
* findNumber -rand.Next를 사용하여 난수 생성 (up/down 기능이 있기 때문에 숫자 범위 늘리기
* int inputNumber = Int32.Parse(textBox.Text) - textBox의 숫자 입력을 inputNumber에 대입
* inputNumber가 findNumber와 같을 시 승리 / 

=> 틀릴 시 입력한 값보다 findNumber의 값이 높을 경우 label에 up 표시

=> 틀릴 시 입력한 값보다 findNumber의 값이 낮을 경우 label에 down 표시

* chance 변수 만들고 조건문에 틀릴 경우 chance-- 통해 기회 줄이기



