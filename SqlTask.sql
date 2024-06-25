/*Создание базы*/
Create Table Products (Id INT PRIMARY KEY, ProductName varchar(10))
Create Table Categories (Id INT PRIMARY KEY, CategoryName varchar(10))
Create Table Product_categories (Id INT PRIMARY KEY, Product_id int, Category_id int, 
FOREIGN KEY (Product_id) references Products(Id), 
FOREIGN KEY (Category_id) references Categories(Id))
Insert into Products values (1,'Pencil'),(2,'Apple'),(3,'Table'),(4,'Sun');
Insert into Categories values (1,'Wooden'),(2,'Edible'),(3,'Furniture');
Insert into Product_categories values (1,1,1),(2,2,2),(3,3,1),(4,3,3);

/*Запрос */
SELECT Products.ProductName, Categories.CategoryName from Products 
Left Join Product_categories on Products.Id=product_id 
Left Join Categories on Product_categories.category_id = Categories.Id
Group by Products.ProductName, Categories.CategoryName