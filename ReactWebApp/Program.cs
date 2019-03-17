using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ReactWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();



        public int FibonacciGenerator(int input)
        {
            if(input <= 1)
            {
                return input;
            }
            List<int> numberStack = new List<int> {0,1,1};
            int output = 0;
            for (int itteration = 2; itteration <= input -1; itteration++)
            {
                output = numberStack[itteration] + numberStack[itteration - 1];
                numberStack.Add(output);
            }

            return output;
        }
    }
}
