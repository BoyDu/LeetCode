using System;
using Common;

public class Solution_IsValidBST
{
    public static void Start()
    {
        /* 
        TreeNode root = new TreeNode( 2 );
        root.left = new TreeNode( 1 );
        root.right = new TreeNode( 3 );
        */

        
        TreeNode root = new TreeNode( 5 );
        root.left = new TreeNode( 1 );
        TreeNode r_right = new TreeNode( 7 );
        root.right = r_right;
        r_right.left = new TreeNode( 3 );
        r_right.right = new TreeNode( 9 );
        
        //PrintUtil.PreorderTraversal( root );

        bool isValid = IsValidBST( root );
        Console.WriteLine( isValid );
    }

    public static bool IsValidBST( TreeNode root )
    {
        return Helper( root, null, null );
        //return Helper2( root, null );
    }

    public static bool Helper2( TreeNode root, int? v )
    {
        if( root == null ) return true;

        return true;
    }

    public static bool Helper( TreeNode root, int? lower, int? upper )
    {
        if( root == null ) return true;
        if( lower != null && root.val < lower ) return false;
        if( upper != null && root.val > upper ) return false;
        Console.WriteLine( string.Format( "val = {0}, lower = {1}, upper = {2}", root.val, lower, upper ) );
        if( !Helper( root.right, root.val, upper ) ) return false;
        if( !Helper( root.left, lower, root.val ) ) return false;
        return true;
    }
}