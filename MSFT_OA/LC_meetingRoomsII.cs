// /**
//  * Definition for an interval.
//  * public class Interval {
//  *     public int start;
//  *     public int end;
//  *     public Interval() { start = 0; end = 0; }
//  *     public Interval(int s, int e) { start = s; end = e; }
//  * }
//  */
// public class Solution {
//     public int MinMeetingRooms(Interval[] intervals) {
//         var start = new int[intervals.Length];
//         var end = new int[intervals.Length];
        
//         for (int i = 0; i < intervals.Length; i++) {
//             start[i] = intervals[i].start;
//             end[i] = intervals[i].end;
//         }
        
//         Array.Sort(start);
//         Array.Sort(end);
        
//         int rooms = 0;
//         int j = 0;
//         for (int i = 0; i < intervals.Length; i++) {
//             if (start[i] < end[j]) {
//                 rooms++;
//             } else {
//                 j++;
//             }
//         }
        
//         return rooms;
//     }
// }