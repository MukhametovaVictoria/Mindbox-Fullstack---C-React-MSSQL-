CREATE TABLE Category (
	id INT PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);

INSERT INTO Category 
VALUES  (1, 'Одежда'),
        (2, 'Обувь'),
        (3, 'Верхняя одежда');
