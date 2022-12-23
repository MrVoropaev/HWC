// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Правило умножения матриц Произведение матрицы A AA размера m × n m\times nm×n и матрицы B BB размера 
// n × k n\times kn×k — это матрица C CC размера m × k m\times km×k, в которой элемент c i j c_{ij}c ij
// ​равен сумме произведений элементов i ii строки матрицы A AA на соответствующие элементы j jj столбца матрицы B : 
// c i j = a i 1 b 1 j + a i 2 b 2 j + . . . 
// + a i n b n j B: c_{ij}=a_{i1}b_{1j}+a_{i2}b_{2j}+...+a_{in}b_{nj}B:c ij​=a i1​b 1j​+a i2​b 2j​+...+a in​b nj​. 

void CompositionMatrix ()
{
    int m = new Random().Next(3,4);
    int n = new Random().Next(3,4);
    int p = new Random().Next(3,4);

    int[,] matrix1 = new int[m,n];
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix1[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix1[i,j]} ");
        }
        Console.WriteLine();
    }

    int[,] matrix2 = new int[n,p];
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < p; j++)
        {
            matrix2[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix2[i,j]} ");
        }
        Console.WriteLine();
    }

    int[,] CompositionMtx = new int[m,p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            int matrixSumm = 0;
            for (int k = 0; k < p; k++)
            {
                matrixSumm += matrix1[i,k] * matrix2[k,j];
            }
            CompositionMtx[i,j] = matrixSumm;
        }
    }
    Console.WriteLine("Произведение матриц");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            Console.Write($"{CompositionMtx[i,j]} ");
        }
        Console.WriteLine();
    }
}
CompositionMatrix();