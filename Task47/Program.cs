
Console.WriteLine("Введите размер 2х мерного массива");
int M = ReadInt("M = ");
int N = ReadInt("N = ");

float[,] array = new float[M, N];

RandomizeArray(array);

PrintArray(M, N, array);

void RandomizeArray(float[,] array)
{
    Random rnd = new Random();
    for (int x = 0; x < M; x++)
        for (int y = 0; y < N; y++)
            array[x, y] = (float)rnd.NextDouble() * 10;
}

Console.WriteLine($"Количество чисел больше 0: ");


int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

static void PrintArray(int M, int N, float[,] array)
{
    for (int x = 0; x < M; x++)
    {
        for (int y = 0; y < N; y++)
            Console.Write($"{array[x, y],5:0.##} ");
        Console.WriteLine("");
    }
}