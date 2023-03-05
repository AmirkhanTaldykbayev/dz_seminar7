// Доп. Задачка - сумма элементов главной диагонали и если что, смотрите 400 задач. 

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
int[,] result = GetMatrix(5,5);
PrintMatrix(result);
Console.WriteLine();
/* 
// Первый способ (прямой)
int DiagonalSum (int[,] inputMatrix)
{
    int sum = 0;
    int i = 0;
    int j = 0;
    int size1 = inputMatrix.GetLength(0);
    int size2 = inputMatrix.GetLength(1);
    while (i < size1 && j < size2)
    {
        sum += inputMatrix[i,j];
        i++;
        j++;
    }
    return sum;
}

int res = DiagonalSum(result);
Console.WriteLine(res);
*/
// Первый способ (через цикл "while")

// Второй способ (через цикл "for")
int DiagonalSum (int[,] inputMatrix)
{
    int sum = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if(j == i)
            {
                sum += inputMatrix[i,j];
            }
        }
    }
    return sum;
}

int res = DiagonalSum(result);
Console.WriteLine(res);