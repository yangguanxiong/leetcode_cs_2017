//  // for unsorted array
//         public static int MissingNumber(int[] nums)
//         { //xor
//             int res = nums.Length;
//             for (int i = 0; i < nums.Length; i++)
//             {
//                 res ^= i;
//                 res ^= nums[i];
//             }
//             return res;
//         }

//         // for sorted array
//         public static int MissingNumber2(int[] nums)
//         { //binary search
//             Array.Sort(nums);
//             int left = 0;
//             int right = nums.Length;
//             int mid = (left + right) / 2;
//             while (left < right)
//             {
//                 mid = (left + right) / 2;
//                 if (nums[mid] > mid) right = mid;
//                 else left = mid + 1;
//             }
//             return left;
//         }