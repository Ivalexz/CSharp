namespace ConsoleApp8.Models;

public class Plane
{
    private int _year;
    public Plane()
    {
        this.name = "-";
        this.maker= "-";
        _year = -1;
        this.type = "-";
    }
    public Plane(string name, string maker, int year, string type)
    {
        this.name = name;
        this.maker= maker;
        _year = year;
        this.type = type;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Назва літака: {name}");
        Console.WriteLine($"Виробник: {maker}");
        Console.WriteLine($"Рік випуску: {_year}");
        Console.WriteLine($"Тип: {type}");
    }

    public void EnterInfo()
    {
        Console.WriteLine("Введіть назву літака:");
        this.name = Console.ReadLine();
        Console.WriteLine("Введіть назву виробника:");
        this.maker = Console.ReadLine();
        Console.WriteLine("Введіть рік випуску:");
        _year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть тип:");
        this.type = Console.ReadLine();
    }
    
    public string name { get; set; }
    public string maker { get; set; }

    public int year
    {
        get { return _year; }
        set
        {
            if (value > 1900 && value <= DateTime.Now.Year)
                _year = value;
            else
                Console.WriteLine("Некоректний рік!");
        }
    }
    public string type { get; set; }
}