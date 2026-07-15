public class MyHashSet {
    public int[] storage;
    public MyHashSet() {
        storage=new int[1000001];
        for(int i=0;i<storage.Length;i++)
        {
            storage[i]=-1;
        }
    }
    
    public void Add(int key) {
        storage[key]=key;
    }
    
    public void Remove(int key) {
        storage[key]=-1;
    }
    
    public bool Contains(int key) {
        return storage[key]!=-1;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */