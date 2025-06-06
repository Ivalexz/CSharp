using ConsoleApp8.Models;

/*Plane first_plane = new Plane("Kitty Hawk", "брати Орвілл та Вілбур Райт", 1903, "експериментальний літак");
first_plane.ShowInfo();

Plane plane = new Plane();
plane.EnterInfo();
plane.ShowInfo();*/


/*Matrix matrix1 = new Matrix();
matrix1.ShowInfo();
matrix1.EnterInfo();
matrix1.ShowInfo();*/

Matrix matrix2 = new Matrix(5,4);
matrix2.EnterInfo();
matrix2.ShowInfo();
Console.WriteLine($"Найменше значення матриці: {matrix2.CalculateMin()}");
Console.WriteLine($"Найбільше значення матриці: {matrix2.CalculateMax()}");