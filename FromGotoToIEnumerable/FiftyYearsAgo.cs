using System;

namespace FromGotoToIEnumerable
{
    internal static class FiftyYearsAgo
    {
        internal static void LoopWithGoto()
        {
            int i = 0;
        printloop:
            Console.WriteLine(i);
            i++;
            if (i < 10)
            {
                goto printloop;
            }
            Console.ReadLine();
        }
    }
}
