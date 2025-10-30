create table customers 
(
			CustomerID int Primary Key,
            CustomerName varchar(50), 
            ContactName varchar(50),
            Address varchar(100), 
            City varchar(50),
            PostalCode varchar(50),
            Country varchar(50)
);

alter table customers
modify column PostalCode varchar(20);

select * from customers;

insert into customers (CustomerID, CustomerName, ContactName, Address, City, PostalCode, Country) VALUES 
	(1, 'Alfreds Futterkiste', 'Maria Anders', 'Obere Str. 57', 'Berlin', '12209', 'Germany'),
    (2, 'Ana Trujillo Emparedados y helados',  'Ana Trujillo', 'Avda. de la Constitución 2222', 'México D.F.', '05021', 'Mexico'),
    (3, 'Antonio Moreno Taquería','Antonio Moreno','Mataderos 2312','México D.F.', '05023', 'Mexico'),
    (4, 'Around the Horn','Thomas Hardy','	120 Hanover Sq.','London.', 'WA1 1DP', 'UK'),
    (5, 'Berglunds snabbköp','Christina Berglund','Berguvsvägen 8','Luleå', 'S-958 22', 'Sweden');
    
-- IN -> OR 관계로 묶어 나열하는 조건을 WHERE 절에 사용할 떄 쓸 수 있는 키워드
select * from customers
where City 
IN ('Paris','London.');

select * from customers
where Country = 'Germany' and (City = 'Berlin' or City = 'Stutgart');

-- 기본(오름차순)
select * from customers
ORDER BY Country;

select CustomerName, ContactName, Address
From customers
WHERE Address IS NULL;

select * from customers
order by Country
limit 3;

select * from customers
where CustomerName Like 'a___%';

create table Products 
(
			pd_code int primary key,
			pd_name varchar(100),
            pd_price int
);

INSERT INTO products(pd_code, pd_name, pd_price) VALUES
(1 , '엔비디아' , 15000),
(2 , 'AMD' , 10000),
(3, '인텔' , 8000);

-- 비용이 가장 낮은 종목의 이름과 같이 출력하고 싶을때 사용할 수 있는 2가지 쿼리
select pd_name , pd_price
from Products
where pd_price = (select min(pd_price) as min_price from products);

select pd_name , pd_price
from Products
order by pd_price asc
limit 1; 

-- between 연산자 사용 시 작은 값을 먼저 쓰는 것이 표준
select pd_name from Products
WHERE pd_price between 8000 and 10000
order by pd_price;

select pd_name as item from Products;
