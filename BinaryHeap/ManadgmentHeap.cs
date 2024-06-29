namespace Курсовая;
/// <summary>
/// класс управленец
/// </summary>
public class ManadgmentHeap
{
    private Heap? heap;
    private RealizationHeap? realizationHeap;
    private Storage? storage;
    public int currentStorageIndex;
    public ManadgmentHeap(Storage? storage)
    {
        this.storage = storage; 
    }
    public int addElement(Element? element)
    {
        if (element == null) return currentStorageIndex;
        if (storage?.Count == 0)
        {
            heap = new Heap(new List<int>(31), 0);
            storage?.addHeap(heap);
        }
        else
        {
            heap = storage?.getHeap(storage.Count - 1);
        }
        currentStorageIndex = storage.Count;
        realizationHeap = new RealizationHeap();
        realizationHeap.setHeap(heap);
        foreach (Heap item in realizationHeap.addElement(element))
        {
            storage?.addHeap(item);
        }
        return currentStorageIndex;
    }
    public int ForwardStep()
    {
        if (storage?.Count == 0 || currentStorageIndex >= storage?.Count) return -1;
        else if (currentStorageIndex < storage?.Count - 1)
            ++currentStorageIndex;
        return currentStorageIndex;
    }
    public int BackStep()
    {
        if (storage?.Count == 0 || currentStorageIndex > storage?.Count) return -1;
        else if (currentStorageIndex > 0)
            --currentStorageIndex;
        return currentStorageIndex;
    }
    public int ForwardSkip()
    {
        currentStorageIndex = storage.Count - 1;
        return currentStorageIndex;
    }
    public int BackSkip()
    {
        currentStorageIndex = 0;
        return currentStorageIndex;
    }
}
