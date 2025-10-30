CREATE TABLE department 
			(
			department_ID int PRIMARY KEY,
            department_Name varchar(50),
            location varchar(100)
			);
            
CREATE TABLE employee
			(
			employee_ID int PRIMARY KEY,
            first_name varchar(20),
            last_name varchar(20),
            hire_date datetime,
            salary int,
            department_ID int
            );
            
INSERT INTO department (department_ID, department_Name, location) VALUES
			(10, '판매', '서울'),
            (20, 'HR', '대구'),
            (30, 'IT', '대전'),
            (40, '재정', '부산');
            
INSERT INTO employee(employee_ID, first_name, last_name, hire_date, salary, department_ID) VALUES
			(101, '정','승우','2023-01-05',60000,20),
            (102, '최','정완','2022-05-20',75000,10),
            (103, '정','현우','2024-03-10',50000,20),
            (104, '양','동엽','2023-11-01',90000,30),
            (105, '박','종혁','2024-01-25',65000,10),
            (106, '허','성민','2022-08-12',55000, NULL);
            
-- 문제 1. 직원 정보 추가하기
INSERT INTO employee(employee_ID, first_name, last_name, hire_date, salary, department_ID) VALUES
			(107, '박', '윤아','2024-10-30', 70000, 30);
-- 문제 2. 직원 급여 60000 이상인 모든 직원의 first_name 과 last_name, salary를 조회하는 쿼리 작성 
select first_name, last_name, salary from employee
WHERE salary >= 60000;

-- 문제 3. employee_ID 가 106인 직원의 급여를 60000으로 수정하는 쿼리
UPDATE employee
SET salary = 60000
WHERE employee_ID = 106; 

select salary from employee
WHERE employee_ID = 106;

-- 문제 4. employee_name이 '박 윤아'인 직원을 삭제하는 쿼리 작성
DELETE FROM employee
WHERE first_name = '박' AND last_name = '윤아';

-- 문제 5. employee와 department 테이블을 join 하여 모든 직원이 이름, 그 직원이 속한 부서의 이름을 함께 조회하는 쿼리 작성
select employee.first_name, employee.last_name, department.department_Name
from employee
LEFT JOIN department on employee.department_ID = department.department_ID; 

-- 문제 6. employee 테이블에서 부서별 최대 급여를 조회하는 쿼리 작성
select D.department_Name, MAX(e.salary) as 부서별_최대_연봉
	from employee as e
	left join department as d on e.department_ID = d.department_ID
	group by d.department_Name
	order by 부서별_최대_연봉 desc;

-- 문제 7. employee 테이블에서 부서별 평균 급여를 계산하되, 평균 급여가 65000을 초과하는 부서의 department_ID와 평균 급여를 조회하는 쿼리 작성
select d.department_ID, AVG(e.salary) as 평균_급여
from employee e
left join department d on d.department_ID = e.department_ID
group by d.department_ID
having AVG(e.salary) > 65000
order by 평균_급여 asc;

select concat(first_name, ' ', last_name) as name
from employee;

