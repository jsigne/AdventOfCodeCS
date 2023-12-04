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
    private static Dictionary<string, char> stringToCharDigit = new Dictionary<string, char>(){
        {"zero",'0'}, {"one",'1'}, {"two",'2'}, {"three",'3'}, {"four",'4'}, {"five",'5'}, {"six",'6'}, {"seven",'7'}, {"eight",'8'}, {"nine",'9'},
        {"0",'0'}, {"1",'1'}, {"2",'2'}, {"3",'3'}, {"4",'4'}, {"5",'5'}, {"6",'6'}, {"7",'7'}, {"8",'8'}, {"9",'9'}
    };

    public static int ExtractCalibrationValue(string textToCalibrate)
    {
        if (string.IsNullOrWhiteSpace(textToCalibrate))
        {
            return 0;
        }
        char firstDigit = CalibrationValueProcessor.FirstDigit(textToCalibrate);
        char lastDigit = CalibrationValueProcessor.LastDigit(textToCalibrate);

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

    private static char FirstDigit(string text)
    {
        List<string> strDigits = new List<string>(stringToCharDigit.Keys);
        char digit = '0';
        int min = int.MaxValue;
        foreach (string d in strDigits)
        {
            if (text.Contains(d) && text.IndexOf(d) < min)
            {
                digit = stringToCharDigit[d];
                min = text.IndexOf(d);
            }
        }
        return digit;
    }

    private static char LastDigit(string text)
    {
        List<string> strDigits = new List<string>(stringToCharDigit.Keys);
        char digit = '0'; 
        int lastIndexOf = int.MinValue;
        foreach (string strDigit in strDigits)
        {
            if (text.LastIndexOf(strDigit) > lastIndexOf)
            {
                digit = stringToCharDigit[strDigit];
                lastIndexOf  = text.LastIndexOf(strDigit);
            }
        }
        return digit;
    }
}
