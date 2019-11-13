using System;
public class Soulation_SearchMatrix
{
    public static void Start()
    {
        int[,] m = new int[5,5]
        {
            {1,   4,  7, 11, 15},
            {2,   5,  8, 12, 19},
            {3,   6,  9, 16, 22},
            {10, 13, 14, 17, 24},
            {18, 21, 23, 26, 30}
        };

        bool ok = SearchMatrix( m, 3 );
        Console.WriteLine( ok );
    }

    public static bool SearchMatrix( int[,] matrix, int target )
    {
        int length = matrix.GetLength(0);
        int left = 0;
        int right = length - 1;
        int top = 0;
        int bottom = length - 1;

        while( left < right || top < bottom )
        {
            int x_mid = ( left + right + 1 ) / 2;
            int y_mid = ( top + bottom + 1 ) / 2;

            if( matrix[x_mid,y_mid] > target )
            {
                right = x_mid - 1;
                bottom = y_mid - 1;
            }
            else
            {
                left = x_mid;
                top = y_mid;
            }
        }

        int x = ( left + right + 1 ) / 2;
        int y = ( top + bottom + 1 ) / 2;

        if( matrix[x,y] == target )
            return true;
        return false;
    }
}