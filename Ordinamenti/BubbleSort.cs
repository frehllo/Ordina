using System;
using System.Collections.Generic;
using System.Text;

namespace MetodiOrdinamenti
{
    public class BubbleSort
    {
        public static int[] Bubble_Sort(int [] a)
        {
            for(int x = 0; x < a.Length-1; x++)
            {
                for( int y = 0; y < a.Length-1; y++ )
                {
                    if(a[y] > a[y+1])
                    {
                        int tempo = a[y];
                        a[y] = a[y + 1];
                        a[y + 1] = tempo;
                    }
                }
            }
            return a;
        }
    }
}
