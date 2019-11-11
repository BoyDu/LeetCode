//using System.Collections.Generic;
using System.Text;
using System;

namespace Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode( int x )
        { 
            val = x; 
        }
    }

    public class PrintUtil
    {
        public static void PrintListNode( ListNode head )
        {
            if( head == null ) return;
            StringBuilder sb = new StringBuilder();
            while( head != null )
            {
                sb.Append( head.val );
                sb.Append( " " );
                head = head.next;
            }
            Console.WriteLine( sb.ToString() );
        }
    }
}