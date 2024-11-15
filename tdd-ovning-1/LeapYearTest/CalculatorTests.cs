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
        [TestCase(1999, false)]
        [TestCase(2001, false)]
        [TestCase(2000, true)]
        public void IsChoosenYearLeapYear(int choosenYear, bool expectedResult)
        {
            // Arrange
            Year year = new Year();

            // Act
            bool actualResult = year.IsChoosenYearLeapYear(choosenYear);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Steg/Krav 2
        // Alla år som är delbara med 100 men inte med 400 är INTE skottår(så till exempel 1700, 1800 och 1900
        // var INTE skottår, inte heller kommer 2100 att vara ett skottår)
        // 1. if (variable % 100 == 0) return true.
        // 2. if variable % 400 == 0) return false.
        [Test]
        [TestCase(1800, true)]
        [TestCase(1700, true)]
        [TestCase(2000, false)]
        [TestCase(1600, false)]
        public void IsChoosenYearDivisableBy100AndNotALeapYear(int choosenYear, bool expectedResult)
        {
            // Arrange
            Year year = new Year();

            // Act
            bool actualResult = year.IsChoosenYearDivisableBy100(choosenYear);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Steg/Krav 3
        // Alla år delbara med 4 men inte med 100 ÄR skottår(t.ex. 2008, 2012, 2016)
    }
}