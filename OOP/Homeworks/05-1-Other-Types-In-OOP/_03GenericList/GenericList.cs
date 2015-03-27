using System;
using System.Text;

[Version(1, 3)]
public class GenericList<T> where T : IComparable<T>
{
    protected const int DefaultCapacity = 16;
    private T[] elements;
    private int count;

    // constructor
    public GenericList(int capacity = DefaultCapacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(
                "Invalid capacity value! Please create a generic list with a capacity bigger than zero!");
        }

        this.elements = new T[capacity];
        this.count = 0;
    }

    // properties
    public int Count
    {
        get { return this.count; }
    }

    public int Capacity 
    {
        get { return this.elements.Length; } 
    }

    // indexer
    public T this[int index]
    {
        get { return this.elements[index]; }
    }

    // methods that modify the list or return elements and info about them from the list
    public void AddELement(T element)
    {
        if (!this.HasCapacity())
        {
            this.DoubleCapacity();
        }

        this.elements[this.Count] = element;
        this.count++;
    }

    public void RemoveByIndex(int index)
    {
        this.ValidateIndex(index);
        T[] newElements = new T[this.Capacity];
        for (int i = 0, j = 0; i < this.Count; i++, j++)
        {
            if (i == index)
            {
                i++;
            }

            newElements[j] = this.elements[i];
        }

        this.elements = newElements;
        this.count--;
    }

    public void InsertAtIndex(T element, int index)
    {
        this.ValidateIndex(index);
        T[] newElements;

        /*
            * Performance is better when I create a new array with double 
            * the capacity of the old array, instead of fist doubling the old array and then copying it.
            * This is why i have separate methods checking and doubling the capacity: 
            * hasCapacity() and DoubleCapacity(). 
            */

        if (!this.HasCapacity())
        {
            newElements = new T[this.Capacity * 2];
        }
        else
        {
            newElements = new T[this.Capacity];
        }

        for (int i = 0, j = 0; i < this.Count; i++, j++)
        {
            if (i == index)
            {
                newElements[j] = element;
                j++;
            }

            newElements[j] = this.elements[i];
        }

        this.elements = newElements;
        this.count++;
    }

    public void ClearList()
    {
        this.elements = new T[DefaultCapacity];
        this.count = 0;
    }

    public int FindIndex(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(element) == 0)
            {
                return i;
            }
        }

        return -1;
    }

    public bool ContainsElement(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public T Min()
    {
        if (this.Count == 0)
        {
            throw new NotImplementedException(
                "The method for finding minimum value cannot be implemented on an empty list");
        }

        var min = this.elements[0];

        for (int i = 0; i < this.Count; i++)
        {
            if (min.CompareTo(this.elements[i]) > 0)
            {
                min = this.elements[i];
            }
        }

        return min;
    }

    public T Max()
    {
        if (this.Count == 0)
        {
            throw new NotImplementedException(
                "The method for finding minimum value cannot be implemented on an empty list");
        }

        var max = this.elements[0];

        for (int i = 0; i < this.Count; i++)
        {
            if (max.CompareTo(this.elements[i]) < 0)
            {
                max = this.elements[i];
            }
        }

        return max;
    }

    private void DoubleCapacity()
    {
        T[] newElements = new T[this.Capacity * 2];

        for (int i = 0; i < this.Count; i++)
        {
            newElements[i] = this.elements[i];
        }

        this.elements = newElements;
    }

    // methods for validation
    private bool HasCapacity()
    {
        return this.Capacity >= this.count + 1;
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new ArgumentOutOfRangeException(
                "Invalid index! Please enter an index bigger than zero or smaller than the size of the generic list");
        }
    }

    public override string ToString()
    {
        if (this.Count == 0)
        {
            return null;
        }

        StringBuilder result = new StringBuilder("[ ");
        for (int i = 0; i < this.Count - 1; i++)
        {
            result.Append(this.elements[i] + ", ");
        }

        result.Append(this.elements[this.Count - 1]);
        result.Append(" ]");

        return result.ToString();
    }
}