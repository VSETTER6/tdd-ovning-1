using LeapYearCalculator;

namespace LeapYearTest
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Implementera ÄrSkottår()-funktionen i klassen År, så att den returnerar
        // true eller false beroende på om dess inmatade heltal är ett skottår eller inte.

        //Steg/Krav 1 
        //Alla år delbara med 400 ÄR skottår(så till exempel var 2000 verkligen ett skottår)
        // 1. Skapa en variabel, typ yearChoosen.
        // 2. Kontrollera om den är delbar med 400.
        // 3. Om den är delbar med 400, return true.
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