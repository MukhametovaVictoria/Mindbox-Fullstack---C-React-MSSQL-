CREATE TABLE ProductsCategory (
	products_id  INT not null,
	category_id INT not null
);

INSERT INTO ProductsCategory
VALUES  (1, 1),
	(1, 3),
	(2, 1),
	(3, 2),
    (4, 2),
    (5, 1);
