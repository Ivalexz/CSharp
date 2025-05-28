//task1
/*Console.WriteLine("Введіть число від 1 до 100: ");
int num= Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 100)
{
    if (num % 3 == 0 && num % 5 == 0) {
        Console.WriteLine("Fizz Buzz");
    }
    else if (num % 5 == 0) {
        Console.WriteLine("Buzz");
    }
    else if (num % 3 == 0) {
        Console.WriteLine("Fizz");
    }
    else {
        Console.WriteLine(num);
    }
}
else
{
    Console.WriteLine("Помилка! Значення не в діапазоні від 1 до 100");
}*/

//task2
/*Console.WriteLine("Введіть число: ");
int num= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть відсоток: ");
double percent= Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Результат: {num*percent/100}");*/

//task3
/*string result=" ";
for (int i = 0; i < 4; i++)
{
    Console.Write("Введіть число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    result+=num;
}
Console.WriteLine(result);*/

//task4
/*Console.Write("Введіть шестизначне число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num.ToString().Length == 6) {
    Console.Write("Введіть перший розряд: ");
    int n1 = Convert.ToInt32(Console.ReadLine()) -1;
    Console.Write("Введіть другий розряд: ");
    int n2 = Convert.ToInt32(Console.ReadLine()) -1;
    string num_string = num.ToString();
    if (n1 >= 0 && n1 <= 5 && n2 >= 0 && n2 <= 5)
    {
        string result = "";

        for (int i = 0; i < num_string.Length; i++)
        {
            if (i == n1) result += num_string[n2];
            else if (i == n2) result += num_string[n1];
            else result += num_string[i];
        }

        Console.WriteLine($"Число після обміну: {result}");
    }
    else {
        Console.WriteLine("Помилка. Розряд повинен бути від 1 до 6.");
    }
}
else {
    Console.WriteLine("Помилка. Число не шестизначне");
}*/

//task5
/*Console.WriteLine("Введіть дату:");
Console.Write("День :");
int day=Convert.ToInt32(Console.ReadLine());
Console.Write("Місяць:");
int month=Convert.ToInt32(Console.ReadLine());
Console.Write("Рік :");
int year=Convert.ToInt32(Console.ReadLine());

string season;
if (month >= 1 && month <= 12)
{
    if (month == 12 || month == 1 || month == 2)
        season = "Winter";
    else if (month >= 3 && month <= 5)
        season = "Spring";
    else if (month >= 6 && month <= 8)
        season = "Summer";
    else
        season = "Autumn";
    
    //алгоритм зеллера, вічний календар
    if (month < 3)
    {
        month += 10;
        year--;
    }
    else {
        month -= 2;
    }

    int result = ((day + 31 * month/12 + year + year / 4 - year / 100 + year / 400) % 7);

    string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


    Console.WriteLine($"{season} {days[result]}");
}
else
{
    Console.WriteLine("Такого місця неіснує");
}*/

//task6
/*int usersAnswer=0;
while (usersAnswer!=3)
{
    Console.Write("1 - конвертувати у Цельсій\n2 - конвертувати у Фаренгейт\n3 - вийти\nВаш вибір: ");
    usersAnswer = Convert.ToInt32(Console.ReadLine());
    if (usersAnswer == 1)
    {
        double f;
        Console.WriteLine("Введіть температуру у Фаренгейтах: ");
        f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Температура у Цельсіях: {(f - 32) / 1.8000}C");
    }

    else if (usersAnswer == 2)
    {
        double c;
        Console.WriteLine("Введіть температуру у Цельсіях: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Температура у Фаренгейтах: {1.8000*c+32}F");
    }
    else if (usersAnswer == 3)
    {
        Console.WriteLine("Вихід...");
        break;
    }
    else
    {
        Console.WriteLine("Помилка. Такого варіанту немає в меню. Спробуйте ще раз");
    }
}*/

//task7
Console.Write("Введіть початок діапазону: ");
int start=Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть кінець діапазону: ");
int end=Convert.ToInt32(Console.ReadLine());
if (start > end)
{
    int tmp=start;
    start=end;
    end=tmp;
}
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}