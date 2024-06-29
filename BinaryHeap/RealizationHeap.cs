namespace Курсовая;
/// <summary>
/// класс реализатор
/// </summary>
public class RealizationHeap
{
    private Heap? _heap;
    public IEnumerable<Heap> addElement(Element element)
    {
        if (_heap == null) yield return null;
        if (_heap.heapSize == _heap.MaxCount) yield return getHeap();
        int value = element.number;
        if (_heap.heapSize == 0)
        {
            _heap.list.Add(value);
            ++_heap.heapSize;
            yield return getHeap();
        }
        else
        {
            int index = _heap.heapSize++;
            _heap.list.Add(value);
            int parent = (index - 1) / 2;
            yield return getHeap();
            while (index > 0 && _heap.list[parent] > _heap.list[index])
            {
                int temp = (int)_heap.list[index];
                _heap.list[index] = _heap.list[parent];
                _heap.list[parent] = temp;
                index = parent;
                parent = (index - 1) / 2;
                yield return getHeap();
            }
        }
    }
    public Heap? getHeap()
    {
        List<int> list = new List<int>();
        foreach (int i in _heap.list)
        {
            list.Add(i);
        }
        return new Heap(list, _heap.heapSize);
    }
    public void setHeap(Heap obj)
    {
        List<int> list = new List<int>();
        foreach (int i in obj.list)
        {
            list.Add(i);
        }
        _heap = new Heap(list, obj.heapSize); 
    }
}
