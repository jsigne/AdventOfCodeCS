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
    private static Dictionary<string, string> stringToDigit = new Dictionary<string, string>(){
        {"zero","0" }, {"one","1"}, {"two","2"}, {"three","3"}, {"four","4"}, {"five","5"}, {"six","6"}, {"seven","7"}, {"eight","8"}, {"nine","9"}
    };
    private static readonly List<string> spelledDigits = new List<string>(stringToDigit.Keys);

    public static int ExtractCalibrationValue(string textToCalibrate)
    {
        if (string.IsNullOrWhiteSpace(textToCalibrate))
        {
            return 0;
        }
        string textTransform = ReplaceSpelledDigitByDigit(textToCalibrate);
        char firstDigit = CalibrationValueProcessor.firstDigit(textTransform);
        char lastDigit = CalibrationValueProcessor.lastDigit(textTransform);

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

    private static string ReplaceSpelledDigitByDigit(string text)
    {
        var newText = text;
        spelledDigits.ForEach(spelledDigit => newText = newText.Replace(spelledDigit, stringToDigit[spelledDigit]));
        return newText;
    }
}
