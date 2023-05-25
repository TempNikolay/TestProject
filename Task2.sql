SELECT Product.Name as Продукт, Category.Name AS Категория 
FROM Product
LEFT JOIN Product_Category ON Product.Id = Product_Category.Id_Product
LEFT JOIN Category ON Category.Id = Product_Category.Id_Category