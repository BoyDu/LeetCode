using System;
public class Study_Rand7Rand10
{
    private static Random random7 = new Random();
    
    public static void Start()
    {
        for( int i = 0; i < 1; i++ )
        {
            int ret = rand10();
            Console.WriteLine( ret );
        }
    }

    public static int rand10()
    {
        int x = 0;
        do
        {
            x = ( rand7() - 1 ) * 7 + rand7();
        }while( x > 40 );
        return x % 10 + 1;
    }

    public static int rand7()
    {
        return random7.Next( 1, 7 );
    }
}