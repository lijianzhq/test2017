﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSqlSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_Query.Start();
            Test_Delete.Start();

            Console.Read();
        }
    }
}
