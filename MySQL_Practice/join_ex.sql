CREATE TABLE customer
			(
			customerID varchar(20) primary key,
            customerName varchar(20),
            Address varchar(50)
            );
CREATE TABLE orders
			(
            orderID int PRIMARY KEY,
            customerID varchar(20),
            OrderDate datetime,
            order_Detail varchar(50)
            );

CREATE TABLE supplier
			(
            suplierID varchar(20) primary key,
            suplierName varchar(20),
            Address varchar(50)
            );

INSERT INTO customer(customerID, customerName, Address) VALUES
			('jungsw' , '정승우', '서울 노원구'),
            ('peace' , '김평화', '서울 성북구'),
            ('sangki' , '김상기', '서울 강남구'),
            ('hyunsu' , '나현수', '서울 강북구');
            
INSERT INTO orders(orderID, customerID, OrderDate, order_Detail) VALUES
			(1, 'jungsw', '2025-10-30', '옷'),
            (2, 'peace', '2025-10-31', '컴퓨터'),
            (3, 'sangki', '2025-09-30', '책');

INSERT INTO supplier(suplierID, suplierName, Address) VALUES
			('AAA', '정승우', '서울 노원구'),
            ('AAB', '김평화', '서울 성북구'),
            ('AAC', '김상기', '서울 강남구');
            
-- INNER JOIN 
SELECT orders.orderID, customer.customerName ,customer.Address, orders.orderDate, orders.order_Detail
FROM orders
INNER JOIN customer ON orders.customerID = customer.customerID
order by customerName desc;

-- LEFT JOIN
SELECT customer.customerName as 구매자 , orders.orderID as 주문번호
from customer
LEFT JOIN orders on customer.customerID = orders.customerID
order by customer.customerName;

select Address from customer
union 
select Address from supplier;



            