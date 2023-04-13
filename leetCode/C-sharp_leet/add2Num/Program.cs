

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode p = l1, q = l2, curr = dummyHead;
        int carry = 0;
        while(p != null || q != null)
        {
            int x = (p != null) ? p.val : 0;
            int y = (q != null) ? q.val : 0;

            int sum = carry + x + y;
            carry = sum / 10 ;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;

            if (p != null) p = p.next ;
            if (q != null) q = q.next;

            if (carry > 0) curr.next = new ListNode(carry);
        }
        return dummyHead.next;
    }
    
}


public class Program
{
    public static void Main(string[] args)
    {
        ListNode l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);

        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);

        Solution solution = new Solution();
        ListNode node = solution.AddTwoNumbers(l1, l2);

        while(node != null)
        {
            Console.WriteLine(node.val);
            node = node.next;
        }
    }
}



// public class LinkedListNode
// {
//     public int data;
//     public LinkedListNode next;

//     public LinkedListNode(int data = 0, LinkedListNode next = null)
//     {
//         this.data = data;
//         this.next = next;
//     }
// }


// public class LinkedList
// {
//     int count;
//     public LinkedListNode head;


//     public LinkedList()
//     {
//         head = null;
//         count = 0;
//     }


//     public void AddNodeToFront(int data)
//     {
//         LinkedListNode  node = new LinkedListNode(data);
//         node.next = head;
//         head = node;
//         count++;
//     }

//     public void PrintList()
//     {
//         LinkedListNode current = head;

//         while (current != null)
//         {
//             Console.WriteLine(current);
//             current = current.next;
//         }
//     }

//     public static void Main(string[] args)
//     {
//         LinkedList linkedlist = new LinkedList();
//                 linkedlist.AddNodeToFront(5);
//         linkedlist.AddNodeToFront(7);
//         linkedlist.AddNodeToFront(1);
//         linkedlist.AddNodeToFront(5);
//         linkedlist.AddNodeToFront(10);
//         linkedlist.AddNodeToFront(15);
//         linkedlist.AddNodeToFront(4);
//         linkedlist.PrintList();
//     }
// }