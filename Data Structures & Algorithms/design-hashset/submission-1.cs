public class MyHashSet {

    private List <int>[] bucket;
    int size =10000;
    public MyHashSet() {
        bucket = new List<int>[10000]; 
        for (int i = 0; i < size; i++)
         {
            bucket[i] = new List<int>();
        }
    }
    public int getIndex(int n)
    {
        return n%size;
    }
    
    public void Add(int key) {
        int index = getIndex(key);
        if(!bucket[index].Contains(key))
        {
            bucket[index].Add(key);
        }
    }
    
    public void Remove(int key) {
        int index = getIndex(key);
        if(bucket[index].Contains(key))
        {
            bucket[index].Remove(key);
        }
    }
    
    public bool Contains(int key) {
        int index = getIndex(key);
        if(bucket[index].Contains(key))
        {
            return true;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */