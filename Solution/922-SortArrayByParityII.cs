using System;
public class Soulution_SortArrayByParityII {
    public static void Start () {
        //int[] A = new int[] { 4, 2, 5, 7 };
        int[] A = new int[] { 4 };
        //int[] ret = SortArrayByParityII (A);
        int[] ret = SortArrayByParityII_2 (A);

        for (int i = 0; i < ret.Length; i++) {
            Console.WriteLine (ret[i]);
        }
    }

    public static int[] SortArrayByParityII_2 (int[] A) {
        int p = 0;
        for (int i = 0; i < A.Length; i++) {
            p = i;
            if (i % 2 != A[i] % 2) {
                p++;
                while (p < A.Length) {
                    if (i % 2 == A[p] % 2) {
                        int temp = A[i];
                        A[i] = A[p];
                        A[p] = temp;
                        break;
                    }
                    p++;
                }
            }
        }
        return A;
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