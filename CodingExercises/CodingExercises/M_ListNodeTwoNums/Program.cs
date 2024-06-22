namespace M_ListNodeTwoNums;

class Program
{
    static void Main(string[] args)
    {
        // var tmp = new ListNode();
        var head = new ListNode();
        var tail = new ListNode();
        var tmp = new ListNode();

        for (int i = 0; i < 10; i++)
        {
            if (head.next == null)
                head = tmp;
            
            head.val = i;
            head.next = tmp;
        }
        
        while()
    }
}

class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}