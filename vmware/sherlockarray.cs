class solution{
    static string solve(int[] a){
        // Complete this function
        if(a.Length <= 1) return "YES";
        var rightSum = new int[a.Length];
        var leftSum = new int[a.Length];
          
        for(int i = a.Length - 2; i >= 0; i--){
            rightSum[i] = rightSum[i+1] + a[i+1];
        }
        if(rightSum[0] == 0) {
            return "YES";
        }
        for(int i = 1; i < a.Length; i++){
            leftSum[i] = leftSum[i-1] + a[i-1];
            if(leftSum[i] == rightSum[i]){
                return "YES";
            }
        }
        return "NO";        
    }

}  