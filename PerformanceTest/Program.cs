using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace PerformanceTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var s = args[0];
            
            if(s == "1")
            {
                LoopDoNothing();
            }

            if(s == "2")
            {
                LoopAddString();
            }

            if(s == "3")
            {
                LoopWithBigObject();
            }

            if(s == "4")
            {
                LoopWithNotBigObject();
            }

            if(s == "5")
            {
                AllocatedRate();
            }

            if(s == "6")
            {
                Generation();
            }
            
        }

        private static void Generation()
        {
            while (true)
            {
                var sb = new StringBuilder();
                sb.Append("aaaaaaaaaa");
                sb.ToString();
            }
        }

        private static void AllocatedRate()
        {
            var list = new List<string>();
            while (true)
            {
                var sb = new StringBuilder();
                for (var j = 0; j < 42500; j++)
                {
                    sb.Append("a");
                }
                list.Add(sb.ToString());
                Console.Write(list.Count);
            }
        }

        private static void LoopWithBigObject()
        {
            var list = new List<string>();
            for (var i = 0; i < 100; i ++ )
            {
                var sb = new StringBuilder();
                for (var j = 0; j < 42500; j++)
                {
                    sb.Append("a");
                }
                list.Add(sb.ToString());
            }

            while (true)
            {
                Console.WriteLine(list.Count);
            }
        }

        private static void LoopWithNotBigObject()
        {
            var list = new List<string>();
            for (var i = 0; i < 100; i++)
            {
                var sb = new StringBuilder();
                for (var j = 0; j < 42490; j++)
                {
                    sb.Append("a");
                }
                list.Add(sb.ToString());
            }

            while (true)
            {
                Console.WriteLine(list.Count);
            }
        }

        private static void LoopDoNothing()
        {
            while (true)
            {
                var sb = new StringBuilder();
                Console.Write(".");
            }
        }

        private static void LoopAddString()
        {
            var list = new List<string>();
            while (true)
            {
                var sb = new StringBuilder();
                sb.Append("aaaaaaaaaa");
                list.Add(sb.ToString());
                Console.Write(list.Count);
            }
        }
    }
}