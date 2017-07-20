// Node RemoveDuplicates(Node head) {
//   // This is a "method-only" submission. 
//   // You only need to complete this method.
//     if(head == null || head.next == null) {
//         return head;
//     }
    
//     head.next = RemoveDuplicates(head.next);
//     if(head.data == head.next.data){
//         head.next = head.next.next;
//     }
//     return head;

// }