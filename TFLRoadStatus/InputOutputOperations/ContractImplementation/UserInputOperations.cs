using System;
using TFLRoadStatus.CoreOperations.Models;

namespace TFLRoadStatus.InputOutputOperations
{
    /// <summary>
    /// Input Output Operations.
    /// Class implementing IUserInputOperations.
    /// </summary>
    public class UserInputOperations : IUserInputOperations
    {
        /// <summary>
        /// To Write message to the console
        /// </summary>
        /// <param name="message"></param>
        public void PrintMessageToScreen(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// To Read User Input
        /// </summary>
        /// <returns></returns>
        public string ReadInputFromUser()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }

        /// <summary>
        /// Method to Print Road Status Details
        /// </summary>
        /// <param name="roadStatus"></param>
        public void PrintRoadStatusDetails(RoadStatus roadStatus)
        {
            PrintMessageToScreen(string.Format("The status of the {0} is as follows", roadStatus.DisplayName));
            PrintMessageToScreen(string.Format("Road Status is {0}", roadStatus.StatusSeverity));
            PrintMessageToScreen(string.Format("Road Status Description is {0}", roadStatus.StatusSeverityDescription));
        }
        public void PrintInvalidRoadMessage(string roadCode)
        {
            PrintMessageToScreen(string.Format("{0} is not a valid Road",roadCode));
        }
    }
}
