public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> st = new Stack<int>();
        int res = 0;
        foreach(var o in operations)
        {
            if(o=="+")
            {
                int t1 = st.Pop();
                int t2 = st.Pop();
                int sum = t1+t2;
                st.Push(t2);
                st.Push(t1);
                st.Push(sum);
            }
            else if(o=="C")
            {
                st.Pop();
            }
            else if(o=="D")
            {
                st.Push(st.Peek()*2);
            }
            else
            {
                int temp = int.Parse(o);
                st.Push(temp);
            }
        }
        foreach(int i in st)
        {
            res+=i;
        }
        return res;
    }
}