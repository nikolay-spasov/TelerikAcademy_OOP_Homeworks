using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GenericList<T> where T : IComparable
{
    private const int INITIAL_CAPACITY = 32;

    private int capacity;
    private T[] elements;

    public GenericList(int capacity)
    {
        Capacity = capacity;
        elements = new T[Capacity];
        Count = 0;
    }

    public GenericList() : this(INITIAL_CAPACITY) { }

    public void Add(T item)
    {
        if (Count == Capacity)
        {
            Resize();
        }

        elements[Count] = item;
        Count++;
    }

    private void Resize()
    {
        T[] resized = new T[Capacity * 2];
        for (int i = 0; i < Capacity; i++)
        {
            resized[i] = elements[i];
        }

        elements = resized;
        Capacity *= 2;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(
                "Index was not in bounds.");   
        }

        T[] newArr = new T[Capacity];
        for (int i = 0; i < index; i++)
        {
            newArr[i] = elements[i];
        }

        for (int i = index + 1; i < Count; i++)
        {
            newArr[i - 1] = elements[i];
        }

        elements = newArr;
        Count--;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index >= Count + 1)
        {
            throw new ArgumentOutOfRangeException(
                "Index was not in bounds.");
        }

        if (Capacity == Count)
        {
            Resize();
        }

        T[] newArr = new T[Capacity];
        for (int i = 0; i < index; i++)
        {
            newArr[i] = elements[i];
        }
        newArr[index] = item;

        for (int i = index + 1; i < Count + 1; i++)
        {
            newArr[i] = elements[i - 1];
        }

        elements = newArr;
        Count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(
                    "Index was not in bounds.");
            }
            return elements[index];
        }

        set
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(
                    "Index was not in bounds.");
            }
            elements[index] = value;
        }
    }

    public void Clear()
    {
        elements = new T[INITIAL_CAPACITY];
        Capacity = INITIAL_CAPACITY;
        Count = 0;
    }

    public int IndexOf(T value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (elements[i].CompareTo(value) == 0)
            {
                return i;
            }
        }

        return -1;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < Count; i++)
        {
            builder.AppendFormat("{0} ", elements[i]);
        }

        return builder.ToString();
    }

    public int Capacity
    {
        get { return this.capacity; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Capacity cannot be negative.");
            }
            this.capacity = value;
        }
    }

    public int Count { get; private set; }
}