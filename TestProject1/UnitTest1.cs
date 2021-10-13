using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20_MoodAnalyserProblem;



namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //UC-1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            //Arrange
            string message = null;
            object expected = new MoodAnalyzer(message);
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20_MoodAnalyserProblem.MoodAnalyzer", "MoodAnalyzer");
            //Assert
            Assert.AreNotEqual(expected, obj);
        }
        //TC-1.1
        [TestMethod]
        public void GivenMoodIAmInSadMood_ShouldReturnSad()
        {
            //Arrange
            MoodAnalyzer obj = new MoodAnalyzer("I am in sad Mood");
            string expected = "SAD";
            //Act
            string result = obj.analyseMood();

            //Assert
            Assert.AreEqual(expected, result);

        }
        //TC-1.2
        [TestMethod]
        public void GivenIAmInAnyMood_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyzer obj = new MoodAnalyzer("I am in any Mood");
            string expected = "HAPPY";
            //Act
            string result = obj.analyseMood();

            //Assert
            Assert.AreEqual(expected, result);

        }
        //TC-2.1
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void GivenNullMoodShouldReturnHappy()
        {
            //Arrange
            string message = null;
            MoodAnalyzer obj = new MoodAnalyzer(message);
            string expected = "HAPPY";
            //Act
            string result = obj.analyseMood();

            //Assert
            Assert.AreEqual(expected, result);

        }
        //TC-3.1
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void GivenNullMoodShouldThrowNullException()
        {
            //Arrange
            string message = null;
            MoodAnalyzer obj = new MoodAnalyzer(message);
            string expected = "Mood should not be null";
            //Act
            string result = obj.analyseMood();

            //Assert
            Assert.AreEqual(expected, result);

        }
        //TC-3.2
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void GivenEmptyMoodShouldThrowEmptyMoodException()
        {
            //Arrange
            string message = string.Empty;
            MoodAnalyzer obj = new MoodAnalyzer(message);
            string expected = "Mood should not be empty";
            //Act
            string result = obj.analyseMood();

            //Assert
            Assert.AreEqual(expected, result);

        }
        //Tc-4.1
        [TestMethod] //2
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {   //Arrange
            object expected = new MoodAnalyzer("HAPPY");
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20_MoodAnalyserProblem.MoodAnalyzer", "MoodAnalyzer");
           //Assert
            expected.Equals(obj);

        }
        //Tc-4.2
        [TestMethod]
       [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void GivenMoodAnalyseWrongClassName_ShouldReturnMoodAnalyseObject_ShouldThrowNoSuchClass()
        {   //Arrange
            string expected = "Class not found";
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20_MoodAnalyserProblem.MoodAnalyzerWrong", "MoodAnalyzer");
            //Assert
            Assert.AreEqual(expected, obj);

        }
        //Tc-4.3
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void GivenConstructorNameImproperShouldThrowExceptionNoSuchMethod()
        {   //Arrange
            object expected = new MoodAnalyzer("HAPPY");
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20_MoodAnalyserProblem.MoodAnalyzer", "MoodAnalyzerwrong");
            //Assert
            expected.Equals(obj);


        }
        //TC-5.1
        [TestMethod]
        public void CreateMoodAnalyseUsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_MoodAnalyserProblem.MoodAnalyzer", "MoodAnalyzer", "SAD");
            expected.Equals(obj);

        }
        //TC-5.2
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void whenGivenWrongClasNameShouldThrowExceptionClassNotFound()
        {       
            string Msgexpected = "Class not found";
            //Inserted wrong class name.
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_MoodAnalyserProblem.MoodAnalyzerWrong", "MoodAnalyzer", "SAD");
            Assert.AreEqual(Msgexpected, obj);

        }
        //TC-5.3
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyzerCustomException))]
        public void whenGivenWrongConstructorNameShouldThrowExceptionMethodNotFound()
        {
            string Msgexpected = "Constructor is not found";
            //inserted wrong Constructor name.
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_MoodAnalyserProblem.MoodAnalyzer", "MoodAnalyzerWrong", "SAD");
            Assert.AreEqual(Msgexpected, obj);

        }


    }
}
