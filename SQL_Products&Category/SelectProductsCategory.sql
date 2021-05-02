
SELECT P.name, C.name
FROM Products P
LEFT JOIN ProductsCategory PC
	ON P.id = PC.products_id
LEFT JOIN Category C
	ON PC.category_id = C.id;