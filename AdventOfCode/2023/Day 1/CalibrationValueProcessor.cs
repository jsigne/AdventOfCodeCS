using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.DayOne;

public static class CalibrationValueProcessor
{
    private static readonly char[] digits = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];

    public static int ExtractCalibrationValue(string textToCalibrate)
    {
        if (string.IsNullOrEmpty(textToCalibrate))
        {
            return 0;
        }
        char firstDigit = CalibrationValueProcessor.firstDigit(textToCalibrate);
        char lastDigit = CalibrationValueProcessor.lastDigit(textToCalibrate);

        return int.Parse(string.Concat(firstDigit, lastDigit));
    }

    public static int SumCalibrationValues(List<string> texts)
    {
        return texts.Sum(ExtractCalibrationValue);
    }

    private static char firstDigit(string text)
    {
        int firstIndexOfDigit = text.IndexOfAny(digits);
        return text.ElementAt(firstIndexOfDigit);
    }

    private static char lastDigit(string text)
    {
        int lastIndexOfDigit = text.LastIndexOfAny(digits);
        return text.ElementAt(lastIndexOfDigit);
    }
}
