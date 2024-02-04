DELETE FROM [dbo].[Product Category Relation];
DELETE FROM [dbo].[Product];
DELETE FROM [dbo].[Product Category];

INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name])
     VALUES
           (1
            ,'Product 1')
		   ,(2
            ,'Product 2')
		  ,(3
            ,'Product 3')
		  ,(4
            ,'Product 4')
		  ,(5
            ,'Product 5');

INSERT INTO [dbo].[Product Category]
           ([Id]
           ,[Name])
     VALUES
           (1
            ,'Category 1')
		   ,(2
            ,'Category 2')
		  ,(3
            ,'Category 3')
		  ,(4
            ,'Category 4')
		  ,(5
            ,'Category 5');


INSERT INTO [dbo].[Product Category Relation]
           ([Product Id]
           ,[Category Id])
     VALUES
           (1, 1)
		   ,(1, 2)
		   ,(2, 1)
		   ,(3, 3)
		   ,(4, 4)
		   ,(4, 5);
		   
SELECT p.[Name] [Product Name]
       , ISNULL(pc.[Name], '') [Category Name]
FROM [dbo].[Product] p
LEFT JOIN [dbo].[Product Category Relation] pcr ON p.[Id] = pcr.[Product Id]
LEFT JOIN [dbo].[Product Category] pc ON pcr.[Category Id] = pc.[Id]