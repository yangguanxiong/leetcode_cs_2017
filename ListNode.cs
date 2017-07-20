class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        this.val = x;
    }

    public static ListNode GenerateList(int length)
    {
        if (length <= 0) return null;
        var head = new ListNode(0);
        var current = head;
        while (length > 1)
        {
            current.next = new ListNode(current.val + 1);
            current = current.next;
            length--;
        }
        return head;
    }
    public static ListNode GenerateList(int[] arr)
    {
        if (arr.Length <= 0) return null;
        int i = 0;
        var head = new ListNode(arr[i++]);
        var r = head;
        while (i < arr.Length) {
            r.next = new ListNode(arr[i]);
            r = r.next;
            i++;
        }
        return head;      
    }

    public static void PrintList(ListNode head)
    {
        System.Console.WriteLine("printing list...");
        while (head != null)
        {
            System.Console.Write(head.val + " ");
            head = head.next;
        }
        System.Console.WriteLine();
        System.Console.WriteLine("print completed. ");
    }
}