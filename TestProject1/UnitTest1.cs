using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserMSTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = "I Am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);

        }
        [TestMethod]

        [DataRow(null)]
        public void GivenSadMoodShouldReturnHappy(string message)
        {
            string expected = "Happy";

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);

        }



        [TestMethod]
        public void ForEmpty()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {

                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        [TestMethod]
        public void ForNull()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {

                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

    }
}
