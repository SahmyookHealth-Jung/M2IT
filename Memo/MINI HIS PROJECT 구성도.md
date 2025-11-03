<MINI HIS PROJECT 구성도>



C# Window Form / MySql DataBase



<화면별 기능 요구사항>

\[로그인] ★ 프로그램 시작 시 최초 진입화면 -> Login.cs

계정 조회 ★ 성공 시 계정이 가진 권한으로 메뉴 정보를 추출하여 메인화면으로 이동한다.



=> txtID, txtPWD 를 통해서 텍스트 입력을 받고 버튼을 누르면 DB와 매칭.



\[메인화면] ★ 메뉴를 더블클릭 시 우측 폼에 클릭한 메뉴가 보여진다. -> MainForm.cs

좌측 : 메뉴 조회 영역(로그인 사용자의 권한에 따라 메뉴 조회)

우측 : 메뉴가 열리는 폼 영역



\[코드관리] ★ 관리자만 보임, 1화면 내에 그리드로 표현, 생성 또는 목록 그리드 클릭 시 팝업으로 코드 생성 / 수정

권한 목록 / 생성 / 수정 / 삭제 ★ 권한을 코드화 (ex, 관리자, 일반직원 ..)				-> AuthList.cs	/ AuthSave.cs

메뉴 목록 / 생성 / 수정 / 삭제 ★ 메뉴를 코드화 (ex, 코드관리, 직원관리 ..) + 권한코드		-> MenuList.cs / MenuSave.cs

업무 목록 / 생성 / 수정 / 삭제 ★ 업무를 코드화 (ex, 분석, 설계, 개발, 교육, 토의, 출장 ..)	-> TaskList.cs / TaskSave.cs



\[직원관리] ★ 관리자만 보임, 1화면 내에 그리드로 표현, 생성 또는 목록 그리드 클릭 시 팝업으로 계정 생성 / 수정 -> Manager.cs

직원 목록 / 생성 / 수정 / 삭제 ★ 직원 정보 생성 시 권한코드 선택		# DataGridView 사용



\[일정관리] ★ 관리자만 보임, 1화면 내에 달력으로 표현, 각 달력클릭 시 팝업으로 일정 생성/수정  -> Schedule.cs

일정 / 생성 / 수정 / 삭제 ★ 일정 정보 생성 시 업무코드 선택



\[대시보드] ★ 팀원 모두에게 보임, 1화면 내에 3개의 영역으로 분리하여 조회				-> DashBoard.cs



======================================================================================================================================



C# winform / MySql DB


1. Login.cs / MainForm.cs -> UI 설계 완료

2\. DB 테이블 생성 (Auth / Menu / User)

3\. DBHelper 클래스 생성 
-> 데이터베이스와의 통신을 전담하는 핵심 클래스.

-> DAO (Data Access Object) 패턴의 기본적인 역할을 수행.

&nbsp;	- DB 연결 중앙 관리 : DB 접속 정보 (ConnectionString)를 한 곳에서 관리하며, 나중에 DB 정보가 바뀌어도 이 클래스만 수정하면 된다.

&nbsp;		-> static readonly 로 정의하여 프로그램 전체에서 공유하고 수정할 수 없게 한다. 

&nbsp;	- DB 작업 통일 : 모든 CRUD 작업이 이 클래스의 메서드를 호출하여 이루어지도록 표준화한다.



-> ExecuteReader : SELECT 쿼리를 실행하고 결과를 MySqlDataReader 형태로 반환한다.

&nbsp;		-> cmd.ExecuteReader(CommandBehavior.CloseConnection) 호출.

&nbsp;		-> Reader를 반환하고, Reader가 모든 데이터를 읽은 후, Dispose() 될 때 연결도 함께 닫아주도록 지시.



-> ExecuteNonQuery : INSERT, UPDATE, DELETE 쿼리를 실행하고 작업으로 인해 영향을 받은 행의 개수를 int 형태로 반환한다. 













































