using StringUtility;
namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "mysteious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void SearchShouldBeCaseSensitive()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual((int)expectedResult, actualResult);
        }
    }
}