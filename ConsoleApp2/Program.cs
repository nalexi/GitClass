﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[2] { "valor 1", "valor 2 " };
            foreach (var item in nameList)
                Console.WriteLine(item);

            string[] dateList = new string[10000];
            DateTime firstTime = DateTime.Now;

            for (int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("yyyy-MM-dd-hh:mm:ssfff");
                Console.WriteLine(dateList[i]);
            }

                Console.WriteLine((DateTime.Now - firstTime).ToString());

            //foreach (var item in dateList)
            //{
            //    Console.WriteLine(item);
            //}


            Console.ReadKey();

        }
    }
}
