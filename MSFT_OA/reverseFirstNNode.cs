


//   public static ListNode ReverseFirstNNodes(ListNode head, int n)
//         {
//             if (head == null || head.next == null || n <= 1)
//             {
//                 return head;
//             }

//             ListNode newHead = null;            
//             var oldHead = head;
//             for (int i = 1; i <= n; i++) {
//                 var next = head.next;
//                 head.next = newHead;
//                 newHead = head;
//                 head = next;
//                 if (head == null) {
//                     break;
//                 }                
//             }

//             oldHead.next = head;
//             return newHead; 
//         }



//         public static void Main(String[] args)
//         {
//             var list = ListNode.GenerateList(10);
//             ListNode.PrintList(list);
//             var res = ReverseFirstNNodes(list, 9);
//             ListNode.PrintList(res);
//         }