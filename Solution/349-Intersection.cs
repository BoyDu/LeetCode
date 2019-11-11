using System;
using System.Collections.Generic;

namespace LeetCode {
    public class Soulution_Intersection {
        public static void Start () {
            int[] nums1 = new int[] { 4, 9, 5 };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
            int[] ret = Intersection (nums1, nums2);

            for (int i = 0; i < ret.Length; i++) {
                Console.WriteLine (ret[i]);
            }
        }

        public static int[] Intersection (int[] nums1, int[] nums2) {
            Dictionary<int, int> map = new Dictionary<int, int> ();
            for (int i = 0; i < nums1.Length; i++) {
                map[nums1[i]] = nums1[i];
            }

            List<int> section = new List<int> { };
            for (int j = 0; j < nums2.Length; j++) {
                int cache = 0;
                if (map.TryGetValue (nums2[j], out cache)) {
                    section.Add (nums2[j]);
                    map.Remove (nums2[j]);
                }
            }
            return section.ToArray ();
        }
    }
}