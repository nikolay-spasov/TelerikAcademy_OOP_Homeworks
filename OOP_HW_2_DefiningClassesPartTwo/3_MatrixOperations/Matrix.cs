using System;
using System.Text;

public class Matrix<T> where T : IComparable
{
    private T[,] _matrix;

    public Matrix(int n, int m)
    {
        this._matrix = new T[n, m];
    }

    public Matrix(T[,] matrix)
    {
        this._matrix = new T[matrix.GetLength(0), matrix.GetLength(1)];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                this._matrix[row, col] = matrix[row, col];
            }
        }
    }

    public Matrix(Matrix<T> matrix)
    {
        _matrix = new T[matrix._matrix.GetLength(0), matrix._matrix.GetLength(1)];
        for (int row = 0; row < matrix._matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix._matrix.GetLength(1); col++)
            {
                _matrix[row, col] = matrix[row, col];
            }
        }
    }

    public T this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid row or col");
            }
            return _matrix[row, col];
        }

        set
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid row or col");
            }
            _matrix[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new InvalidOperationException(
                "Cannot add matrices with different number of rows or cols.");
        }

        Matrix<T> result = new Matrix<T>((dynamic)a._matrix);

        for (int row = 0; row < result.Rows; row++)
        {
            for (int col = 0; col < result.Cols; col++)
            {
                result[row, col] = result[row, col] + (dynamic)b._matrix[row, col];
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new InvalidOperationException(
                "Cannot add matrices with different number of rows or cols.");
        }

        Matrix<T> result = new Matrix<T>(a);

        for (int row = 0; row < result.Rows; row++)
        {
            for (int col = 0; col < result.Cols; col++)
            {
                result[row, col] = result[row, col] - (dynamic)b._matrix[row, col];
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
    {
        if (a.Cols != b.Rows)
        {
            throw new InvalidOperationException(
                "Matrices are not suitable for multiplication.");
        }

        int n = a.Rows;
        int m = b.Cols;
        Matrix<T> result = new Matrix<T>(n, m);

        for (int i = 0; i < result.Rows; i++)
        {
            for (int j = 0; j < result.Cols; j++)
            {
                for (int k = 0; k < a.Cols; k++)
                {
                    result[i, j] += ((dynamic)a[i, k] * (dynamic)b[k, j]);
                }
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (!matrix[row, col].Equals(0))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (matrix[row, col].Equals(0))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Cols; col++)
            {
                builder.AppendFormat("{0, 3} ", _matrix[row, col]);
            }

            if (row != Rows - 1)
            {
                builder.AppendLine();
            }
        }

        return builder.ToString();
    }

    public int Rows
    {
        get { return _matrix.GetLength(0); }
    }

    public int Cols
    {
        get { return _matrix.GetLength(1); }
    }

}

