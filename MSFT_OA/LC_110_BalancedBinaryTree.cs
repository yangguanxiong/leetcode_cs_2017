    
    
    
    // public bool IsBalanced(TreeNode root) {
    //     return MaxDepth(root) != -1;       
    // }
    
 
    // private int MaxDepth(TreeNode root) {
    //     if (root == null) {
    //         return 0;
    //     }

    //     int left = MaxDepth(root.left);
    //     int right = MaxDepth(root.right);
    //     if (left == -1 || right == -1 || Math.Abs(left-right) > 1) {
    //         return -1;
    //     }
    //     return Math.Max(left, right) + 1;
    // }