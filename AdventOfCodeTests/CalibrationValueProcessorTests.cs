using AdventOfCode._2023.DayOne;

namespace AdventOfCodeTests
{
    public class CalibrationValueProcessorTests
    {

        [Fact]
        public void Calibration_Should_Return_0()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "";


            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(0, actualResult);
            
        }

        [Fact]
        public void Calibration_Whitespace_Should_Return_0()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "   ";


            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(0, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_12()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "1abc2";

            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(TEXT_TO_CALIBRATE);

            //assert
            actualResult.Should().Be(12);
            
        }

        [Fact]
        public void Calibration_Should_Return_38()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "pqr3stu8vwx";


            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(38, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_15()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "a1b2c3d4e5f";


            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(15, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_77()
        {
            //arrange
            const string TEXT_TO_CALIBRATE = "treb7uchet";


            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(TEXT_TO_CALIBRATE);

            //assert
            Assert.Equal(77, actualResult);
            
        }

        [Fact]
        public void Calibration_Should_Return_50()
        {
            //arrange
            List<string> textsToCalibrate = ["pqr3stu8vwx", "1abc2"];

            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.SumCalibrationValues(textsToCalibrate);

            //assert
            Assert.Equal(50, actualResult);
        }
        

        [Fact]
        public void Calibration_Should_Return_32()
        {
            //arrange
            string textsCalibrate = "three1two";

            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(textsCalibrate);

            //assert
            Assert.Equal(32, actualResult);
        }        

        [Fact]
        public void Calibration_Should_Return_42()
        {
            //arrange
            string textsCalibrate = "4threetwo";

            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(textsCalibrate);

            //assert
            Assert.Equal(42, actualResult);
        }     

        [Fact]
        public void Calibration_OneSpelledDigit_Should_Return_22()
        {
            //arrange
            string textsCalibrate = "two";

            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.ExtractCalibrationValue(textsCalibrate);

            //assert
            Assert.Equal(22, actualResult);
        }

        [Fact]
        public void SumCalibration_Should_Return_42()
        {
            //arrange
            List<string> textsToCalibrate = ["pqr3stfouruninevwx", "oneabc2"];

            //act
            var actualResult = AdventOfCode._2023.DayOne.CalibrationValueProcessor.SumCalibrationValues(textsToCalibrate);

            //assert
            Assert.Equal(51, actualResult);
        }
    }
}