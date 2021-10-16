using System;
using System.IO;
using NUnit.Framework;
using TFLRoadStatus.CoreOperations.Models;
using TFLRoadStatus.InputOutputOperations;

namespace TFLRoadStatusTest
{
    public class UnitTestForTfLRoad
    {
        private UserInputOperations _inputOperations;
        [SetUp]
        public void Setup()
        {
            _inputOperations = new UserInputOperations();
        }

        #region Tests for IO Operations

        [Test]
        public void PrintMessageToScreen()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var message = "Enter Road Code";
            _inputOperations.PrintMessageToScreen(message);
            // Console.WriteLine add new line character along with text
            Assert.AreEqual(message + System.Environment.NewLine, stringWriter.ToString());
        }
        [Test]
        public void ReadInputFromUser()
        {
            var stringReader = new StringReader("A2");
            Console.SetIn(stringReader);
            var message = _inputOperations.ReadInputFromUser();
            Assert.AreEqual("A2", message);
        }

        [Test]
        public void PrintInvalidRoadMessage()
        { 
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var message = "we is not a valid Road";
            _inputOperations.PrintInvalidRoadMessage("we");
            // Console.WriteLine add new line character along with text
            Assert.AreEqual(message + System.Environment.NewLine, stringWriter.ToString());
        }

        [Test]
        public void PrintRoadStatusDetails()
        {
            RoadStatus roadStatus = new RoadStatus();
            roadStatus.DisplayName = "A2";
            roadStatus.StatusSeverity = "Good";
            roadStatus.StatusSeverityDescription = "No Exceptional Delays";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var message = @"The status of the A2 is as follows\r\n Road Status is Good\r\n Road Status Description is No Exceptional Delays\r\n";
            _inputOperations.PrintRoadStatusDetails(roadStatus);
            // Console.WriteLine add new line character along with text
            Assert.AreEqual(message, stringWriter.ToString());
        }
        #endregion

    }
}