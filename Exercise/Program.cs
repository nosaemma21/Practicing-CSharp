
using System.Collections;
var list = new SinglyLinkedList<string>();

list.AddToFront("a");
list.AddToFront("b");
list.AddToFront("c");

Console.WriteLine();

public interface ILinkedList<T> : ICollection<T>
{
    void AddToFront(T item);
    void AddToEnd(T item);
}

public class SinglyLinkedList<T> : ILinkedList<T?>
{
    //fields
    private Node<T> _head;
    private int _count;


    public int Count => _count;

    public bool IsReadOnly => false;

    public void Add(T? item)
    {
        throw new NotImplementedException();
    }

    public void AddToEnd(T? item)
    {
        throw new NotImplementedException();
    }

    public void AddToFront(T? item)
    {
        var newHead = new Node<T>(item)
        {
            Next = _head
        };
        _head = newHead;
        ++_count;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T? item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T?[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }
    public bool Remove(T? item)
    {
        throw new NotImplementedException();
    }


    public IEnumerator<T?> GetEnumerator()
    {
        foreach(var node in GetNodes())
        {
            yield return node.Value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private IEnumerable<Node<T>> GetNodes()
    {
        if(_head is null)
        {
            yield break;
        }

        Node<T>? current = _head;
        while(current is not null)
        {
            yield return current;
            current = current.Next;
        }
    }
}

public class Node<T>
{
    public T? Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T? value)
    {
        Value = value;
    }

    public override string ToString() => $"Value: {Value}, " +
        $"Next: {(Next is null ? "null" : Next.Value)}";
}




















//public class CustomLinkedList<T> : ILinkedList<T>
//{
//    private List<T>? _collectionArray;
//    private int _front = 0;

//    public CustomLinkedList(T[] collectionArray)
//    {
//        int collectionLength = collectionArray.Count();
//    }




//    public bool IsReadOnly => false;


//    public int Count
//    {
//        get {
//            var value = 0;
//            foreach (var item in _collectionArray)
//            {
//                ++value;
//            }
//            return value;
//        }
//    }

//    public void Add(T item)
//    {
//        throw new NotImplementedException();
//    }

//    public void AddToEnd(T item) => throw new NotImplementedException();

//    public void AddToFront(T item)
//    {
//        throw new NotImplementedException();
//    }

//    public void Clear()
//    {
//        _collectionArray = [];
//    }

//    public bool Contains(T item)
//    {
//        bool figure = false;
//        foreach (T coll in _collectionArray)
//        {
//            if (item.Equals(coll))
//            {
//                figure = true;
//                break;
//            }
//            figure = false;
//        }
//        return figure;

//    }

//    public void CopyTo(T[] array, int arrayIndex)
//    {
//        throw new NotImplementedException();
//    }

//    public IEnumerator<T> GetEnumerator()
//    {
//        foreach (T item in _collectionArray)
//        {
//            yield return item;
//        }
//    }

//    public bool Remove(T item)
//    {
//        throw new NotImplementedException();
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}