C# 계산기 응용.ver (숫자를 마우스 클릭 \&\& 키보드 입력 받기)



\## KEY EVENT



* KeyDown -물리적 키가 눌리는 순간 (e.KeyCode)
* KeyPress - 눌린 키가 문자로 변환되어 입력될 때 (e.KeyChar)
* KeyUp - 물리적인 키에서 손을 떼는 순간



* e.KeyCode : 사용자가 누른 키의 이름 EX) A, ControlKey, F1 등)을 나타내는 열거형 값
* e.KeyValue : KeyCode에 해당하는 정수 값
* e.Modifiers : Shift, Ctrl, Alt 등의 조합 키가 함께 눌렸는지 여부를 나타냄



\## 데이터(변수) 정의 -> 초기 환경 (생성자) 설정 -> 기능 구현(메서드)

* 폼이 어떤 데이터를 관리해야 하는지를 생각하고 변수나 속성을 정의한다.

=> 사고방식 : "이 계산기 폼이 작동하는 데 필요한 상태, 값, 설정은 무엇일까?"

=> 위치 : public class Form1 : Form 안

EX) private string currentInput = "0"; // 현재 입력중인 숫자

EX) private double lastValue = 0; // 직전에 계산된 값

EX) private string currentOperator = ""; // 현재 선택된 연산자



* 폼이 처음 화면에 나타날 때 준비해야 할 초기 환경을 생성자 안에 설정

=> 사고방식 : "폼이 켜지자마자 UI를 준비하고, 이벤트 처리 장치를 연결해야 하는데?"

=> 위치 : public Form1() 안

EX) textBox1.KeyDown += TextBox1\_KeyDown; (메서드 연결) / 이벤트와 기능 연결



구조적 사고 흐름 

★ 무엇을 관리할까



★ 어떻게 준비할까 



★ 무슨 일을 할까





