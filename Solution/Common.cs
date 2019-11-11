//using System.Collections.Generic;
using System;
using System.Text;

namespace Common {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) {
            val = x;
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int x) {
            val = x;
        }
    }

    public class PrintUtil {
        public static void PrintListNode (ListNode head) {
            if (head == null) return;
            StringBuilder sb = new StringBuilder ();
            while (head != null) {
                sb.Append (head.val);
                sb.Append (" ");
                head = head.next;
            }
            Console.WriteLine (sb.ToString ());
        }

        public static void PreorderTraversal( TreeNode root )
        {
            if( root == null ) return;
            Console.WriteLine( root.val );
            PreorderTraversal( root.left );
            PreorderTraversal( root.right );
        }
    }
}