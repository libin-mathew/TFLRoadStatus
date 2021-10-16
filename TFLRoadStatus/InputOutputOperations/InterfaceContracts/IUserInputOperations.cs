

namespace TFLRoadStatus.InputOutputOperations
{
    /// <summary>
    /// Interface define Concrete Implementation for Input Out Operations
    /// </summary>
    interface IUserInputOperations
    {
        /// <summary>
        /// To Read User Input
        /// </summary>
        /// <returns></returns>
        public string ReadInputFromUser();

        /// <summary>
        /// To Print Message to the console
        /// </summary>
        /// <param name="message"></param>
        public void PrintMessageToScreen(string message);

    }
}
