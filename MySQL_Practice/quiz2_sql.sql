select last_name, salary
from employee
where hire_date
between '2023-01-01' and '2023-12-31';

-- year() 함수 사용
select last_name, salary
from employee
where year(hire_date) 
between '2023-01-01' and '2023-12-31'; 


select last_name, salary
from employee
WHERE last_name LIKE '승%';

-- 부서별 평균 급여 비교: 'HR' 부서의 평균 급여보다 더 많은 급여를 받는 모든 직원의 이름, 급여, 부서 이름을 조회하는 쿼리를 작성하세요.
select e.last_name , e.salary, d.department_Name
from employee e
INNER JOIN department d ON e.department_ID = d.department_ID
WHERE e.salary > (select AVG(salary) from employee where department_ID = 20);

-- 부서가 할당되지 않은(department_id가 NULL인) 직원의 이름과 해당 직원의 급여가 전체 직원 평균 급여보다 높은지를 비교하여 조회하는 쿼리를 작성하세요
select e.last_name
from employee e
INNER JOIN department d ON e.department_ID = d.department_ID
WHERE e.salary > (select AVG(salary) from employee);

-- 급여 순위 (상위 N명): 급여가 가장 높은 3명의 직원의 이름과 급여를 내림차순으로 조회하는 쿼리를 작성하세요.
select last_name, salary
from employee
order by salary
limit 3;

-- 조건부 분류 (CASE): 모든 직원의 이름과 급여 수준을 다음과 같이 분류하여 조회하는 쿼리를 작성하세요.
case when then else end