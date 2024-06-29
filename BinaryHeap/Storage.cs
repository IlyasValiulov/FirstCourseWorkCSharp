namespace Курсовая;
/// <summary>
/// класс хранилище
/// </summary>
public class Storage
{
    public List<Heap>? _collection = new List<Heap>();
    public int Count => _collection.Count;
    public bool addHeap(Heap obj)
    {
        if (obj == null) return false;
        _collection?.Add(obj);
        return true;
    }
    public Heap getHeap(int index)
    {
        if (index < 0 || index >= Count) return null;
        return _collection[index];
    }
    public IEnumerable<Heap> GetItems()
    {
        for (int i = 0; i < Count; ++i)
        {
            yield return _collection[i];
        }
    }
    //Ключевое слово, с которого должен начинаться файл
    private readonly string _collectionKey = "HeapStorages";
    //Разделитель для записи между количество элементов и элементами
    private readonly string _separatorForKeyValue = "|";
    //Разделитель для записей коллекции данных в файл
    private readonly string _separatorItems = ";";
    public bool SaveData(string filename)
    {
        if (Count == 0)
        {
            return false;
        }
        if (File.Exists(filename))
        {
            File.Delete(filename);
        }
        using FileStream fs = new(filename, FileMode.Create);
        using (BinaryWriter writer = new BinaryWriter(fs)) 
        {
            writer.Write(_collectionKey);
            writer.Write(Count);
            foreach (Heap item in GetItems())
            {
                writer.Write(item.heapSize);
                foreach (int i in item.list)
                {
                    writer.Write(i);
                }
            }
            writer.Close();
        }
        return true;
    }
    public bool LoadData(string filename)
    {
        if (!File.Exists(filename))
        {
            return false;
        }
        using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
        {
            string namekey = reader.ReadString();
            if (namekey != _collectionKey) return false;
            _collection?.Clear();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                int heapsize = reader.ReadInt32();
                List<int> list = new List<int>();
                for (int j = 0; j < heapsize; j++)
                {
                    list.Add(reader.ReadInt32());
                }
                _collection?.Add(new Heap(list, heapsize));
            }
        }
        return true;
    }
}
