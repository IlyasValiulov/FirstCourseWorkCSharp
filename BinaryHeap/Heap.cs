namespace Курсовая;
/// <summary>
/// класс состояние
/// </summary>
public class Heap
{
    public List<int> list = new List<int>(31);
    public int MaxCount = 31;
    public int heapSize;
    public Heap(List<int> list, int heapSize)
    {
        this.list = list;
        this.heapSize = heapSize;
    }
}
