using System;
//using System.Collections.Generic;

namespace LeetCode {
    public class Soulution_SortArrayByParityII {
        public static void Start () {
            int[] A = new int[] { 4, 2, 5, 7 };
            int[] ret = SortArrayByParityII (A);

            for (int i = 0; i < ret.Length; i++) {
                Console.WriteLine (ret[i]);
            }
        }

        public static int[] SortArrayByParityII (int[] A) {
            //even  偶数
            //odd   奇数
            int[] ans = new int[A.Length];
            int evenIndex = 0;
            int oddIndex = 1;
            for (int i = 0; i < A.Length; i++) {
                if (A[i] % 2 == 0) {
                    ans[evenIndex] = A[i];
                    evenIndex += 2;
                } else {
                    ans[oddIndex] = A[i];
                    oddIndex += 2;
                }
            }
            return ans;
        }
    }
}