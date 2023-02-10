SELECT
	p.Name ProductName,
	c.Name CategoryName
FROM [Mindbox.TestTask.Sql].[dbo].[Products] p
LEFT JOIN [Mindbox.TestTask.Sql].[dbo].[ProductCategories] pc ON pc.ProductId = p.Id
LEFT JOIN [Mindbox.TestTask.Sql].[dbo].[Categories] c ON c.Id = pc.CategoryId