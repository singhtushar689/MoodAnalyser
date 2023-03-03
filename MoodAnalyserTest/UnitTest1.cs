using MoodAnalyserProblem;
namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyzer moodAnalyser = new MoodAnalyzer();

        [Test]
        public void Given_MoodWhenAnalysed_ShouldReturnSad()
        {
            string result = moodAnalyser.AnalyseMood("I am in sad mood");
            Assert.AreEqual(result,"Sad");
        }
    }
}