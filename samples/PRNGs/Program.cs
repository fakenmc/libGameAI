﻿using System;
using LibGameAI.PRNG;

namespace LibGameAI.Samples.PRNGs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new LCG(123);
            Console.WriteLine(r.Next(100));
        }
    }
}
