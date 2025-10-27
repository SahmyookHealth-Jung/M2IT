Pr\_HIS (병원 정보 시스템 연습하기)



<기능>

* Form 여러 개 사용해서 기능 별로 분리해보기.



<각 Form 명 및 역할>

* DBHelper.cs 
  - DB 연결 문자열 등 공통 DB 정보 관리
* Patient.cs
  - 환자 데이터를 담는 모델(객체) 정의
* ViewForm.cs 
  - 검진 기록 조회 모듈 화면
* RegisterForm.cs
  - 새 환자 등록 모듈 화면
* ModifyDeleteForm.cs
  - 환자 수정/삭제 모듈 화면



\## 이해하기 어려웠던 내용##



* ExecuteNonQuery: 이름 그대로 "결과 집합을 반환하지 않는(Non Query)" SQL 명령을 실행할 때 사용합니다.
  INSERT, DELETE, UPDATE	를 실행할 때 사용합니다. 
* rowAffected 의 의미
  rowAffected 변수에는 몇 개의 행이 수정되었는지 숫자로 저장됩니다.



\## SQL 쿼리문 ##



* SELECT name, COUNT(name) from patients GROUP BY name Having COUNT(name) > 1; 
  -> 이름이 두 번 이상 등장하는 경우 조회 



* DELETE p1 FROM patients p1 JOIN patients p2 ON p1.name = p2.name AND p1.id
  -> 내가 만든 테이블은 아직 patients 테이블 하나인데 왜 나뉘지 ? 
  		-> JOIN을 사용하는 이 테크닉을 셀프 조인이라고 부른다. 
  		-> 논리적으로 동일한 하나의 테이블을 두 개의 가상적인 별칭으로 접근한다. 
  		-> p1 을 삭제할 중복 행을 가리키는 포인터 / p2를 남긴 기준 행을 찾기 위한 비교 대상
  

&nbsp;	=> 가장 먼저 입력된 행만 남고 나머지는 모두 삭제된다.





\### 다음 단계 제안

* UX 개선
* 데이터 무결성 강화
* 새 프로젝트 : 로그인 시스템 





