/*
 * C# Program to Create a Gray Code
 */

using System;

namespace gray_code
{
    public class Gray
    {
        public static ulong grayEncode(ulong n)
        {
            return n ^ (n >> 1);
        }
    }
}
