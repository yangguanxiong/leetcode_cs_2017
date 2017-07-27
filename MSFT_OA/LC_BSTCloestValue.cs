//  public int ClosestValue(TreeNode root, double target) {
//         if(root.val == target) return root.val;
//         var kid = root.val > target ? root.left : root.right;
//         if(kid == null) return root.val;
//         int kidVal = ClosestValue(kid, target);
//         return Math.Abs(target - root.val) < Math.Abs(target - kidVal) ? root.val : kidVal;
      
        
//     }