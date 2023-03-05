// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет

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

bool FindElement (int[,] inputMatrix)
{
    Console.WriteLine("Введите строку и столбец элемента, которого хотите вывести на экран: ");
    int findingElem = Convert.ToInt32(Console.ReadLine());
    int rowPosition = findingElem / 10;
    int colPosition = findingElem % 10;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (rowPosition == i && colPosition == j)
            {
                Console.WriteLine($"Элемент найден: {inputMatrix[i,j]}");
                return true;
            }
        }
    }
    Console.WriteLine("Такого элемента не существует");
    return false;
}

PrintMatrix(result);
Console.WriteLine();

FindElement(result);

