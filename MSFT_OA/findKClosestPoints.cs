

//   static List<int[]> FindKClosestPoints(List<int[]> points, int[] target, int k)
//         {
//             var result = points.OrderBy(point => CalcDistance(target, point)).Take(k).ToList();
//             return result;
//         }

//         private static double CalcDistance(int[] point, int[] target)
//         {
//             return Math.Pow(point[0] - target[0], 2) + Math.Pow(point[1] - target[1], 2);
//         }

//         public static void Main(String[] args)
//         {
//             var points = new List<int[]>();
//             points.Add(new int[] { 2, 0 });s
//             points.Add(new int[] { 1, 0 });
//             points.Add(new int[] { 7, 0 });
//             points.Add(new int[] { 8, 0 });
//             points.Add(new int[] { 3, 0 });
//             points.Add(new int[] { 4, 0 });
//             points.Add(new int[] { 5, 0 });
//             points.Add(new int[] { 6, 0 });

//             FindKClosestPoints(points, new int[] { 7, 0 }, -1);
//         }