using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeList<T> : IList<T>
{

    T[] data = new T[1000];
    int endIndex = 0;

    

    public T this[int index] 
    { 
        get {
            if (index >= endIndex) throw new System.NotImplementedException();
            return data[index]; 
            }
        set {
            data[index] = value;
            }
    }

    public int Count => endIndex;

    public bool IsReadOnly => throw new System.NotImplementedException();

    public void Add(T item)
    {
        data[endIndex] = item;
        endIndex++;
    }

    public void Clear()
    {
        endIndex = 0;
    }

    public bool Contains(T item)
    {
        for (int i = 0 ; i < endIndex ; i++)
        {
            if (data[i].Equals(item)) // equiv. de ==
            {
                return true;
            } 
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public int IndexOf(T item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, T item)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

