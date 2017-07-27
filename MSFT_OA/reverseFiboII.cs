        // public static int[] ReverseFiboII(int a, int b, int n) {
        //     // input is small, 2,3
        //     var result = new int[n];
        //     if (n == 0) return result;
        //     if (a > b) {
        //         int temp = a; 
        //         a = b;
        //         b = temp;
        //     }

        //     if (n >= 1) {
        //         result[n - 1] = a;                           
        //     } 
            
        //     if (n >= 2) {                
        //         result[n - 2] = b;                 
        //     }

        //     for (int i = n - 3; i >= 0; i--) {
        //         result[i] = result[i + 2] + result[i + 1];                
        //     }

        //     return result;
        // }