// See https://aka.ms/new-console-template for more information
using AdventOfCode._2023.DayOne;


Console.WriteLine("Sum calibration values of texts");

string[] calibrationDocument = File.ReadAllLines("ressources\\CalibrationDocument.txt");

Console.WriteLine(CalibrationValueProcessor.SumCalibrationValues(calibrationDocument.ToList()));