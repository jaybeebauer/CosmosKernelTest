using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosKernelTest
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. v0.1.");
        }
        
        protected override void Run()
        {
            Console.Write(@"input:\> ");
            var input = Console.ReadLine();
               var app = input.Substring(0, input.IndexOf(" "));
               switch (app)
               {
                    case "help":
                         ShowUsage();
                         break;
                    case "?":
                         ShowUsage();
                         break;
                    case "sum":
                         Sum(input);
                         break;
                    default:
                         Console.Write("Command doesn't exist");
                         Console.WriteLine(Environment.NewLine);
                         break;
               }
        }

          private void ShowUsage()
          {
               Console.WriteLine(Environment.NewLine);
               Console.WriteLine("Cosmos OS v0.0.1");
               Console.WriteLine("Writer: Josh Bauer");
               Console.WriteLine("http://www.darlingridge.com.au");
          }

          private void Sum(string input)
          {
              // int i = input.IndexOf(" ") + 1;
              // string str = input.Substring(i);
              // Int32 sum = str.Split(new char[] { ',' })
              //     .Select(n => Int32.Parse(n))
              //     .Sum();
              // Console.WriteLine("Result = {0}",sum);
          }

     }

    
}
