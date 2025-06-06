namespace ConsoleApp8.Models;

public class Matrix
{
    private int[,] matrix;
    private int rows;
    private int columns;

    public Matrix()
    {
        this.rows = 2;
        this.columns = 2;

        this.matrix = new int[rows, columns]; //дефолтний розмір матриці 2х2
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i,j]=0; //вся матриця автоматом заповнюється нулями
            }
        }
    }
    public Matrix(int rows, int columns)
    {
        this.rows=rows;
        this.columns=columns;
        this.matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i,j]=0; //вся матриця автоматом заповнюється нулями
            }
        }
    }
    
    
    public void EnterInfo()
    {
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Введіть число: ");
                int num=int.Parse(Console.ReadLine());
                matrix[i,j] = num;
            }
        }
    }

    public void ShowInfo()
    {
        for (int i = 0; i<rows; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine("}");
        }
    }

    public int CalculateMin()
    {
        int min=matrix[0,0];
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] < min)
                {
                    min=matrix[i, j];
                }
            }
        }
        return min;
    }
    
    public int CalculateMax()
    {
        int max=matrix[0,0];
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] > max)
                {
                    max=matrix[i, j];
                }
            }
        }
        return max;
    }
    
}