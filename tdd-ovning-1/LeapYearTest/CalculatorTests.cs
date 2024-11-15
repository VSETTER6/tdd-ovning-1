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
        // Alla �r som �r delbara med 100 men inte med 400 �r INTE skott�r(s� till exempel 1700, 1800 och 1900
        // var INTE skott�r, inte heller kommer 2100 att vara ett skott�r)
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
        // Alla �r delbara med 4 men inte med 100 �R skott�r(t.ex. 2008, 2012, 2016)
    }
}