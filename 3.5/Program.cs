﻿namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 3;
            var y = 2 + ++x;

            x = 3 << 2;
            y = 10 >> 1;

            x = 10 & 8;
            y = 10 | 7;
        }
    }
}