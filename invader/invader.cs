﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invader
{
    public class Invader
    {
        static int Main(string[] args) { 
            Console.WriteLine("data = "+ AppDomain.CurrentDomain.GetData("dummy"));
            Console.Write("new data = ");
            AppDomain.CurrentDomain.SetData("dummy", Console.ReadLine());

            return 0x12345678;
        }

        public Invader()
        {
            AppDomain.CurrentDomain.SetData("dummy", "Data set from Invader.Invader.Invader()!");
        }
    }
}
