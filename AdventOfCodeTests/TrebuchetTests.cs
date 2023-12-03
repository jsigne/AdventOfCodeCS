using AdventOfCode._2023.DayOne;

namespace AdventOfCodeTests
{
    public class TrebuchetTests
    {

        [Fact]
        public void Calibration_Should_Return_0()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "";


            //act
            var actualResult = Trebuchet.Calibrate(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(0, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_12()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "1abc2";

            //act
            var actualResult = Trebuchet.Calibrate(TEXT_TO_CALIBRATE);

            //assert
            actualResult.Should().Be(12);
            
        }

        [Fact]
        public void Calibration_Should_Return_38()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "pqr3stu8vwx";


            //act
            var actualResult = Trebuchet.Calibrate(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(38, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_15()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "a1b2c3d4e5f";


            //act
            var actualResult = Trebuchet.Calibrate(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(15, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_77()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "treb7uchet";


            //act
            var actualResult = Trebuchet.Calibrate(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(77, actualResult);
            
        }
    }
}