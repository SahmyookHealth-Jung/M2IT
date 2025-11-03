<MINI HIS PROJECT>



* Login.cs		(Staff\_info TABLE)

  -> 로그인 (아이디, 비밀번호 DB와 매칭해서 맞으면 로그인, 틀리면 로그인 X)
  -> 로그인 성공 시 권한에 따라서 폼 띄우기 (관리자 / 일반 직원)
  
* MainForm.cs	
  -> 로그인 성공 시 보이는 화면
  -> 관리자 / 일반 직원 별로 보이는 메뉴 구성이 다르다.



* AuthList.cs / AuthSave.cs		(Authority TABLE)
  -> DataGridView 로 권한코드, 권한명을 보여준다. 
  -> EX) 권한코드 - ALL/ADMIN/NORMAL / 권한명 - 전체 / 관리자 / 일반
  -> 팝업으로 권한코드 / 권한명을 생성, 수정, 삭제 할 수 있는 팝업을 생성한다.

&nbsp;	

* MenuList.cs / MenuSave.cs		(Menu TABLE)
  -> DataGridView 로 메뉴코드, 부모메뉴코드, 메뉴명, 권한명, 클래스명, 폼표시를 보여준다.
  -> 팝업으로 해당 컬럼을 생성, 수정, 삭제 할 수 있는 팝업을 생성한다.
  
* TaskList.cs / TaskSave.cs			(
  -> DataGridView 로 업무코드, 업무명을 보여준다.
  -> EX) 업무코드 - AP / SC / OP / BL / RS  업무명 - 예약/건강검진/외래/청구/결과 관리 
  -> 팝업으로 업무코드 / 업무명을 생성, 수정, 삭제 할 수 있는 팝업을 생성한다.
  
* Manager.cs
  -> 이름, 업무, 권한을 계정 생성, 계정 수정, 계정 삭제 버튼을 통해서 작업할 수 있도록 설계한다.



* Schedule.cs
  -> 달력을 띄우고 달력의 클릭 이벤트로 그 일정 내 업무 내용을 입력한다.



* DashBoard.cs
  -> 폼 3개를 띄워 전체적인 현황 조회를 할 수 있도록 DATAGRIDVIEW를 활용한다.

  
