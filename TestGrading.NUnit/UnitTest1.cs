using System.Threading.Tasks.Dataflow;
using TestGrading;

namespace TestGradingNUnit
{
    public class UnitTest1
    {

        [Test]
        public void TS101_GradeBelowZero()
        {
            // Arrange
            int score = -2;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("Invalid", grade);
        }

        [Test]
        public void TS102_GradeA()
        {
            int score = 84;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("A", grade);
        }

        [Test]
        public void TS201_OutputBelowZero()
        {
            int score = -2;
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Grading.PrintOut(score);
            string exp = "Error: Score is lower than zero\r\n";
            Assert.AreEqual(exp, sw.ToString());
        }
    }
}