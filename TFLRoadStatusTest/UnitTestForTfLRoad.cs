using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TFLRoadStatus;
using TFLRoadStatus.CoreOperations;
using TFLRoadStatus.CoreOperations.Models;
using TFLRoadStatus.InputOutputOperations;

namespace TFLRoadStatusTest
{
    public class UnitTestForTfLRoad
    {
        private UserInputOperations _inputOperations;
        private TfLRoadStatusChecker _roadStatusChecker = new TfLRoadStatusChecker();

        [SetUp]
        public void Setup()
        {
            _inputOperations = new UserInputOperations();
        }

        #region Mock Data
        public static RoadStatus ValidUserTestData_SucessData()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TFLSuccessResponse.json");
            var mockResponse = File.ReadAllText(filePath);
            var responseObject = JsonConvert.DeserializeObject<List<RoadStatus>>(mockResponse);
            return responseObject.FirstOrDefault();
        }
        #endregion
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
            var roadStatus = ValidUserTestData_SucessData();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var message = @"The status of the A2 is as follows"+ System.Environment.NewLine+"Road Status is Good"+System.Environment.NewLine+"Road Status Description is No Exceptional Delays"+ System.Environment.NewLine;
            _inputOperations.PrintRoadStatusDetails(roadStatus);
            var consoleOutput = stringWriter.ToString();
            Assert.AreEqual(message, consoleOutput);
        }
        #endregion

        #region API Call Tests

        [Test]
        public void RoadStatusCheck_WithValidRoadCode()
        {
            TfLRoadStatusChecker checker = new TfLRoadStatusChecker();
            var baseUrlAddress = Constants.ApiBaseAddress;
            var roadCode = "A2";
            var roadStatus = checker.GetRoadStatus(roadCode).GetAwaiter().GetResult();
            Assert.IsTrue(roadStatus.HttpsStatus);
        }

        [Test]
        public void RoadStatusCheck_WithInvalidRoadCode()
        {
            TfLRoadStatusChecker checker = new TfLRoadStatusChecker();
            var baseUrlAddress = Constants.ApiBaseAddress;
            var roadCode = "AA2";
            var roadStatus = checker.GetRoadStatus(roadCode).GetAwaiter().GetResult();
            Assert.IsFalse(roadStatus.HttpsStatus);
        }

        #endregion

    }
}