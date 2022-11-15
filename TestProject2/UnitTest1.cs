using StudentServiceLib;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void score_MustNot_BeGreater_ThanTen()
        {
            Student a = new Student();

            a.Score = 10;

            Assert.AreEqual(10, a.Score);
        }

        [TestMethod]
        public void getAscore()
        {
            Student a = new Student();
            a.Score = 10;

            Assert.AreEqual('A', a.getLetterScore());
        }        
        
        [TestMethod]
        public void getBscore()
        {
            Student a = new Student();
            a.Score = 7.5;

            Assert.AreEqual('B', a.getLetterScore());
        }        
        
        [TestMethod]
        public void getCscore()
        {
            Student a = new Student();
            a.Score = 5.5;

            Assert.AreEqual('C', a.getLetterScore());
        }        
        
        [TestMethod]
        public void getDscore()
        {
            Student a = new Student();
            a.Score = 3.5;

            Assert.AreEqual('D', a.getLetterScore());
        }
    }
}