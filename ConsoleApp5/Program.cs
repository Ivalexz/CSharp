Random random = new Random();

//task1

/*int[] A = new int[5];
double[,] B = new double[3, 4];

double min=A[0], max=A[0], sum=0, mult_numbers=1;

int sum_a = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Введіть ціле число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    A[i] = num;
    sum += num;
    mult_numbers*=num;
    if (num > max)
    {
        max = num;
    }

    if (num < min)
    {
        min = num;
    }

    if (i % 2 == 0)
    {
        sum_a+=num;
    }
}

double sum_b = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        double num=random.NextDouble() * 100;
        B[i, j] = Math.Round(num, 1);
        sum += num;
        mult_numbers*=num;
        if (num > max)
        {
            max = num;
        }

        if (num < min)
        {
            min = num;
        }
        if (j % 2 != 0)
        {
            sum_b+=num;
        }
    }
}

Console.WriteLine("Одновимірний масив А: ");
for (int i = 0; i < A.Length; i++)
{
    Console.Write($"{A[i]} ");
}
Console.WriteLine();
Console.WriteLine("Двовимірний масив B у вигляді матриці: ");
for (int i = 0; i < 3; i++)
{
    Console.Write("{ ");
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{B[i,j]} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

Console.WriteLine($"Сума усіх елементів: {Math.Round(sum, 1)}");
Console.WriteLine($"Мінімальний елемент: {Math.Round(min, 1)}");
Console.WriteLine($"Максимальний елемент: {Math.Round(max,1)}");
Console.WriteLine($"Добуток усіх елементів: {Math.Round(mult_numbers,1)}");
Console.WriteLine($"Сума парних елементів масиву А: {sum_a}");
Console.WriteLine($"Сума непарних стовпців масиву B: {Math.Round(sum_b,1)}");*/


//task2

/*int[,] arr= new int [5,5];

int min = arr[0, 0];
int max = arr[0, 0];

int min_index = 0;
int max_index = 0;

int sum = 0;

Console.WriteLine("Масив: ");
for (int i = 0; i < 5; i++)
{
    Console.Write("{ ");
    for (int j = 0; j < 5; j++)
    {
        int num=random.Next(-100,100);
        Console.Write($"{num} ");
        arr[i, j] = num;
        if (min>num)
        {
            min = num;
            min_index = i * 5 + j;
        }
        if (max < num)
        {
            max=num;
            max_index = i * 5 + j;
        }
    }
    Console.Write("}");
    Console.WriteLine();
}

int start_index = Math.Min(min_index, max_index);
int end_index = Math.Max(min_index, max_index);

for (int i = start_index+1; i < end_index; i++)
{
    int row = i / 5;
    int column = i % 5;
    sum += arr[row, column];
}

Console.WriteLine();
Console.WriteLine($"Сума елементів від {min} до {max}: {sum}");*/

//task3

string alph="АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

void menu()
{
    Console.WriteLine("Введіть рядок: ");
    string users_line=Console.ReadLine();

    while (true)
    {
        Console.WriteLine($"1 - зашифрувати\n2 - розшифрувати");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            to_cesar(users_line);
            break;
        }
        else if (choice == 2)
        {
            from_cesar(users_line);
            break;
        }
        else
        {
            Console.WriteLine("Такої відповіді неіснує");
        }
    }
}
void to_cesar(string users_line)
{
    string answer = "";
    for (int i = 0; i < users_line.Length; i++)
    {
        int index = alph.IndexOf(char.ToUpper(users_line[i]));
        if (index == -1)
        {
            answer += users_line[i];
        }
        else
        {
            if (index + 3 >= alph.Length)
            {
                answer += alph[index + 3 - alph.Length];
            }
            else
            {
                answer += alph[index + 3];
            }
        }
    }

    Console.WriteLine($"Зашифровано: {answer}");
}

void from_cesar(string users_line)
{
    string answer = "";
    for (int i = 0; i < users_line.Length; i++)
    {
        int index = alph.IndexOf(char.ToUpper(users_line[i]));

        if (index == -1)
        {
            answer += users_line[i];
        }
        else
        {
            if (index - 3 < 0)
            {
                answer += alph[alph.Length + (index - 3)];
            }
            else
            {
                answer += alph[index - 3];
            }
        }
    }

    Console.WriteLine($"Розшифровано: {answer}");
}

menu();