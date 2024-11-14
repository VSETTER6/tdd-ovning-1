using LeapYearCalculator;

namespace LeapYearTest
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Implementera �rSkott�r()-funktionen i klassen �r, s� att den returnerar
        // true eller false beroende p� om dess inmatade heltal �r ett skott�r eller inte.

        //Steg/Krav 1 
        //Alla �r delbara med 400 �R skott�r(s� till exempel var 2000 verkligen ett skott�r)
        // 1. Skapa en variabel, typ yearChoosen.
        // 2. Kontrollera om den �r delbar med 400.
        // 3. Om den �r delbar med 400, return true.
        // 4. Om inte retunera false.
        [Test]
        [TestCase (true, 2000)]
        [TestCase(false, 1999)]
        public void Test(bool isYearLeapYear, int choosenYear)
        {
            // Arrange
            Year year = new Year();

            // Act
            //bool expectedResult = year.IsChoosenYearLeapYear(isYearLeapYear, choosenYear);
            bool expectedResult = false;

            // Assert
            Assert.AreEqual(expectedResult, isYearLeapYear);
        }

    }
}