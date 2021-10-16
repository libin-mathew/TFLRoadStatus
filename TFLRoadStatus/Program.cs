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
                TfLRoadStatusChecker checker = new TfLRoadStatusChecker();
                checker.GetRoadStatus("zczx").GetAwaiter().GetResult();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
