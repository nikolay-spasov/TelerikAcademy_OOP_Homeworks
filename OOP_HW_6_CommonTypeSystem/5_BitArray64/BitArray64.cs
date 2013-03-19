using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BitArray64 : IEnumerable<int>
{
    private const int SIZE = 64;

    private ulong arr;

    public BitArray64(ulong bits = 0UL)
    {
        arr = bits;
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= SIZE)
            {
                throw new ArgumentOutOfRangeException(string.Format(
                    "Index must be in the range [0, {0})", SIZE));
            }

            ulong mask = 1UL << index;
            if ((mask & arr) != 0UL)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            if (index < 0 || index >= SIZE)
            {
                throw new ArgumentOutOfRangeException(string.Format(
                    "Index must be in the range [0, {0})", SIZE));
            }

            if (value != 0 && value != 1)
            {
                throw new ArgumentOutOfRangeException(
                    "Value must be 0 or 1.");
            }

            if (value == 0)
            {
                ulong mask = 1UL << index;
                arr = arr & (~mask);
            }
            else if (value == 1)
            {
                ulong mask = 1UL << index;
                arr |= mask;
            }
        }
    }

    public static bool operator ==(BitArray64 first, BitArray64 second)
    {
        return BitArray64.Equals(first, second);
    }

    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !(BitArray64.Equals(first, second));
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = SIZE - 1; i >= 0; i--)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override bool Equals(object obj)
    {
        BitArray64 other = obj as BitArray64;

        if (other == null)
        {
            return false;
        }

        if (this.arr != other.arr)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return arr.GetHashCode();
    }

    public ulong Value
    {
        get { return this.arr; }
        set { this.arr = value; }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder(64);

        foreach (var bit in this)
        {
            builder.Append(bit);
        }

        return builder.ToString();
    }
}
