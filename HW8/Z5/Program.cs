// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] matrix = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= 16)
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < 4 - 1)
    j++;
  else if (i < j && i + j >= 4 - 1)
    i++;
  else if (i >= j && i + j > 4 - 1)
    j--;
  else
    i--;
}

void FillMatrix (int[,] matrix)
{
  for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      if (matrix[i,j] / 10 <= 0)
      Console.Write($" {matrix[i,j]} ");

      else Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
  }
}

FillMatrix(matrix);