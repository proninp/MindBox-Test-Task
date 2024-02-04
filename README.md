# MindBox-Test-Task
Данный репозиторий содержит решение тестового задания для компании MindBox

## Задание №1
Напишите на `C#` библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в `compile-time`
* Проверку на то, является ли треугольник прямоугольным

### Решение
[Код программы](/GeometryLibrary)
Пример работы библиотеки
```cs
// Вычисление площади круга
double circleRadius = 5;
Circle circle = new Circle(circleRadius);
double circleArea = AreaCalculator.Calculate(circle);
Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна: {circleArea}");

// Вычисление площади треугольника
double side1 = 3;
double side2 = 4;
double side3 = 5;
Triangle triangle = new Triangle(side1, side2, side3);
double triangleArea = AreaCalculator.Calculate(triangle);
Console.WriteLine($"Площадь треугольника со сторонами {side1}, {side2}, {side3} равна: {triangleArea}");
bool isRectangular = triangle.IsRectangular();
Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, {side3} является прямоугольным: {isRectangular}");
```
 
## Задание №2
В базе данных `MS SQL Server` есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите `SQL` запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Решение
[DDL](/SQL/DDL.sql)
[DML](/SQL/DML.sql)
```sql
SELECT p.[Name] [Product Name]
       , ISNULL(pc.[Name], '') [Category Name]
FROM [dbo].[Product] p
LEFT JOIN [dbo].[Product Category Relation] pcr ON p.[Id] = pcr.[Product Id]
LEFT JOIN [dbo].[Product Category] pc ON pcr.[Category Id] = pc.[Id]
```