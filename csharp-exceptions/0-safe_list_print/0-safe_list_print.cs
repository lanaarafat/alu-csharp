using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i;
        int count = 0;
        try
        {
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (Exception)
        {
            Console.Write("");
        }
        return(count);
    }
}