using System;
using TFLRoadStatus.CoreOperations;
using TFLRoadStatus.InputOutputOperations;

namespace TFLRoadStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            TfLRoadStatusChecker checker = new TfLRoadStatusChecker();
            UserInputOperations userInputOperations = new UserInputOperations();
            int exitCode = 0;

            try
            {
                userInputOperations.PrintMessageToScreen("TFL Road Status Checker");
                userInputOperations.PrintMessageToScreen("Enter Road Code");
                var roadCode = userInputOperations.ReadInputFromUser();
                var roadStatus = checker.GetRoadStatus(roadCode).GetAwaiter().GetResult();
                if (roadStatus.HttpsStatus)
                {
                    userInputOperations.PrintRoadStatusDetails(roadStatus);
                    exitCode = 0;
                }
                else
                {
                    userInputOperations.PrintInvalidRoadMessage(roadCode);
                    exitCode = 1;
                }

            }
            catch (Exception)
            {
                exitCode = 1;
                userInputOperations.PrintMessageToScreen("Error Occurred while processing the Request");
            }
            finally
            {
                Environment.Exit(exitCode);
            }
        }
    }
}
