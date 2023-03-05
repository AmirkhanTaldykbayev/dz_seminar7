// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] result = GetMatrix(3,4);
PrintMatrix(result);
Console.WriteLine();


string Average (int[,] inputMatrix)
{   
    string result = "";
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {  
        double resultForCols = 0;
        double sum = 0;
        for (int j = 0; j < inputMatrix.GetLength(0); j++)
        {
            sum += inputMatrix[j,i];
            resultForCols = Math.Round((sum / inputMatrix.GetLength(0)),1);
        }
        Console.WriteLine($"Сумма в  {i} столбце: {sum}");
        Console.WriteLine($"Среднее арифметическое: {resultForCols}");
    }
    return result;
}

Console.WriteLine(Average(result));
    