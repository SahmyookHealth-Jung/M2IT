CREATE TABLE Patients
(
			patient_ID int PRIMARY KEY,
            patient_name varchar(20),
            gender char(1),
            birth_date date,
            phone varchar(20)
);
CREATE TABLE Exams 
(
			exam_code varchar(20) PRIMARY KEY,
            exam_name varchar(50),
            standard_price int
);
CREATE TABLE Results 
(
			result_ID int PRIMARY KEY,
            patient_ID int,
            exam_code varchar(20),
            exam_date date,
            result_value varchar(20),
            billing_account int
);

INSERT INTO Patients (patient_ID, patient_name, gender, birth_date, phone) VALUES
	(1001, '김민준' , 'M', '1985-05-10' , 010-1111),
    (1002, '이서윤' , 'F', '1992-11-25' , 010-2222),
    (1003, '박지훈' , 'M', '1970-03-01' , 010-3333),
    (1004, '최예나' , 'F', '2000-07-18' , 010-4444);
    
UPDATE Patients
set phone = CASE patient_ID
	WHEN 1002 THEN '010-2222'
    WHEN 1003 THEN '010-3333'
    WHEN 1004 THEN '010-4444'
	ELSE phone
END 
WHERE patient_ID IN(1002,1003,1004);


INSERT INTO Exams (exam_code , exam_name, standard_price) VALUES
	('C001', '혈압 측정', 5000),
    ('C002', '혈당 검사', 8000),
	('C003', '위 내시경', 100000),
	('C004', '콜레스테롤', 12000);

INSERT INTO Results (result_ID, patient_ID, exam_code, exam_date, result_value, billing_account) VALUES
	(201, 1001, 'C001', '2024-05-10', '120/80',5000),
    (202, 1002, 'C002', '2024-05-10', '98',8000),
    (203, 1001, 'C003', '2024-05-10', 'Normal',100000),
    (204, 1003, 'C001', '2024-05-15', '140/90',5000),
    (205, 1003, 'C002', '2024-05-15', '130',8000),
    (206, 1002, 'C004', '2024-05-15', '220',12000);

SELECT p.patient_name, r.exam_date 
FROM Results r
INNER JOIN Patients p ON r.patient_ID = p.patient_ID
WHERE r.exam_date LIKE '2024%';

SELECT patient_name, birth_date 
FROM Patients 
WHERE (YEAR(current_date())- YEAR(birth_date)) between 40 and 49;

SELECT e.exam_name ,SUM(r.billing_account) as total
FROM Results r
INNER JOIN Exams e ON r.exam_code = e.exam_code
GROUP BY e.exam_name
ORDER BY total desc;

SELECT p.patient_name,  COUNT(r.exam_code) AS total
FROM Patients p
INNER JOIN Results r ON p.patient_ID = r.patient_ID
group by p.patient_name
Having total >= 2;

SELECT p.patient_name, CAST(r.result_value AS UNSIGNED)as 혈당결과,
			CASE 
			WHEN r.result_value > 126 THEN '재검 필요'
            WHEN r.result_value > 100 THEN '주의 요망'
            ELSE '정상'
	end as '혈당 결과 분류'
FROM Patients p 
INNER JOIN Results r ON p.patient_ID = r.patient_ID
WHERE r.exam_code = 'C002';


