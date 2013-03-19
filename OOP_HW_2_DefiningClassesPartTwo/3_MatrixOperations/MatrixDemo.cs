using System;

class MatrixDemo
{
    static void Main()
    {
        int[,] m1 = new int[,]
        {
            { 1, 2, 3},
            { 4, 5, 6}
        };

        int[,] m2 = new int[,]
        {
            {4, 3, 2 },
            {1, 0, 3 }
        };

        Matrix<int> firstMatrix = new Matrix<int>(m1);
        Matrix<int> secondMatrx = new Matrix<int>(m2);

        Console.WriteLine("First matrix: ");
        Console.WriteLine(firstMatrix);
        Console.WriteLine("Second matrix: ");
        Console.WriteLine(secondMatrx);
        Console.WriteLine("========================================");

        Matrix<int> matrixAdditionResult = firstMatrix + secondMatrx;
        Console.WriteLine("First matrix + Second matrix = ");
        Console.WriteLine(matrixAdditionResult);

        firstMatrix = new Matrix<int>(m1);
        secondMatrx = new Matrix<int>(m2);

        Matrix<int> matrixSubtractionResult = firstMatrix - secondMatrx;
        Console.WriteLine("First matrix - Second matrix = ");
        Console.WriteLine(matrixSubtractionResult);

        m2 = new int[,]
        {
            { 4, 1 },
            { 3, 0 },
            { 2, 3 }
        };

        secondMatrx = new Matrix<int>(m2);
        Console.WriteLine("Changing Second matrix to: ");
        Console.WriteLine(secondMatrx);

        Console.WriteLine("=============================================");
        Matrix<int> matrixMultiplicationResult = firstMatrix * secondMatrx;
        Console.WriteLine("First matrix * Second matrix = ");
        Console.WriteLine(matrixMultiplicationResult);

        bool matrixContainsZeroesOnly = false;
        if (matrixAdditionResult)
        {
            matrixContainsZeroesOnly = true;
        }

        Console.WriteLine("The result of First matrix * Second matrix contains only zeroes -> {0}",
            matrixContainsZeroesOnly);
    }
}

