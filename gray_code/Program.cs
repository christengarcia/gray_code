/*
 * C# Program to Create a Gray Code
 */

using System;

namespace gray_code
{
    public class Gray
    {
        public static ulong GrayEncode(ulong n)
        {
            return n ^ (n >> 1);
        }

        public static ulong GrayDecode(ulong n)
        {
            ulong i = 1 << 8 * 64 - 2; //long is 64-bit
            ulong p, b = p = n & i;

            while ((i >>= 1) > 0)
                b |= p = n & i ^ p >> 1;
            return b;
        }
    }
}
