        // public static int[] ReverseFibo(int a, int b, int n) {
        //     var result = new int[n];
        //     if (n == 0) return result;
        //     if (a < b) {
        //         int temp = a; 
        //         a = b;
        //         b = temp;
        //     }

        //     if (n >= 1) {
        //         result[0] = a;                           
        //     } 
            
        //     if (n >= 2) {                
        //         result[1] = b;                 
        //     }

        //     for (int i = 2; i < n; i++) {
        //         result[i] = result[i - 2] - result[i - 1];
        //         // if (result[i] == 0) break;  ???
        //     }

        //     return result;
        // }