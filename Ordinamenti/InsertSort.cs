using System;

namespace MetodiOrdinamenti
{
    public class InsertSort
    {
        public static int[] Insert_Sort (int[]a)
        {
            int flag;
            int val;
            for (int i = 1; i < a.Length; i++)
            {
                val = a[i];
                flag = i - 1;
                while (flag >= 0 && a[flag] > val)
                {
                    a[flag + 1] = a[flag];
                    flag--;
                }
                a[flag + 1] = val;
            }
            return a;
        }
    }
}
