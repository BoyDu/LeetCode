using System;
using System.Collections.Generic;

class Solution_TwoSum
{
    public static void Start()
    {
        int[] nums = new int[]{ 3, 2, 4 };
        int target = 6;
        int[] ret = TwoSum( nums, target );
        Console.WriteLine( string.Format( "[{0}, {1}]", ret[0], ret[1] ) );
    }
    
    public static int[] TwoSum( int[] nums, int target )
    {
        int[] ret = new int[]{ -1, -1 };;
        Dictionary<int,int> map = new Dictionary<int, int>();
        for( int i = 0; i < nums.Length; i++ )
        {
            map[nums[i]] = i;
        }

        for( int i = 0; i < nums.Length; i++ )
        {
            int needNum = target - nums[i];
            int _index = -1;
            if( map.TryGetValue( needNum, out _index ) )
            {
                if( i != _index )
                {
                    ret[0] = i;
                    ret[1] = _index;
                    break;
                }
            }
        }

        return ret;
    }
}