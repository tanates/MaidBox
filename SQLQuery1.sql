SELECT
    p.ProductName,
    ISNULL(c.CategoryName, 'Без категории') AS CategoryName
FROM
    Products p
LEFT JOIN
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN
    Categories c ON pc.CategoryId = c.CategoryId;