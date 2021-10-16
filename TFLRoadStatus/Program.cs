using System;
using TFLRoadStatus.CoreOperations;

namespace TFLRoadStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                TaskManager.RunAsync("gg").GetAwaiter().GetResult();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
